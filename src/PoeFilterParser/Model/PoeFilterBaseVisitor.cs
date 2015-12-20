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
    public class PoeFilterBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IPoeFilterVisitor<Result>
    {
        public virtual Result VisitStrValue([NotNull] PoeFilterParser.StrValueContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitSocketValue([NotNull] PoeFilterParser.SocketValueContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitRarityValue([NotNull] PoeFilterParser.RarityValueContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitCompareOpNullable([NotNull] PoeFilterParser.CompareOpNullableContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitVisibility([NotNull] PoeFilterParser.VisibilityContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitParams([NotNull] PoeFilterParser.ParamsContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitDigitsParams([NotNull] PoeFilterParser.DigitsParamsContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitRariryParams([NotNull] PoeFilterParser.RariryParamsContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitSocketParams([NotNull] PoeFilterParser.SocketParamsContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitRed([NotNull] PoeFilterParser.RedContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitGreen([NotNull] PoeFilterParser.GreenContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitBlue([NotNull] PoeFilterParser.BlueContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitAlpha([NotNull] PoeFilterParser.AlphaContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitColor([NotNull] PoeFilterParser.ColorContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeClass([NotNull] PoeFilterParser.PoeClassContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeBaseType([NotNull] PoeFilterParser.PoeBaseTypeContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeFontSize([NotNull] PoeFilterParser.PoeFontSizeContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeTextColor([NotNull] PoeFilterParser.PoeTextColorContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeBackgroundColor([NotNull] PoeFilterParser.PoeBackgroundColorContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeBorderColor([NotNull] PoeFilterParser.PoeBorderColorContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitId([NotNull] PoeFilterParser.IdContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitVolume([NotNull] PoeFilterParser.VolumeContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeAlertSound([NotNull] PoeFilterParser.PoeAlertSoundContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeRarity([NotNull] PoeFilterParser.PoeRarityContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeSocketGroup([NotNull] PoeFilterParser.PoeSocketGroupContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeLinkedSockets([NotNull] PoeFilterParser.PoeLinkedSocketsContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeSockets([NotNull] PoeFilterParser.PoeSocketsContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeItemLevel([NotNull] PoeFilterParser.PoeItemLevelContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeDropLevel([NotNull] PoeFilterParser.PoeDropLevelContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeQuality([NotNull] PoeFilterParser.PoeQualityContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeWidth([NotNull] PoeFilterParser.PoeWidthContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitPoeHeight([NotNull] PoeFilterParser.PoeHeightContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitStatement([NotNull] PoeFilterParser.StatementContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitBlock([NotNull] PoeFilterParser.BlockContext context)
        {
            return VisitChildren(context);
        }

        public virtual Result VisitMain([NotNull] PoeFilterParser.MainContext context)
        {
            return VisitChildren(context);
        }
    }
}