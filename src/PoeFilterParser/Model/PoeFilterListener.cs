using Antlr4.Runtime.Misc;

#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PoeFilterParser.Model
{
    using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;

    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
    [System.CLSCompliant(false)]
    public interface IPoeFilterListener : IParseTreeListener
    {
        void EnterStrValue([NotNull] PoeFilterParser.StrValueContext context);

        void ExitStrValue([NotNull] PoeFilterParser.StrValueContext context);

        void EnterSocketValue([NotNull] PoeFilterParser.SocketValueContext context);

        void ExitSocketValue([NotNull] PoeFilterParser.SocketValueContext context);

        void EnterRarityValue([NotNull] PoeFilterParser.RarityValueContext context);

        void ExitRarityValue([NotNull] PoeFilterParser.RarityValueContext context);

        void EnterCompareOpNullable([NotNull] PoeFilterParser.CompareOpNullableContext context);

        void ExitCompareOpNullable([NotNull] PoeFilterParser.CompareOpNullableContext context);

        void EnterVisibility([NotNull] PoeFilterParser.VisibilityContext context);

        void ExitVisibility([NotNull] PoeFilterParser.VisibilityContext context);

        void EnterParams([NotNull] PoeFilterParser.ParamsContext context);

        void ExitParams([NotNull] PoeFilterParser.ParamsContext context);

        void EnterDigitsParams([NotNull] PoeFilterParser.DigitsParamsContext context);

        void ExitDigitsParams([NotNull] PoeFilterParser.DigitsParamsContext context);

        void EnterRariryParams([NotNull] PoeFilterParser.RariryParamsContext context);

        void ExitRariryParams([NotNull] PoeFilterParser.RariryParamsContext context);

        void EnterSocketParams([NotNull] PoeFilterParser.SocketParamsContext context);

        void ExitSocketParams([NotNull] PoeFilterParser.SocketParamsContext context);

        void EnterRed([NotNull] PoeFilterParser.RedContext context);

        void ExitRed([NotNull] PoeFilterParser.RedContext context);

        void EnterGreen([NotNull] PoeFilterParser.GreenContext context);

        void ExitGreen([NotNull] PoeFilterParser.GreenContext context);

        void EnterBlue([NotNull] PoeFilterParser.BlueContext context);

        void ExitBlue([NotNull] PoeFilterParser.BlueContext context);

        void EnterAlpha([NotNull] PoeFilterParser.AlphaContext context);

        void ExitAlpha([NotNull] PoeFilterParser.AlphaContext context);

        void EnterColor([NotNull] PoeFilterParser.ColorContext context);

        void ExitColor([NotNull] PoeFilterParser.ColorContext context);

        void EnterPoeClass([NotNull] PoeFilterParser.PoeClassContext context);

        void ExitPoeClass([NotNull] PoeFilterParser.PoeClassContext context);

        void EnterPoeBaseType([NotNull] PoeFilterParser.PoeBaseTypeContext context);

        void ExitPoeBaseType([NotNull] PoeFilterParser.PoeBaseTypeContext context);

        void EnterPoeFontSize([NotNull] PoeFilterParser.PoeFontSizeContext context);

        void ExitPoeFontSize([NotNull] PoeFilterParser.PoeFontSizeContext context);

        void EnterPoeTextColor([NotNull] PoeFilterParser.PoeTextColorContext context);

        void ExitPoeTextColor([NotNull] PoeFilterParser.PoeTextColorContext context);

        void EnterPoeBackgroundColor([NotNull] PoeFilterParser.PoeBackgroundColorContext context);

        void ExitPoeBackgroundColor([NotNull] PoeFilterParser.PoeBackgroundColorContext context);

        void EnterPoeBorderColor([NotNull] PoeFilterParser.PoeBorderColorContext context);

        void ExitPoeBorderColor([NotNull] PoeFilterParser.PoeBorderColorContext context);

        void EnterId([NotNull] PoeFilterParser.IdContext context);

        void ExitId([NotNull] PoeFilterParser.IdContext context);

        void EnterVolume([NotNull] PoeFilterParser.VolumeContext context);

        void ExitVolume([NotNull] PoeFilterParser.VolumeContext context);

        void EnterPoeAlertSound([NotNull] PoeFilterParser.PoeAlertSoundContext context);

        void ExitPoeAlertSound([NotNull] PoeFilterParser.PoeAlertSoundContext context);

        void EnterPoeRarity([NotNull] PoeFilterParser.PoeRarityContext context);

        void ExitPoeRarity([NotNull] PoeFilterParser.PoeRarityContext context);

        void EnterPoeSocketGroup([NotNull] PoeFilterParser.PoeSocketGroupContext context);

        void ExitPoeSocketGroup([NotNull] PoeFilterParser.PoeSocketGroupContext context);

        void EnterPoeLinkedSockets([NotNull] PoeFilterParser.PoeLinkedSocketsContext context);

        void ExitPoeLinkedSockets([NotNull] PoeFilterParser.PoeLinkedSocketsContext context);

        void EnterPoeSockets([NotNull] PoeFilterParser.PoeSocketsContext context);

        void ExitPoeSockets([NotNull] PoeFilterParser.PoeSocketsContext context);

        void EnterPoeItemLevel([NotNull] PoeFilterParser.PoeItemLevelContext context);

        void ExitPoeItemLevel([NotNull] PoeFilterParser.PoeItemLevelContext context);

        void EnterPoeDropLevel([NotNull] PoeFilterParser.PoeDropLevelContext context);

        void ExitPoeDropLevel([NotNull] PoeFilterParser.PoeDropLevelContext context);

        void EnterPoeQuality([NotNull] PoeFilterParser.PoeQualityContext context);

        void ExitPoeQuality([NotNull] PoeFilterParser.PoeQualityContext context);

        void EnterPoeWidth([NotNull] PoeFilterParser.PoeWidthContext context);

        void ExitPoeWidth([NotNull] PoeFilterParser.PoeWidthContext context);

        void EnterPoeHeight([NotNull] PoeFilterParser.PoeHeightContext context);

        void ExitPoeHeight([NotNull] PoeFilterParser.PoeHeightContext context);

        void EnterStatement([NotNull] PoeFilterParser.StatementContext context);

        void ExitStatement([NotNull] PoeFilterParser.StatementContext context);

        void EnterBlock([NotNull] PoeFilterParser.BlockContext context);

        void ExitBlock([NotNull] PoeFilterParser.BlockContext context);

        void EnterMain([NotNull] PoeFilterParser.MainContext context);

        void ExitMain([NotNull] PoeFilterParser.MainContext context);
    }
} // namespace PoeFilterParser