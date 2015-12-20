using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PoeFilterParser.Model
{
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
    [System.CLSCompliant(false)]
    public interface IPoeFilterVisitor<out Result> : IParseTreeVisitor<Result>
    {
        Result VisitStrValue([NotNull] PoeFilterParser.StrValueContext context);

        Result VisitSocketValue([NotNull] PoeFilterParser.SocketValueContext context);

        Result VisitRarityValue([NotNull] PoeFilterParser.RarityValueContext context);

        Result VisitCompareOpNullable([NotNull] PoeFilterParser.CompareOpNullableContext context);

        Result VisitVisibility([NotNull] PoeFilterParser.VisibilityContext context);

        Result VisitParams([NotNull] PoeFilterParser.ParamsContext context);

        Result VisitDigitsParams([NotNull] PoeFilterParser.DigitsParamsContext context);

        Result VisitRariryParams([NotNull] PoeFilterParser.RariryParamsContext context);

        Result VisitSocketParams([NotNull] PoeFilterParser.SocketParamsContext context);

        Result VisitRed([NotNull] PoeFilterParser.RedContext context);

        Result VisitGreen([NotNull] PoeFilterParser.GreenContext context);

        Result VisitBlue([NotNull] PoeFilterParser.BlueContext context);

        Result VisitAlpha([NotNull] PoeFilterParser.AlphaContext context);

        Result VisitColor([NotNull] PoeFilterParser.ColorContext context);

        Result VisitPoeClass([NotNull] PoeFilterParser.PoeClassContext context);

        Result VisitPoeBaseType([NotNull] PoeFilterParser.PoeBaseTypeContext context);

        Result VisitPoeFontSize([NotNull] PoeFilterParser.PoeFontSizeContext context);

        Result VisitPoeTextColor([NotNull] PoeFilterParser.PoeTextColorContext context);

        Result VisitPoeBackgroundColor([NotNull] PoeFilterParser.PoeBackgroundColorContext context);

        Result VisitPoeBorderColor([NotNull] PoeFilterParser.PoeBorderColorContext context);

        Result VisitId([NotNull] PoeFilterParser.IdContext context);

        Result VisitVolume([NotNull] PoeFilterParser.VolumeContext context);

        Result VisitPoeAlertSound([NotNull] PoeFilterParser.PoeAlertSoundContext context);

        Result VisitPoeRarity([NotNull] PoeFilterParser.PoeRarityContext context);

        Result VisitPoeSocketGroup([NotNull] PoeFilterParser.PoeSocketGroupContext context);

        Result VisitPoeLinkedSockets([NotNull] PoeFilterParser.PoeLinkedSocketsContext context);

        Result VisitPoeSockets([NotNull] PoeFilterParser.PoeSocketsContext context);

        Result VisitPoeItemLevel([NotNull] PoeFilterParser.PoeItemLevelContext context);

        Result VisitPoeDropLevel([NotNull] PoeFilterParser.PoeDropLevelContext context);

        Result VisitPoeQuality([NotNull] PoeFilterParser.PoeQualityContext context);

        Result VisitPoeWidth([NotNull] PoeFilterParser.PoeWidthContext context);

        Result VisitPoeHeight([NotNull] PoeFilterParser.PoeHeightContext context);

        Result VisitStatement([NotNull] PoeFilterParser.StatementContext context);

        Result VisitBlock([NotNull] PoeFilterParser.BlockContext context);

        Result VisitMain([NotNull] PoeFilterParser.MainContext context);
    }
}