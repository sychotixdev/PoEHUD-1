module Generators

open System
open System.Security.Cryptography

[<Literal>]
let table = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"

let randomizer = new Random()

let rec generateName min max invalid =
    let name =
        randomizer.Next(min, max)
        |> Array.zeroCreate
        |> Array.map (fun _ -> table.[randomizer.Next(table.Length)])
        |> fun array -> new string(array) + ".exe"
    if invalid name then generateName min max invalid
    else name

let generateCSum size =
    let csum = Array.zeroCreate size
    use rngCsp = new RNGCryptoServiceProvider()
    rngCsp.GetBytes csum
    csum