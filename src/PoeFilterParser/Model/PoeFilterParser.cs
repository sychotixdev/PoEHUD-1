using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
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
    public class PoeFilterParser : Parser
    {
        public const int
            T__0 = 1, T__1 = 2, T__2 = 3, T__3 = 4, T__4 = 5, T__5 = 6, T__6 = 7, T__7 = 8, T__8 = 9,
            T__9 = 10, T__10 = 11, T__11 = 12, T__12 = 13, T__13 = 14, T__14 = 15, T__15 = 16, COMMENT = 17,
            WS = 18, DIGITS = 19, COMPAREOP = 20, RARITY = 21, SHOW = 22, HIDE = 23, SOCKET = 24,
            QUOTESOCKET = 25, QUOTERARITY = 26, STR = 27, QUOTESTR = 28;

        public const int
            RULE_strValue = 0, RULE_socketValue = 1, RULE_rarityValue = 2, RULE_compareOpNullable = 3,
            RULE_visibility = 4, RULE_params = 5, RULE_digitsParams = 6, RULE_rariryParams = 7,
            RULE_socketParams = 8, RULE_red = 9, RULE_green = 10, RULE_blue = 11,
            RULE_alpha = 12, RULE_color = 13, RULE_poeClass = 14, RULE_poeBaseType = 15,
            RULE_poeFontSize = 16, RULE_poeTextColor = 17, RULE_poeBackgroundColor = 18,
            RULE_poeBorderColor = 19, RULE_id = 20, RULE_volume = 21, RULE_poeAlertSound = 22,
            RULE_poeRarity = 23, RULE_poeSocketGroup = 24, RULE_poeLinkedSockets = 25,
            RULE_poeSockets = 26, RULE_poeItemLevel = 27, RULE_poeDropLevel = 28,
            RULE_poeQuality = 29, RULE_poeWidth = 30, RULE_poeHeight = 31, RULE_statement = 32,
            RULE_block = 33, RULE_main = 34;

        public static readonly string[] ruleNames = {
        "strValue", "socketValue", "rarityValue", "compareOpNullable", "visibility",
        "params", "digitsParams", "rariryParams", "socketParams", "red", "green",
        "blue", "alpha", "color", "poeClass", "poeBaseType", "poeFontSize", "poeTextColor",
        "poeBackgroundColor", "poeBorderColor", "id", "volume", "poeAlertSound",
        "poeRarity", "poeSocketGroup", "poeLinkedSockets", "poeSockets", "poeItemLevel",
        "poeDropLevel", "poeQuality", "poeWidth", "poeHeight", "statement", "block",
        "main"
    };

        private static readonly string[] _LiteralNames = {
        null, "'Class'", "'BaseType'", "'SetFontSize'", "'SetTextColor'", "'SetBackgroundColor'",
        "'SetBorderColor'", "'PlayAlertSound'", "'Rarity'", "'SocketGroup'", "'LinkedSockets'",
        "'Sockets'", "'ItemLevel'", "'DropLevel'", "'Quality'", "'Width'", "'Height'",
        null, null, null, null, null, "'Show'", "'Hide'"
    };

        private static readonly string[] _SymbolicNames = {
        null, null, null, null, null, null, null, null, null, null, null, null,
        null, null, null, null, null, "COMMENT", "WS", "DIGITS", "COMPAREOP",
        "RARITY", "SHOW", "HIDE", "SOCKET", "QUOTESOCKET", "QUOTERARITY", "STR",
        "QUOTESTR"
    };

        public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

        [System.Obsolete("Use Vocabulary instead.")]
        public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

        private static string[] GenerateTokenNames(IVocabulary vocabulary, int length)
        {
            string[] tokenNames = new string[length];
            for (int i = 0; i < tokenNames.Length; i++)
            {
                tokenNames[i] = vocabulary.GetLiteralName(i);
                if (tokenNames[i] == null)
                {
                    tokenNames[i] = vocabulary.GetSymbolicName(i);
                }

                if (tokenNames[i] == null)
                {
                    tokenNames[i] = "<INVALID>";
                }
            }

            return tokenNames;
        }

        [System.Obsolete]
        public override string[] TokenNames => tokenNames;

        [NotNull]
        public override IVocabulary Vocabulary => DefaultVocabulary;

        public override string GrammarFileName => "PoeFilter.g4";

        public override string[] RuleNames => ruleNames;

        public override string SerializedAtn => _serializedATN;

        public PoeFilterParser(ITokenStream input)
        : base(input)
        {
            _interp = new ParserATNSimulator(this, _ATN);
        }

        public class StrValueContext : ParserRuleContext
        {
            public ITerminalNode QUOTESTR()
            {
                return GetToken(PoeFilterParser.QUOTESTR, 0);
            }

            public ITerminalNode STR()
            {
                return GetToken(PoeFilterParser.STR, 0);
            }

            public StrValueContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_strValue;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterStrValue(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitStrValue(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitStrValue(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public StrValueContext strValue()
        {
            StrValueContext _localctx = new StrValueContext(_ctx, State);
            EnterRule(_localctx, 0, RULE_strValue);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 70;
                    var _la = _input.La(1);
                    if (!(_la == STR || _la == QUOTESTR))
                    {
                        _errHandler.RecoverInline(this);
                    }
                    else
                    {
                        Consume();
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class SocketValueContext : ParserRuleContext
        {
            public ITerminalNode QUOTESOCKET()
            {
                return GetToken(PoeFilterParser.QUOTESOCKET, 0);
            }

            public ITerminalNode SOCKET()
            {
                return GetToken(PoeFilterParser.SOCKET, 0);
            }

            public SocketValueContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_socketValue;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterSocketValue(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitSocketValue(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitSocketValue(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public SocketValueContext socketValue()
        {
            SocketValueContext _localctx = new SocketValueContext(_ctx, State);
            EnterRule(_localctx, 2, RULE_socketValue);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 72;
                    var _la = _input.La(1);
                    if (!(_la == SOCKET || _la == QUOTESOCKET))
                    {
                        _errHandler.RecoverInline(this);
                    }
                    else
                    {
                        Consume();
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class RarityValueContext : ParserRuleContext
        {
            public ITerminalNode QUOTERARITY()
            {
                return GetToken(PoeFilterParser.QUOTERARITY, 0);
            }

            public ITerminalNode RARITY()
            {
                return GetToken(PoeFilterParser.RARITY, 0);
            }

            public RarityValueContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_rarityValue;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterRarityValue(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitRarityValue(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitRarityValue(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public RarityValueContext rarityValue()
        {
            RarityValueContext _localctx = new RarityValueContext(_ctx, State);
            EnterRule(_localctx, 4, RULE_rarityValue);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 74;
                    var _la = _input.La(1);
                    if (!(_la == RARITY || _la == QUOTERARITY))
                    {
                        _errHandler.RecoverInline(this);
                    }
                    else
                    {
                        Consume();
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class CompareOpNullableContext : ParserRuleContext
        {
            public ITerminalNode COMPAREOP()
            {
                return GetToken(PoeFilterParser.COMPAREOP, 0);
            }

            public CompareOpNullableContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_compareOpNullable;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterCompareOpNullable(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitCompareOpNullable(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitCompareOpNullable(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public CompareOpNullableContext compareOpNullable()
        {
            CompareOpNullableContext _localctx = new CompareOpNullableContext(_ctx, State);
            EnterRule(_localctx, 6, RULE_compareOpNullable);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 77;
                    var _la = _input.La(1);
                    if (_la == COMPAREOP)
                    {
                        {
                            State = 76; Match(COMPAREOP);
                        }
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class VisibilityContext : ParserRuleContext
        {
            public ITerminalNode SHOW()
            {
                return GetToken(PoeFilterParser.SHOW, 0);
            }

            public ITerminalNode HIDE()
            {
                return GetToken(PoeFilterParser.HIDE, 0);
            }

            public VisibilityContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_visibility;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterVisibility(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitVisibility(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitVisibility(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public VisibilityContext visibility()
        {
            VisibilityContext _localctx = new VisibilityContext(_ctx, State);
            EnterRule(_localctx, 8, RULE_visibility);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 79;
                    var _la = _input.La(1);
                    if (!(_la == SHOW || _la == HIDE))
                    {
                        _errHandler.RecoverInline(this);
                    }
                    else
                    {
                        Consume();
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class ParamsContext : ParserRuleContext
        {
            public StrValueContext[] strValue()
            {
                return GetRuleContexts<StrValueContext>();
            }

            public StrValueContext strValue(int i)
            {
                return GetRuleContext<StrValueContext>(i);
            }

            public ParamsContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_params;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterParams(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitParams(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitParams(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public ParamsContext @params()
        {
            ParamsContext _localctx = new ParamsContext(_ctx, State);
            EnterRule(_localctx, 10, RULE_params);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 81; strValue();
                    State = 85;
                    _errHandler.Sync(this);
                    var _la = _input.La(1);
                    while (_la == STR || _la == QUOTESTR)
                    {
                        {
                            {
                                State = 82; strValue();
                            }
                        }
                        State = 87;
                        _errHandler.Sync(this);
                        _la = _input.La(1);
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class DigitsParamsContext : ParserRuleContext
        {
            public ITerminalNode[] DIGITS()
            {
                return GetTokens(PoeFilterParser.DIGITS);
            }

            public ITerminalNode DIGITS(int i)
            {
                return GetToken(PoeFilterParser.DIGITS, i);
            }

            public DigitsParamsContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_digitsParams;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterDigitsParams(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitDigitsParams(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitDigitsParams(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public DigitsParamsContext digitsParams()
        {
            DigitsParamsContext _localctx = new DigitsParamsContext(_ctx, State);
            EnterRule(_localctx, 12, RULE_digitsParams);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 88; Match(DIGITS);
                    State = 92;
                    _errHandler.Sync(this);
                    var _la = _input.La(1);
                    while (_la == DIGITS)
                    {
                        {
                            {
                                State = 89; Match(DIGITS);
                            }
                        }
                        State = 94;
                        _errHandler.Sync(this);
                        _la = _input.La(1);
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class RariryParamsContext : ParserRuleContext
        {
            public RarityValueContext[] rarityValue()
            {
                return GetRuleContexts<RarityValueContext>();
            }

            public RarityValueContext rarityValue(int i)
            {
                return GetRuleContext<RarityValueContext>(i);
            }

            public RariryParamsContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_rariryParams;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterRariryParams(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitRariryParams(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitRariryParams(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public RariryParamsContext rariryParams()
        {
            RariryParamsContext _localctx = new RariryParamsContext(_ctx, State);
            EnterRule(_localctx, 14, RULE_rariryParams);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 95; rarityValue();
                    State = 99;
                    _errHandler.Sync(this);
                    var _la = _input.La(1);
                    while (_la == RARITY || _la == QUOTERARITY)
                    {
                        {
                            {
                                State = 96; rarityValue();
                            }
                        }
                        State = 101;
                        _errHandler.Sync(this);
                        _la = _input.La(1);
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class SocketParamsContext : ParserRuleContext
        {
            public SocketValueContext[] socketValue()
            {
                return GetRuleContexts<SocketValueContext>();
            }

            public SocketValueContext socketValue(int i)
            {
                return GetRuleContext<SocketValueContext>(i);
            }

            public SocketParamsContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_socketParams;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterSocketParams(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitSocketParams(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitSocketParams(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public SocketParamsContext socketParams()
        {
            SocketParamsContext _localctx = new SocketParamsContext(_ctx, State);
            EnterRule(_localctx, 16, RULE_socketParams);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 102; socketValue();
                    State = 106;
                    _errHandler.Sync(this);
                    var _la = _input.La(1);
                    while (_la == SOCKET || _la == QUOTESOCKET)
                    {
                        {
                            {
                                State = 103; socketValue();
                            }
                        }
                        State = 108;
                        _errHandler.Sync(this);
                        _la = _input.La(1);
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class RedContext : ParserRuleContext
        {
            public ITerminalNode DIGITS()
            {
                return GetToken(PoeFilterParser.DIGITS, 0);
            }

            public RedContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_red;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterRed(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitRed(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitRed(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public RedContext red()
        {
            RedContext _localctx = new RedContext(_ctx, State);
            EnterRule(_localctx, 18, RULE_red);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 109; Match(DIGITS);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class GreenContext : ParserRuleContext
        {
            public ITerminalNode DIGITS()
            {
                return GetToken(PoeFilterParser.DIGITS, 0);
            }

            public GreenContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_green;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterGreen(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitGreen(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitGreen(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public GreenContext green()
        {
            GreenContext _localctx = new GreenContext(_ctx, State);
            EnterRule(_localctx, 20, RULE_green);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 111; Match(DIGITS);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class BlueContext : ParserRuleContext
        {
            public ITerminalNode DIGITS()
            {
                return GetToken(PoeFilterParser.DIGITS, 0);
            }

            public BlueContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_blue;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterBlue(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitBlue(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitBlue(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public BlueContext blue()
        {
            BlueContext _localctx = new BlueContext(_ctx, State);
            EnterRule(_localctx, 22, RULE_blue);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 113; Match(DIGITS);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class AlphaContext : ParserRuleContext
        {
            public ITerminalNode DIGITS()
            {
                return GetToken(PoeFilterParser.DIGITS, 0);
            }

            public AlphaContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_alpha;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterAlpha(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitAlpha(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitAlpha(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public AlphaContext alpha()
        {
            AlphaContext _localctx = new AlphaContext(_ctx, State);
            EnterRule(_localctx, 24, RULE_alpha);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 116;
                    var _la = _input.La(1);
                    if (_la == DIGITS)
                    {
                        {
                            State = 115; Match(DIGITS);
                        }
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class ColorContext : ParserRuleContext
        {
            public RedContext red()
            {
                return GetRuleContext<RedContext>(0);
            }

            public GreenContext green()
            {
                return GetRuleContext<GreenContext>(0);
            }

            public BlueContext blue()
            {
                return GetRuleContext<BlueContext>(0);
            }

            public AlphaContext alpha()
            {
                return GetRuleContext<AlphaContext>(0);
            }

            public ColorContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_color;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterColor(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitColor(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitColor(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public ColorContext color()
        {
            ColorContext _localctx = new ColorContext(_ctx, State);
            EnterRule(_localctx, 26, RULE_color);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 118; red();
                    State = 119; green();
                    State = 120; blue();
                    State = 121; alpha();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeClassContext : ParserRuleContext
        {
            public ParamsContext @params()
            {
                return GetRuleContext<ParamsContext>(0);
            }

            public PoeClassContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeClass;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeClass(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeClass(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeClass(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeClassContext poeClass()
        {
            PoeClassContext _localctx = new PoeClassContext(_ctx, State);
            EnterRule(_localctx, 28, RULE_poeClass);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 123; Match(T__0);
                    State = 124; @params();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeBaseTypeContext : ParserRuleContext
        {
            public ParamsContext @params()
            {
                return GetRuleContext<ParamsContext>(0);
            }

            public PoeBaseTypeContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeBaseType;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeBaseType(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeBaseType(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeBaseType(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeBaseTypeContext poeBaseType()
        {
            PoeBaseTypeContext _localctx = new PoeBaseTypeContext(_ctx, State);
            EnterRule(_localctx, 30, RULE_poeBaseType);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 126; Match(T__1);
                    State = 127; @params();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeFontSizeContext : ParserRuleContext
        {
            public ITerminalNode DIGITS()
            {
                return GetToken(PoeFilterParser.DIGITS, 0);
            }

            public PoeFontSizeContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeFontSize;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeFontSize(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeFontSize(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeFontSize(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeFontSizeContext poeFontSize()
        {
            PoeFontSizeContext _localctx = new PoeFontSizeContext(_ctx, State);
            EnterRule(_localctx, 32, RULE_poeFontSize);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 129; Match(T__2);
                    State = 130; Match(DIGITS);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeTextColorContext : ParserRuleContext
        {
            public ColorContext color()
            {
                return GetRuleContext<ColorContext>(0);
            }

            public PoeTextColorContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeTextColor;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeTextColor(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeTextColor(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeTextColor(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeTextColorContext poeTextColor()
        {
            PoeTextColorContext _localctx = new PoeTextColorContext(_ctx, State);
            EnterRule(_localctx, 34, RULE_poeTextColor);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 132; Match(T__3);
                    State = 133; color();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeBackgroundColorContext : ParserRuleContext
        {
            public ColorContext color()
            {
                return GetRuleContext<ColorContext>(0);
            }

            public PoeBackgroundColorContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeBackgroundColor;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeBackgroundColor(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeBackgroundColor(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeBackgroundColor(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeBackgroundColorContext poeBackgroundColor()
        {
            PoeBackgroundColorContext _localctx = new PoeBackgroundColorContext(_ctx, State);
            EnterRule(_localctx, 36, RULE_poeBackgroundColor);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 135; Match(T__4);
                    State = 136; color();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeBorderColorContext : ParserRuleContext
        {
            public ColorContext color()
            {
                return GetRuleContext<ColorContext>(0);
            }

            public PoeBorderColorContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeBorderColor;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeBorderColor(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeBorderColor(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeBorderColor(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeBorderColorContext poeBorderColor()
        {
            PoeBorderColorContext _localctx = new PoeBorderColorContext(_ctx, State);
            EnterRule(_localctx, 38, RULE_poeBorderColor);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 138; Match(T__5);
                    State = 139; color();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class IdContext : ParserRuleContext
        {
            public ITerminalNode DIGITS()
            {
                return GetToken(PoeFilterParser.DIGITS, 0);
            }

            public IdContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_id;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterId(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitId(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitId(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public IdContext id()
        {
            IdContext _localctx = new IdContext(_ctx, State);
            EnterRule(_localctx, 40, RULE_id);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 141; Match(DIGITS);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class VolumeContext : ParserRuleContext
        {
            public ITerminalNode DIGITS()
            {
                return GetToken(PoeFilterParser.DIGITS, 0);
            }

            public VolumeContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_volume;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterVolume(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitVolume(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitVolume(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public VolumeContext volume()
        {
            VolumeContext _localctx = new VolumeContext(_ctx, State);
            EnterRule(_localctx, 42, RULE_volume);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 144;
                    var _la = _input.La(1);
                    if (_la == DIGITS)
                    {
                        {
                            State = 143; Match(DIGITS);
                        }
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeAlertSoundContext : ParserRuleContext
        {
            public IdContext id()
            {
                return GetRuleContext<IdContext>(0);
            }

            public VolumeContext volume()
            {
                return GetRuleContext<VolumeContext>(0);
            }

            public PoeAlertSoundContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeAlertSound;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeAlertSound(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeAlertSound(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeAlertSound(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeAlertSoundContext poeAlertSound()
        {
            PoeAlertSoundContext _localctx = new PoeAlertSoundContext(_ctx, State);
            EnterRule(_localctx, 44, RULE_poeAlertSound);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 146; Match(T__6);
                    State = 147; id();
                    State = 148; volume();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeRarityContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public RariryParamsContext rariryParams()
            {
                return GetRuleContext<RariryParamsContext>(0);
            }

            public PoeRarityContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeRarity;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeRarity(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeRarity(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeRarity(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeRarityContext poeRarity()
        {
            PoeRarityContext _localctx = new PoeRarityContext(_ctx, State);
            EnterRule(_localctx, 46, RULE_poeRarity);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 150; Match(T__7);
                    State = 151; compareOpNullable();
                    State = 152; rariryParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeSocketGroupContext : ParserRuleContext
        {
            public SocketParamsContext socketParams()
            {
                return GetRuleContext<SocketParamsContext>(0);
            }

            public PoeSocketGroupContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeSocketGroup;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeSocketGroup(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeSocketGroup(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeSocketGroup(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeSocketGroupContext poeSocketGroup()
        {
            PoeSocketGroupContext _localctx = new PoeSocketGroupContext(_ctx, State);
            EnterRule(_localctx, 48, RULE_poeSocketGroup);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 154; Match(T__8);
                    State = 155; socketParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeLinkedSocketsContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public DigitsParamsContext digitsParams()
            {
                return GetRuleContext<DigitsParamsContext>(0);
            }

            public PoeLinkedSocketsContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeLinkedSockets;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeLinkedSockets(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeLinkedSockets(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeLinkedSockets(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeLinkedSocketsContext poeLinkedSockets()
        {
            PoeLinkedSocketsContext _localctx = new PoeLinkedSocketsContext(_ctx, State);
            EnterRule(_localctx, 50, RULE_poeLinkedSockets);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 157; Match(T__9);
                    State = 158; compareOpNullable();
                    State = 159; digitsParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeSocketsContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public DigitsParamsContext digitsParams()
            {
                return GetRuleContext<DigitsParamsContext>(0);
            }

            public PoeSocketsContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeSockets;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeSockets(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeSockets(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeSockets(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeSocketsContext poeSockets()
        {
            PoeSocketsContext _localctx = new PoeSocketsContext(_ctx, State);
            EnterRule(_localctx, 52, RULE_poeSockets);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 161; Match(T__10);
                    State = 162; compareOpNullable();
                    State = 163; digitsParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeItemLevelContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public DigitsParamsContext digitsParams()
            {
                return GetRuleContext<DigitsParamsContext>(0);
            }

            public PoeItemLevelContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeItemLevel;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeItemLevel(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeItemLevel(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeItemLevel(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeItemLevelContext poeItemLevel()
        {
            PoeItemLevelContext _localctx = new PoeItemLevelContext(_ctx, State);
            EnterRule(_localctx, 54, RULE_poeItemLevel);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 165; Match(T__11);
                    State = 166; compareOpNullable();
                    State = 167; digitsParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeDropLevelContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public DigitsParamsContext digitsParams()
            {
                return GetRuleContext<DigitsParamsContext>(0);
            }

            public PoeDropLevelContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeDropLevel;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeDropLevel(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeDropLevel(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeDropLevel(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeDropLevelContext poeDropLevel()
        {
            PoeDropLevelContext _localctx = new PoeDropLevelContext(_ctx, State);
            EnterRule(_localctx, 56, RULE_poeDropLevel);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 169; Match(T__12);
                    State = 170; compareOpNullable();
                    State = 171; digitsParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeQualityContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public DigitsParamsContext digitsParams()
            {
                return GetRuleContext<DigitsParamsContext>(0);
            }

            public PoeQualityContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeQuality;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeQuality(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeQuality(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeQuality(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeQualityContext poeQuality()
        {
            PoeQualityContext _localctx = new PoeQualityContext(_ctx, State);
            EnterRule(_localctx, 58, RULE_poeQuality);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 173; Match(T__13);
                    State = 174; compareOpNullable();
                    State = 175; digitsParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeWidthContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public DigitsParamsContext digitsParams()
            {
                return GetRuleContext<DigitsParamsContext>(0);
            }

            public PoeWidthContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeWidth;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeWidth(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeWidth(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeWidth(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeWidthContext poeWidth()
        {
            PoeWidthContext _localctx = new PoeWidthContext(_ctx, State);
            EnterRule(_localctx, 60, RULE_poeWidth);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 177; Match(T__14);
                    State = 178; compareOpNullable();
                    State = 179; digitsParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class PoeHeightContext : ParserRuleContext
        {
            public CompareOpNullableContext compareOpNullable()
            {
                return GetRuleContext<CompareOpNullableContext>(0);
            }

            public DigitsParamsContext digitsParams()
            {
                return GetRuleContext<DigitsParamsContext>(0);
            }

            public PoeHeightContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_poeHeight;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterPoeHeight(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitPoeHeight(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitPoeHeight(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public PoeHeightContext poeHeight()
        {
            PoeHeightContext _localctx = new PoeHeightContext(_ctx, State);
            EnterRule(_localctx, 62, RULE_poeHeight);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 181; Match(T__15);
                    State = 182; compareOpNullable();
                    State = 183; digitsParams();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class StatementContext : ParserRuleContext
        {
            public PoeClassContext poeClass()
            {
                return GetRuleContext<PoeClassContext>(0);
            }

            public PoeFontSizeContext poeFontSize()
            {
                return GetRuleContext<PoeFontSizeContext>(0);
            }

            public PoeBackgroundColorContext poeBackgroundColor()
            {
                return GetRuleContext<PoeBackgroundColorContext>(0);
            }

            public PoeBorderColorContext poeBorderColor()
            {
                return GetRuleContext<PoeBorderColorContext>(0);
            }

            public PoeAlertSoundContext poeAlertSound()
            {
                return GetRuleContext<PoeAlertSoundContext>(0);
            }

            public PoeSocketGroupContext poeSocketGroup()
            {
                return GetRuleContext<PoeSocketGroupContext>(0);
            }

            public PoeRarityContext poeRarity()
            {
                return GetRuleContext<PoeRarityContext>(0);
            }

            public PoeSocketsContext poeSockets()
            {
                return GetRuleContext<PoeSocketsContext>(0);
            }

            public PoeItemLevelContext poeItemLevel()
            {
                return GetRuleContext<PoeItemLevelContext>(0);
            }

            public PoeDropLevelContext poeDropLevel()
            {
                return GetRuleContext<PoeDropLevelContext>(0);
            }

            public PoeLinkedSocketsContext poeLinkedSockets()
            {
                return GetRuleContext<PoeLinkedSocketsContext>(0);
            }

            public PoeQualityContext poeQuality()
            {
                return GetRuleContext<PoeQualityContext>(0);
            }

            public PoeBaseTypeContext poeBaseType()
            {
                return GetRuleContext<PoeBaseTypeContext>(0);
            }

            public PoeWidthContext poeWidth()
            {
                return GetRuleContext<PoeWidthContext>(0);
            }

            public PoeHeightContext poeHeight()
            {
                return GetRuleContext<PoeHeightContext>(0);
            }

            public PoeTextColorContext poeTextColor()
            {
                return GetRuleContext<PoeTextColorContext>(0);
            }

            public StatementContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_statement;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterStatement(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitStatement(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitStatement(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public StatementContext statement()
        {
            StatementContext _localctx = new StatementContext(_ctx, State);
            EnterRule(_localctx, 64, RULE_statement);
            try
            {
                State = 201;
                switch (_input.La(1))
                {
                    case T__0:
                        EnterOuterAlt(_localctx, 1);
                        {
                            State = 185; poeClass();
                        }
                        break;

                    case T__2:
                        EnterOuterAlt(_localctx, 2);
                        {
                            State = 186; poeFontSize();
                        }
                        break;

                    case T__4:
                        EnterOuterAlt(_localctx, 3);
                        {
                            State = 187; poeBackgroundColor();
                        }
                        break;

                    case T__5:
                        EnterOuterAlt(_localctx, 4);
                        {
                            State = 188; poeBorderColor();
                        }
                        break;

                    case T__6:
                        EnterOuterAlt(_localctx, 5);
                        {
                            State = 189; poeAlertSound();
                        }
                        break;

                    case T__8:
                        EnterOuterAlt(_localctx, 6);
                        {
                            State = 190; poeSocketGroup();
                        }
                        break;

                    case T__7:
                        EnterOuterAlt(_localctx, 7);
                        {
                            State = 191; poeRarity();
                        }
                        break;

                    case T__10:
                        EnterOuterAlt(_localctx, 8);
                        {
                            State = 192; poeSockets();
                        }
                        break;

                    case T__11:
                        EnterOuterAlt(_localctx, 9);
                        {
                            State = 193; poeItemLevel();
                        }
                        break;

                    case T__12:
                        EnterOuterAlt(_localctx, 10);
                        {
                            State = 194; poeDropLevel();
                        }
                        break;

                    case T__9:
                        EnterOuterAlt(_localctx, 11);
                        {
                            State = 195; poeLinkedSockets();
                        }
                        break;

                    case T__13:
                        EnterOuterAlt(_localctx, 12);
                        {
                            State = 196; poeQuality();
                        }
                        break;

                    case T__1:
                        EnterOuterAlt(_localctx, 13);
                        {
                            State = 197; poeBaseType();
                        }
                        break;

                    case T__14:
                        EnterOuterAlt(_localctx, 14);
                        {
                            State = 198; poeWidth();
                        }
                        break;

                    case T__15:
                        EnterOuterAlt(_localctx, 15);
                        {
                            State = 199; poeHeight();
                        }
                        break;

                    case T__3:
                        EnterOuterAlt(_localctx, 16);
                        {
                            State = 200; poeTextColor();
                        }
                        break;

                    default:
                        throw new NoViableAltException(this);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class BlockContext : ParserRuleContext
        {
            public VisibilityContext visibility()
            {
                return GetRuleContext<VisibilityContext>(0);
            }

            public StatementContext[] statement()
            {
                return GetRuleContexts<StatementContext>();
            }

            public StatementContext statement(int i)
            {
                return GetRuleContext<StatementContext>(i);
            }

            public BlockContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_block;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterBlock(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitBlock(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitBlock(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public BlockContext block()
        {
            BlockContext _localctx = new BlockContext(_ctx, State);
            EnterRule(_localctx, 66, RULE_block);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 203; visibility();
                    State = 207;
                    _errHandler.Sync(this);
                    var _alt = Interpreter.AdaptivePredict(_input, 8, _ctx);
                    while (_alt != 1 && _alt != Antlr4.Runtime.Atn.ATN.InvalidAltNumber)
                    {
                        if (_alt == 1 + 1)
                        {
                            {
                                {
                                    State = 204; statement();
                                }
                            }
                        }
                        State = 209;
                        _errHandler.Sync(this);
                        _alt = Interpreter.AdaptivePredict(_input, 8, _ctx);
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public class MainContext : ParserRuleContext
        {
            public BlockContext[] block()
            {
                return GetRuleContexts<BlockContext>();
            }

            public BlockContext block(int i)
            {
                return GetRuleContext<BlockContext>(i);
            }

            public MainContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex => RULE_main;

            public override void EnterRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.EnterMain(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                IPoeFilterListener typedListener = listener as IPoeFilterListener;
                typedListener?.ExitMain(this);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                IPoeFilterVisitor<TResult> typedVisitor = visitor as IPoeFilterVisitor<TResult>;
                return typedVisitor != null ? typedVisitor.VisitMain(this) : visitor.VisitChildren(this);
            }
        }

        [RuleVersion(0)]
        public MainContext main()
        {
            MainContext _localctx = new MainContext(_ctx, State);
            EnterRule(_localctx, 68, RULE_main);
            try
            {
                EnterOuterAlt(_localctx, 1);
                {
                    State = 211;
                    _errHandler.Sync(this);
                    var _la = _input.La(1);
                    do
                    {
                        {
                            {
                                State = 210; block();
                            }
                        }
                        State = 213;
                        _errHandler.Sync(this);
                        _la = _input.La(1);
                    } while (_la == SHOW || _la == HIDE);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                _errHandler.ReportError(this, re);
                _errHandler.Recover(this, re);
            }
            finally
            {
                ExitRule();
            }
            return _localctx;
        }

        public static readonly string _serializedATN =
            "\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x1E\xDA\x4\x2\t" +
            "\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t" +
            "\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10" +
            "\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15" +
            "\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B" +
            "\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!" +
            "\t!\x4\"\t\"\x4#\t#\x4$\t$\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x5" +
            "\x5P\n\x5\x3\x6\x3\x6\x3\a\x3\a\a\aV\n\a\f\a\xE\aY\v\a\x3\b\x3\b\a\b]" +
            "\n\b\f\b\xE\b`\v\b\x3\t\x3\t\a\t\x64\n\t\f\t\xE\tg\v\t\x3\n\x3\n\a\nk" +
            "\n\n\f\n\xE\nn\v\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x5\xEw\n\xE\x3" +
            "\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11" +
            "\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x15" +
            "\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x5\x17\x93\n\x17\x3\x18\x3\x18\x3" +
            "\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3" +
            "\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3" +
            "\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3" +
            " \x3 \x3!\x3!\x3!\x3!\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3" +
            "\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x5\"\xCC\n\"\x3#\x3#\a#\xD0\n#\f#\xE" +
            "#\xD3\v#\x3$\x6$\xD6\n$\r$\xE$\xD7\x3$\x3\xD1\x2\x2%\x2\x2\x4\x2\x6\x2" +
            "\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x16\x2\x18\x2\x1A\x2\x1C\x2" +
            "\x1E\x2 \x2\"\x2$\x2&\x2(\x2*\x2,\x2.\x2\x30\x2\x32\x2\x34\x2\x36\x2\x38" +
            "\x2:\x2<\x2>\x2@\x2\x42\x2\x44\x2\x46\x2\x2\x6\x3\x2\x1D\x1E\x3\x2\x1A" +
            "\x1B\x4\x2\x17\x17\x1C\x1C\x3\x2\x18\x19\xCE\x2H\x3\x2\x2\x2\x4J\x3\x2" +
            "\x2\x2\x6L\x3\x2\x2\x2\bO\x3\x2\x2\x2\nQ\x3\x2\x2\x2\fS\x3\x2\x2\x2\xE" +
            "Z\x3\x2\x2\x2\x10\x61\x3\x2\x2\x2\x12h\x3\x2\x2\x2\x14o\x3\x2\x2\x2\x16" +
            "q\x3\x2\x2\x2\x18s\x3\x2\x2\x2\x1Av\x3\x2\x2\x2\x1Cx\x3\x2\x2\x2\x1E}" +
            "\x3\x2\x2\x2 \x80\x3\x2\x2\x2\"\x83\x3\x2\x2\x2$\x86\x3\x2\x2\x2&\x89" +
            "\x3\x2\x2\x2(\x8C\x3\x2\x2\x2*\x8F\x3\x2\x2\x2,\x92\x3\x2\x2\x2.\x94\x3" +
            "\x2\x2\x2\x30\x98\x3\x2\x2\x2\x32\x9C\x3\x2\x2\x2\x34\x9F\x3\x2\x2\x2" +
            "\x36\xA3\x3\x2\x2\x2\x38\xA7\x3\x2\x2\x2:\xAB\x3\x2\x2\x2<\xAF\x3\x2\x2" +
            "\x2>\xB3\x3\x2\x2\x2@\xB7\x3\x2\x2\x2\x42\xCB\x3\x2\x2\x2\x44\xCD\x3\x2" +
            "\x2\x2\x46\xD5\x3\x2\x2\x2HI\t\x2\x2\x2I\x3\x3\x2\x2\x2JK\t\x3\x2\x2K" +
            "\x5\x3\x2\x2\x2LM\t\x4\x2\x2M\a\x3\x2\x2\x2NP\a\x16\x2\x2ON\x3\x2\x2\x2" +
            "OP\x3\x2\x2\x2P\t\x3\x2\x2\x2QR\t\x5\x2\x2R\v\x3\x2\x2\x2SW\x5\x2\x2\x2" +
            "TV\x5\x2\x2\x2UT\x3\x2\x2\x2VY\x3\x2\x2\x2WU\x3\x2\x2\x2WX\x3\x2\x2\x2" +
            "X\r\x3\x2\x2\x2YW\x3\x2\x2\x2Z^\a\x15\x2\x2[]\a\x15\x2\x2\\[\x3\x2\x2" +
            "\x2]`\x3\x2\x2\x2^\\\x3\x2\x2\x2^_\x3\x2\x2\x2_\xF\x3\x2\x2\x2`^\x3\x2" +
            "\x2\x2\x61\x65\x5\x6\x4\x2\x62\x64\x5\x6\x4\x2\x63\x62\x3\x2\x2\x2\x64" +
            "g\x3\x2\x2\x2\x65\x63\x3\x2\x2\x2\x65\x66\x3\x2\x2\x2\x66\x11\x3\x2\x2" +
            "\x2g\x65\x3\x2\x2\x2hl\x5\x4\x3\x2ik\x5\x4\x3\x2ji\x3\x2\x2\x2kn\x3\x2" +
            "\x2\x2lj\x3\x2\x2\x2lm\x3\x2\x2\x2m\x13\x3\x2\x2\x2nl\x3\x2\x2\x2op\a" +
            "\x15\x2\x2p\x15\x3\x2\x2\x2qr\a\x15\x2\x2r\x17\x3\x2\x2\x2st\a\x15\x2" +
            "\x2t\x19\x3\x2\x2\x2uw\a\x15\x2\x2vu\x3\x2\x2\x2vw\x3\x2\x2\x2w\x1B\x3" +
            "\x2\x2\x2xy\x5\x14\v\x2yz\x5\x16\f\x2z{\x5\x18\r\x2{|\x5\x1A\xE\x2|\x1D" +
            "\x3\x2\x2\x2}~\a\x3\x2\x2~\x7F\x5\f\a\x2\x7F\x1F\x3\x2\x2\x2\x80\x81\a" +
            "\x4\x2\x2\x81\x82\x5\f\a\x2\x82!\x3\x2\x2\x2\x83\x84\a\x5\x2\x2\x84\x85" +
            "\a\x15\x2\x2\x85#\x3\x2\x2\x2\x86\x87\a\x6\x2\x2\x87\x88\x5\x1C\xF\x2" +
            "\x88%\x3\x2\x2\x2\x89\x8A\a\a\x2\x2\x8A\x8B\x5\x1C\xF\x2\x8B\'\x3\x2\x2" +
            "\x2\x8C\x8D\a\b\x2\x2\x8D\x8E\x5\x1C\xF\x2\x8E)\x3\x2\x2\x2\x8F\x90\a" +
            "\x15\x2\x2\x90+\x3\x2\x2\x2\x91\x93\a\x15\x2\x2\x92\x91\x3\x2\x2\x2\x92" +
            "\x93\x3\x2\x2\x2\x93-\x3\x2\x2\x2\x94\x95\a\t\x2\x2\x95\x96\x5*\x16\x2" +
            "\x96\x97\x5,\x17\x2\x97/\x3\x2\x2\x2\x98\x99\a\n\x2\x2\x99\x9A\x5\b\x5" +
            "\x2\x9A\x9B\x5\x10\t\x2\x9B\x31\x3\x2\x2\x2\x9C\x9D\a\v\x2\x2\x9D\x9E" +
            "\x5\x12\n\x2\x9E\x33\x3\x2\x2\x2\x9F\xA0\a\f\x2\x2\xA0\xA1\x5\b\x5\x2" +
            "\xA1\xA2\x5\xE\b\x2\xA2\x35\x3\x2\x2\x2\xA3\xA4\a\r\x2\x2\xA4\xA5\x5\b" +
            "\x5\x2\xA5\xA6\x5\xE\b\x2\xA6\x37\x3\x2\x2\x2\xA7\xA8\a\xE\x2\x2\xA8\xA9" +
            "\x5\b\x5\x2\xA9\xAA\x5\xE\b\x2\xAA\x39\x3\x2\x2\x2\xAB\xAC\a\xF\x2\x2" +
            "\xAC\xAD\x5\b\x5\x2\xAD\xAE\x5\xE\b\x2\xAE;\x3\x2\x2\x2\xAF\xB0\a\x10" +
            "\x2\x2\xB0\xB1\x5\b\x5\x2\xB1\xB2\x5\xE\b\x2\xB2=\x3\x2\x2\x2\xB3\xB4" +
            "\a\x11\x2\x2\xB4\xB5\x5\b\x5\x2\xB5\xB6\x5\xE\b\x2\xB6?\x3\x2\x2\x2\xB7" +
            "\xB8\a\x12\x2\x2\xB8\xB9\x5\b\x5\x2\xB9\xBA\x5\xE\b\x2\xBA\x41\x3\x2\x2" +
            "\x2\xBB\xCC\x5\x1E\x10\x2\xBC\xCC\x5\"\x12\x2\xBD\xCC\x5&\x14\x2\xBE\xCC" +
            "\x5(\x15\x2\xBF\xCC\x5.\x18\x2\xC0\xCC\x5\x32\x1A\x2\xC1\xCC\x5\x30\x19" +
            "\x2\xC2\xCC\x5\x36\x1C\x2\xC3\xCC\x5\x38\x1D\x2\xC4\xCC\x5:\x1E\x2\xC5" +
            "\xCC\x5\x34\x1B\x2\xC6\xCC\x5<\x1F\x2\xC7\xCC\x5 \x11\x2\xC8\xCC\x5> " +
            "\x2\xC9\xCC\x5@!\x2\xCA\xCC\x5$\x13\x2\xCB\xBB\x3\x2\x2\x2\xCB\xBC\x3" +
            "\x2\x2\x2\xCB\xBD\x3\x2\x2\x2\xCB\xBE\x3\x2\x2\x2\xCB\xBF\x3\x2\x2\x2" +
            "\xCB\xC0\x3\x2\x2\x2\xCB\xC1\x3\x2\x2\x2\xCB\xC2\x3\x2\x2\x2\xCB\xC3\x3" +
            "\x2\x2\x2\xCB\xC4\x3\x2\x2\x2\xCB\xC5\x3\x2\x2\x2\xCB\xC6\x3\x2\x2\x2" +
            "\xCB\xC7\x3\x2\x2\x2\xCB\xC8\x3\x2\x2\x2\xCB\xC9\x3\x2\x2\x2\xCB\xCA\x3" +
            "\x2\x2\x2\xCC\x43\x3\x2\x2\x2\xCD\xD1\x5\n\x6\x2\xCE\xD0\x5\x42\"\x2\xCF" +
            "\xCE\x3\x2\x2\x2\xD0\xD3\x3\x2\x2\x2\xD1\xD2\x3\x2\x2\x2\xD1\xCF\x3\x2" +
            "\x2\x2\xD2\x45\x3\x2\x2\x2\xD3\xD1\x3\x2\x2\x2\xD4\xD6\x5\x44#\x2\xD5" +
            "\xD4\x3\x2\x2\x2\xD6\xD7\x3\x2\x2\x2\xD7\xD5\x3\x2\x2\x2\xD7\xD8\x3\x2" +
            "\x2\x2\xD8G\x3\x2\x2\x2\fOW^\x65lv\x92\xCB\xD1\xD7";

        public static readonly ATN _ATN =
            new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
    }
} // namespace PoeFilterParser