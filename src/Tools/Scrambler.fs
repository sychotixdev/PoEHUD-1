namespace Tools

open System
open System.Diagnostics
open System.IO
open System.Reflection
open System.Windows.Forms
open Generators

[<AbstractClass; Sealed>]
type Scrambler private () =

    [<Literal>]
    static let e_csum = 0x12

    static let invalid =
        let names = [| "calculator.exe"; "poehud.exe"; "exilehud.exe"; "exilebuddy.exe" |]
        let compare name illegal = String.Equals(name, illegal, StringComparison.InvariantCultureIgnoreCase)
        fun name -> Array.exists (compare name) names

    static let encryptFile srcPath =
        let fileData = File.ReadAllBytes srcPath
        let csum = generateCSum 4
        Buffer.BlockCopy(csum, 0, fileData, e_csum, csum.Length)
        let dstFileName = generateName 3 12 invalid
        let dstPath = Path.Combine(Path.GetDirectoryName srcPath, dstFileName)
        File.WriteAllBytes(dstPath, fileData)
        dstPath

    static member Scramble parameter =
        let showError message = MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) |> ignore
        match parameter with
        | p when String.IsNullOrWhiteSpace(p) ->
            let mutable result = true
            try
                let srcPath = Assembly.GetEntryAssembly().Location
                if invalid (Path.GetFileName srcPath)
                   || (new FileInfo(srcPath)).CreationTimeUtc < DateTime.UtcNow.AddDays -0.5 then
                    let dstPath = encryptFile srcPath
                    Process.Start("CMD.exe", "/c  mklink PoeHud "+ dstPath) |> ignore
                    Process.Start(dstPath, sprintf "\"%s\"" srcPath) |> ignore
                else result <- false
            with ex -> showError (sprintf "Failed to encrypt a file: %s" ex.Message)
            result
        | oldFile ->
            try
                File.Delete oldFile
            with _ ->
                let filename = Path.GetFileName oldFile
                showError (sprintf "Failed to delete \"%s\" file" filename)
            false
