//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\usuario\Desktop\Nueva carpeta\MiniCSharp-Parte1\AnalizadorSintactico\Lexer1.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AnalizadorSintactico {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class Lexer1 : Lexer {
	public const int
		WS=1, NEWLINE=2, COMMMETBLOCK=3, COMMMET=4, IN=5, VOID=6, CONDICION_IF=7, 
		CONDICION_ELSE_IF=8, CONDICION_ELSE=9, CICLO_WHILE=10, CICLO_FOR=11, CICLO_FOREACH=12, 
		BREAK=13, RETURN=14, READ=15, WRITE=16, CLASE=17, NEW=18, CONSTANTE=19, 
		TRUE=20, FALSE=21, PyCOMA=22, COMA=23, ASIGN=24, PIZQ=25, PDER=26, SUMA=27, 
		MUL=28, DIV=29, RESTA=30, DIVMOD=31, COMPARACION=32, DIFERENTE=33, MENOR=34, 
		MENORIGUAL=35, MAYOR=36, MAYORIGUAL=37, O=38, Y=39, INCRE=40, DECRE=41, 
		PUNTO=42, PCUADRADO_IZQ=43, PCUADRADO_DER=44, COR_DER=45, COR_IZQ=46, 
		EXCLAMACION=47, EXCLAMACIONA=48, NUMERAL=49, DOLAR=50, AMPERSON=51, INTERROGACION=52, 
		ARROBA=53, GUIONBAJO=54, COMILLADOBLE=55, VERTICAL=56, COMENTCHAR=57, 
		COMENTBLOCKCHAR1=58, COMENTBLOCKCHAR2=59, DOSPUNTOS=60, ENE=61, BACKQUOTE=62, 
		TECHO=63, STRI=64, NUMBER=65, FLOAT=66, ID=67, CARACTERESCOMENTBLOCK=68, 
		CARACTERES=69, CharConst=70;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"WS", "NEWLINE", "COMMMETBLOCK", "COMMMET", "IN", "VOID", "CONDICION_IF", 
		"CONDICION_ELSE_IF", "CONDICION_ELSE", "CICLO_WHILE", "CICLO_FOR", "CICLO_FOREACH", 
		"BREAK", "RETURN", "READ", "WRITE", "CLASE", "NEW", "CONSTANTE", "TRUE", 
		"FALSE", "PyCOMA", "COMA", "ASIGN", "PIZQ", "PDER", "SUMA", "MUL", "DIV", 
		"RESTA", "DIVMOD", "COMPARACION", "DIFERENTE", "MENOR", "MENORIGUAL", 
		"MAYOR", "MAYORIGUAL", "O", "Y", "INCRE", "DECRE", "PUNTO", "PCUADRADO_IZQ", 
		"PCUADRADO_DER", "COR_DER", "COR_IZQ", "EXCLAMACION", "EXCLAMACIONA", 
		"NUMERAL", "DOLAR", "AMPERSON", "INTERROGACION", "ARROBA", "GUIONBAJO", 
		"COMILLADOBLE", "VERTICAL", "COMENTCHAR", "COMENTBLOCKCHAR1", "COMENTBLOCKCHAR2", 
		"DOSPUNTOS", "ENE", "BACKQUOTE", "TECHO", "STRI", "NUMBER", "FLOAT", "ID", 
		"CARACTERESCOMENTBLOCK", "CARACTERES", "CharConst", "LETTER", "DIGIT", 
		"PrintableChar"
	};


	public Lexer1(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, "'in'", "'void'", "'if'", "'else if'", "'else'", 
		"'while'", "'for'", "'foreach'", "'break'", "'return'", "'read'", "'write'", 
		"'class'", "'new'", "'const'", "'true'", "'false'", "';'", "','", "'='", 
		"'('", "')'", "'+'", "'*'", "'/'", "'-'", "'%'", "'=='", "'!='", "'<'", 
		"'<='", "'>'", "'>='", "'||'", "'&&'", "'++'", "'--'", "'.'", "'['", "']'", 
		"'{'", "'}'", "'!'", "'�'", "'#'", "'$'", "'&'", "'?'", "'@'", "'_'", 
		"'\"'", "'|'", "'//'", "'/*'", "'*/'", "':'", "'~'", "'`'", "'^'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WS", "NEWLINE", "COMMMETBLOCK", "COMMMET", "IN", "VOID", "CONDICION_IF", 
		"CONDICION_ELSE_IF", "CONDICION_ELSE", "CICLO_WHILE", "CICLO_FOR", "CICLO_FOREACH", 
		"BREAK", "RETURN", "READ", "WRITE", "CLASE", "NEW", "CONSTANTE", "TRUE", 
		"FALSE", "PyCOMA", "COMA", "ASIGN", "PIZQ", "PDER", "SUMA", "MUL", "DIV", 
		"RESTA", "DIVMOD", "COMPARACION", "DIFERENTE", "MENOR", "MENORIGUAL", 
		"MAYOR", "MAYORIGUAL", "O", "Y", "INCRE", "DECRE", "PUNTO", "PCUADRADO_IZQ", 
		"PCUADRADO_DER", "COR_DER", "COR_IZQ", "EXCLAMACION", "EXCLAMACIONA", 
		"NUMERAL", "DOLAR", "AMPERSON", "INTERROGACION", "ARROBA", "GUIONBAJO", 
		"COMILLADOBLE", "VERTICAL", "COMENTCHAR", "COMENTBLOCKCHAR1", "COMENTBLOCKCHAR2", 
		"DOSPUNTOS", "ENE", "BACKQUOTE", "TECHO", "STRI", "NUMBER", "FLOAT", "ID", 
		"CARACTERESCOMENTBLOCK", "CARACTERES", "CharConst"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Lexer1.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2H\x1E4\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4?\t?\x4"+
		"@\t@\x4\x41\t\x41\x4\x42\t\x42\x4\x43\t\x43\x4\x44\t\x44\x4\x45\t\x45"+
		"\x4\x46\t\x46\x4G\tG\x4H\tH\x4I\tI\x4J\tJ\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\a\x4\xA4\n\x4\f"+
		"\x4\xE\x4\xA7\v\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\a\x5\xB5\n\x5\f\x5\xE\x5\xB8\v\x5\x3\x5\x3\x5\x3"+
		"\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r"+
		"\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3"+
		"\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11"+
		"\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13"+
		"\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17"+
		"\x3\x17\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1C"+
		"\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3!"+
		"\x3\"\x3\"\x3\"\x3#\x3#\x3$\x3$\x3$\x3%\x3%\x3&\x3&\x3&\x3\'\x3\'\x3\'"+
		"\x3(\x3(\x3(\x3)\x3)\x3)\x3*\x3*\x3*\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x3.\x3"+
		"/\x3/\x3\x30\x3\x30\x3\x31\x3\x31\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3"+
		"\x34\x3\x35\x3\x35\x3\x36\x3\x36\x3\x37\x3\x37\x3\x38\x3\x38\x3\x39\x3"+
		"\x39\x3:\x3:\x3:\x3;\x3;\x3;\x3<\x3<\x3<\x3=\x3=\x3>\x3>\x3?\x3?\x3@\x3"+
		"@\x3\x41\x3\x41\x3\x41\x3\x41\x3\x41\a\x41\x17D\n\x41\f\x41\xE\x41\x180"+
		"\v\x41\x3\x41\x3\x41\x3\x42\x3\x42\a\x42\x186\n\x42\f\x42\xE\x42\x189"+
		"\v\x42\x3\x42\x5\x42\x18C\n\x42\x3\x43\x3\x43\a\x43\x190\n\x43\f\x43\xE"+
		"\x43\x193\v\x43\x3\x43\x5\x43\x196\n\x43\x3\x43\x3\x43\x3\x43\a\x43\x19B"+
		"\n\x43\f\x43\xE\x43\x19E\v\x43\x3\x44\x3\x44\x3\x44\x3\x44\a\x44\x1A4"+
		"\n\x44\f\x44\xE\x44\x1A7\v\x44\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45"+
		"\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45"+
		"\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45"+
		"\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45\x3\x45"+
		"\x3\x45\x5\x45\x1CE\n\x45\x3\x46\x3\x46\x3\x46\x5\x46\x1D3\n\x46\x3G\x3"+
		"G\x3G\x5G\x1D8\nG\x3G\x3G\x3H\x3H\x3I\x3I\x3J\x3J\x3J\x5J\x1E3\nJ\x2\x2"+
		"\x2K\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n"+
		"\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11"+
		"!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31"+
		"\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!"+
		"\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2"+
		"-Y\x2.[\x2/]\x2\x30_\x2\x31\x61\x2\x32\x63\x2\x33\x65\x2\x34g\x2\x35i"+
		"\x2\x36k\x2\x37m\x2\x38o\x2\x39q\x2:s\x2;u\x2<w\x2=y\x2>{\x2?}\x2@\x7F"+
		"\x2\x41\x81\x2\x42\x83\x2\x43\x85\x2\x44\x87\x2\x45\x89\x2\x46\x8B\x2"+
		"G\x8D\x2H\x8F\x2\x2\x91\x2\x2\x93\x2\x2\x3\x2\b\x4\x2\v\f\xF\xF\b\x2\f"+
		"\f\xF\xF\"\"\x32;\x43\\\x63|\x6\x2\"\"\x32;\x43\\\x63|\x4\x2\xF\xF\"\""+
		"\x4\x2\f\f\xF\xF\x4\x2\x43\\\x63|\x21C\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2"+
		"\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2"+
		"\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2"+
		"\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D"+
		"\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3"+
		"\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2"+
		"\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2"+
		"\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2"+
		"\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3"+
		"\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2"+
		"\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2"+
		"W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2"+
		"\x2\x2\x2\x61\x3\x2\x2\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x2g\x3"+
		"\x2\x2\x2\x2i\x3\x2\x2\x2\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2"+
		"\x2\x2q\x3\x2\x2\x2\x2s\x3\x2\x2\x2\x2u\x3\x2\x2\x2\x2w\x3\x2\x2\x2\x2"+
		"y\x3\x2\x2\x2\x2{\x3\x2\x2\x2\x2}\x3\x2\x2\x2\x2\x7F\x3\x2\x2\x2\x2\x81"+
		"\x3\x2\x2\x2\x2\x83\x3\x2\x2\x2\x2\x85\x3\x2\x2\x2\x2\x87\x3\x2\x2\x2"+
		"\x2\x89\x3\x2\x2\x2\x2\x8B\x3\x2\x2\x2\x2\x8D\x3\x2\x2\x2\x3\x95\x3\x2"+
		"\x2\x2\x5\x99\x3\x2\x2\x2\a\x9D\x3\x2\x2\x2\t\xAD\x3\x2\x2\x2\v\xBB\x3"+
		"\x2\x2\x2\r\xBE\x3\x2\x2\x2\xF\xC3\x3\x2\x2\x2\x11\xC6\x3\x2\x2\x2\x13"+
		"\xCE\x3\x2\x2\x2\x15\xD3\x3\x2\x2\x2\x17\xD9\x3\x2\x2\x2\x19\xDD\x3\x2"+
		"\x2\x2\x1B\xE5\x3\x2\x2\x2\x1D\xEB\x3\x2\x2\x2\x1F\xF2\x3\x2\x2\x2!\xF7"+
		"\x3\x2\x2\x2#\xFD\x3\x2\x2\x2%\x103\x3\x2\x2\x2\'\x107\x3\x2\x2\x2)\x10D"+
		"\x3\x2\x2\x2+\x112\x3\x2\x2\x2-\x118\x3\x2\x2\x2/\x11A\x3\x2\x2\x2\x31"+
		"\x11C\x3\x2\x2\x2\x33\x11E\x3\x2\x2\x2\x35\x120\x3\x2\x2\x2\x37\x122\x3"+
		"\x2\x2\x2\x39\x124\x3\x2\x2\x2;\x126\x3\x2\x2\x2=\x128\x3\x2\x2\x2?\x12A"+
		"\x3\x2\x2\x2\x41\x12C\x3\x2\x2\x2\x43\x12F\x3\x2\x2\x2\x45\x132\x3\x2"+
		"\x2\x2G\x134\x3\x2\x2\x2I\x137\x3\x2\x2\x2K\x139\x3\x2\x2\x2M\x13C\x3"+
		"\x2\x2\x2O\x13F\x3\x2\x2\x2Q\x142\x3\x2\x2\x2S\x145\x3\x2\x2\x2U\x148"+
		"\x3\x2\x2\x2W\x14A\x3\x2\x2\x2Y\x14C\x3\x2\x2\x2[\x14E\x3\x2\x2\x2]\x150"+
		"\x3\x2\x2\x2_\x152\x3\x2\x2\x2\x61\x154\x3\x2\x2\x2\x63\x156\x3\x2\x2"+
		"\x2\x65\x158\x3\x2\x2\x2g\x15A\x3\x2\x2\x2i\x15C\x3\x2\x2\x2k\x15E\x3"+
		"\x2\x2\x2m\x160\x3\x2\x2\x2o\x162\x3\x2\x2\x2q\x164\x3\x2\x2\x2s\x166"+
		"\x3\x2\x2\x2u\x169\x3\x2\x2\x2w\x16C\x3\x2\x2\x2y\x16F\x3\x2\x2\x2{\x171"+
		"\x3\x2\x2\x2}\x173\x3\x2\x2\x2\x7F\x175\x3\x2\x2\x2\x81\x177\x3\x2\x2"+
		"\x2\x83\x18B\x3\x2\x2\x2\x85\x195\x3\x2\x2\x2\x87\x19F\x3\x2\x2\x2\x89"+
		"\x1CD\x3\x2\x2\x2\x8B\x1D2\x3\x2\x2\x2\x8D\x1D4\x3\x2\x2\x2\x8F\x1DB\x3"+
		"\x2\x2\x2\x91\x1DD\x3\x2\x2\x2\x93\x1E2\x3\x2\x2\x2\x95\x96\a\"\x2\x2"+
		"\x96\x97\x3\x2\x2\x2\x97\x98\b\x2\x2\x2\x98\x4\x3\x2\x2\x2\x99\x9A\t\x2"+
		"\x2\x2\x9A\x9B\x3\x2\x2\x2\x9B\x9C\b\x3\x2\x2\x9C\x6\x3\x2\x2\x2\x9D\x9E"+
		"\a\x31\x2\x2\x9E\x9F\a,\x2\x2\x9F\xA5\x3\x2\x2\x2\xA0\xA4\t\x3\x2\x2\xA1"+
		"\xA4\x5\x89\x45\x2\xA2\xA4\x5\a\x4\x2\xA3\xA0\x3\x2\x2\x2\xA3\xA1\x3\x2"+
		"\x2\x2\xA3\xA2\x3\x2\x2\x2\xA4\xA7\x3\x2\x2\x2\xA5\xA3\x3\x2\x2\x2\xA5"+
		"\xA6\x3\x2\x2\x2\xA6\xA8\x3\x2\x2\x2\xA7\xA5\x3\x2\x2\x2\xA8\xA9\a,\x2"+
		"\x2\xA9\xAA\a\x31\x2\x2\xAA\xAB\x3\x2\x2\x2\xAB\xAC\b\x4\x2\x2\xAC\b\x3"+
		"\x2\x2\x2\xAD\xAE\a\x31\x2\x2\xAE\xAF\a\x31\x2\x2\xAF\xB6\x3\x2\x2\x2"+
		"\xB0\xB5\t\x4\x2\x2\xB1\xB5\x5\x93J\x2\xB2\xB5\x5u;\x2\xB3\xB5\x5u;\x2"+
		"\xB4\xB0\x3\x2\x2\x2\xB4\xB1\x3\x2\x2\x2\xB4\xB2\x3\x2\x2\x2\xB4\xB3\x3"+
		"\x2\x2\x2\xB5\xB8\x3\x2\x2\x2\xB6\xB4\x3\x2\x2\x2\xB6\xB7\x3\x2\x2\x2"+
		"\xB7\xB9\x3\x2\x2\x2\xB8\xB6\x3\x2\x2\x2\xB9\xBA\b\x5\x2\x2\xBA\n\x3\x2"+
		"\x2\x2\xBB\xBC\ak\x2\x2\xBC\xBD\ap\x2\x2\xBD\f\x3\x2\x2\x2\xBE\xBF\ax"+
		"\x2\x2\xBF\xC0\aq\x2\x2\xC0\xC1\ak\x2\x2\xC1\xC2\a\x66\x2\x2\xC2\xE\x3"+
		"\x2\x2\x2\xC3\xC4\ak\x2\x2\xC4\xC5\ah\x2\x2\xC5\x10\x3\x2\x2\x2\xC6\xC7"+
		"\ag\x2\x2\xC7\xC8\an\x2\x2\xC8\xC9\au\x2\x2\xC9\xCA\ag\x2\x2\xCA\xCB\a"+
		"\"\x2\x2\xCB\xCC\ak\x2\x2\xCC\xCD\ah\x2\x2\xCD\x12\x3\x2\x2\x2\xCE\xCF"+
		"\ag\x2\x2\xCF\xD0\an\x2\x2\xD0\xD1\au\x2\x2\xD1\xD2\ag\x2\x2\xD2\x14\x3"+
		"\x2\x2\x2\xD3\xD4\ay\x2\x2\xD4\xD5\aj\x2\x2\xD5\xD6\ak\x2\x2\xD6\xD7\a"+
		"n\x2\x2\xD7\xD8\ag\x2\x2\xD8\x16\x3\x2\x2\x2\xD9\xDA\ah\x2\x2\xDA\xDB"+
		"\aq\x2\x2\xDB\xDC\at\x2\x2\xDC\x18\x3\x2\x2\x2\xDD\xDE\ah\x2\x2\xDE\xDF"+
		"\aq\x2\x2\xDF\xE0\at\x2\x2\xE0\xE1\ag\x2\x2\xE1\xE2\a\x63\x2\x2\xE2\xE3"+
		"\a\x65\x2\x2\xE3\xE4\aj\x2\x2\xE4\x1A\x3\x2\x2\x2\xE5\xE6\a\x64\x2\x2"+
		"\xE6\xE7\at\x2\x2\xE7\xE8\ag\x2\x2\xE8\xE9\a\x63\x2\x2\xE9\xEA\am\x2\x2"+
		"\xEA\x1C\x3\x2\x2\x2\xEB\xEC\at\x2\x2\xEC\xED\ag\x2\x2\xED\xEE\av\x2\x2"+
		"\xEE\xEF\aw\x2\x2\xEF\xF0\at\x2\x2\xF0\xF1\ap\x2\x2\xF1\x1E\x3\x2\x2\x2"+
		"\xF2\xF3\at\x2\x2\xF3\xF4\ag\x2\x2\xF4\xF5\a\x63\x2\x2\xF5\xF6\a\x66\x2"+
		"\x2\xF6 \x3\x2\x2\x2\xF7\xF8\ay\x2\x2\xF8\xF9\at\x2\x2\xF9\xFA\ak\x2\x2"+
		"\xFA\xFB\av\x2\x2\xFB\xFC\ag\x2\x2\xFC\"\x3\x2\x2\x2\xFD\xFE\a\x65\x2"+
		"\x2\xFE\xFF\an\x2\x2\xFF\x100\a\x63\x2\x2\x100\x101\au\x2\x2\x101\x102"+
		"\au\x2\x2\x102$\x3\x2\x2\x2\x103\x104\ap\x2\x2\x104\x105\ag\x2\x2\x105"+
		"\x106\ay\x2\x2\x106&\x3\x2\x2\x2\x107\x108\a\x65\x2\x2\x108\x109\aq\x2"+
		"\x2\x109\x10A\ap\x2\x2\x10A\x10B\au\x2\x2\x10B\x10C\av\x2\x2\x10C(\x3"+
		"\x2\x2\x2\x10D\x10E\av\x2\x2\x10E\x10F\at\x2\x2\x10F\x110\aw\x2\x2\x110"+
		"\x111\ag\x2\x2\x111*\x3\x2\x2\x2\x112\x113\ah\x2\x2\x113\x114\a\x63\x2"+
		"\x2\x114\x115\an\x2\x2\x115\x116\au\x2\x2\x116\x117\ag\x2\x2\x117,\x3"+
		"\x2\x2\x2\x118\x119\a=\x2\x2\x119.\x3\x2\x2\x2\x11A\x11B\a.\x2\x2\x11B"+
		"\x30\x3\x2\x2\x2\x11C\x11D\a?\x2\x2\x11D\x32\x3\x2\x2\x2\x11E\x11F\a*"+
		"\x2\x2\x11F\x34\x3\x2\x2\x2\x120\x121\a+\x2\x2\x121\x36\x3\x2\x2\x2\x122"+
		"\x123\a-\x2\x2\x123\x38\x3\x2\x2\x2\x124\x125\a,\x2\x2\x125:\x3\x2\x2"+
		"\x2\x126\x127\a\x31\x2\x2\x127<\x3\x2\x2\x2\x128\x129\a/\x2\x2\x129>\x3"+
		"\x2\x2\x2\x12A\x12B\a\'\x2\x2\x12B@\x3\x2\x2\x2\x12C\x12D\a?\x2\x2\x12D"+
		"\x12E\a?\x2\x2\x12E\x42\x3\x2\x2\x2\x12F\x130\a#\x2\x2\x130\x131\a?\x2"+
		"\x2\x131\x44\x3\x2\x2\x2\x132\x133\a>\x2\x2\x133\x46\x3\x2\x2\x2\x134"+
		"\x135\a>\x2\x2\x135\x136\a?\x2\x2\x136H\x3\x2\x2\x2\x137\x138\a@\x2\x2"+
		"\x138J\x3\x2\x2\x2\x139\x13A\a@\x2\x2\x13A\x13B\a?\x2\x2\x13BL\x3\x2\x2"+
		"\x2\x13C\x13D\a~\x2\x2\x13D\x13E\a~\x2\x2\x13EN\x3\x2\x2\x2\x13F\x140"+
		"\a(\x2\x2\x140\x141\a(\x2\x2\x141P\x3\x2\x2\x2\x142\x143\a-\x2\x2\x143"+
		"\x144\a-\x2\x2\x144R\x3\x2\x2\x2\x145\x146\a/\x2\x2\x146\x147\a/\x2\x2"+
		"\x147T\x3\x2\x2\x2\x148\x149\a\x30\x2\x2\x149V\x3\x2\x2\x2\x14A\x14B\a"+
		"]\x2\x2\x14BX\x3\x2\x2\x2\x14C\x14D\a_\x2\x2\x14DZ\x3\x2\x2\x2\x14E\x14F"+
		"\a}\x2\x2\x14F\\\x3\x2\x2\x2\x150\x151\a\x7F\x2\x2\x151^\x3\x2\x2\x2\x152"+
		"\x153\a#\x2\x2\x153`\x3\x2\x2\x2\x154\x155\a\xA3\x2\x2\x155\x62\x3\x2"+
		"\x2\x2\x156\x157\a%\x2\x2\x157\x64\x3\x2\x2\x2\x158\x159\a&\x2\x2\x159"+
		"\x66\x3\x2\x2\x2\x15A\x15B\a(\x2\x2\x15Bh\x3\x2\x2\x2\x15C\x15D\a\x41"+
		"\x2\x2\x15Dj\x3\x2\x2\x2\x15E\x15F\a\x42\x2\x2\x15Fl\x3\x2\x2\x2\x160"+
		"\x161\a\x61\x2\x2\x161n\x3\x2\x2\x2\x162\x163\a$\x2\x2\x163p\x3\x2\x2"+
		"\x2\x164\x165\a~\x2\x2\x165r\x3\x2\x2\x2\x166\x167\a\x31\x2\x2\x167\x168"+
		"\a\x31\x2\x2\x168t\x3\x2\x2\x2\x169\x16A\a\x31\x2\x2\x16A\x16B\a,\x2\x2"+
		"\x16Bv\x3\x2\x2\x2\x16C\x16D\a,\x2\x2\x16D\x16E\a\x31\x2\x2\x16Ex\x3\x2"+
		"\x2\x2\x16F\x170\a<\x2\x2\x170z\x3\x2\x2\x2\x171\x172\a\x80\x2\x2\x172"+
		"|\x3\x2\x2\x2\x173\x174\a\x62\x2\x2\x174~\x3\x2\x2\x2\x175\x176\a`\x2"+
		"\x2\x176\x80\x3\x2\x2\x2\x177\x17E\x5o\x38\x2\x178\x17D\x5\x8FH\x2\x179"+
		"\x17D\x5\x91I\x2\x17A\x17D\x5\x93J\x2\x17B\x17D\t\x5\x2\x2\x17C\x178\x3"+
		"\x2\x2\x2\x17C\x179\x3\x2\x2\x2\x17C\x17A\x3\x2\x2\x2\x17C\x17B\x3\x2"+
		"\x2\x2\x17D\x180\x3\x2\x2\x2\x17E\x17C\x3\x2\x2\x2\x17E\x17F\x3\x2\x2"+
		"\x2\x17F\x181\x3\x2\x2\x2\x180\x17E\x3\x2\x2\x2\x181\x182\x5o\x38\x2\x182"+
		"\x82\x3\x2\x2\x2\x183\x187\x4\x33;\x2\x184\x186\x5\x91I\x2\x185\x184\x3"+
		"\x2\x2\x2\x186\x189\x3\x2\x2\x2\x187\x185\x3\x2\x2\x2\x187\x188\x3\x2"+
		"\x2\x2\x188\x18C\x3\x2\x2\x2\x189\x187\x3\x2\x2\x2\x18A\x18C\a\x32\x2"+
		"\x2\x18B\x183\x3\x2\x2\x2\x18B\x18A\x3\x2\x2\x2\x18C\x84\x3\x2\x2\x2\x18D"+
		"\x191\x4\x33;\x2\x18E\x190\x5\x91I\x2\x18F\x18E\x3\x2\x2\x2\x190\x193"+
		"\x3\x2\x2\x2\x191\x18F\x3\x2\x2\x2\x191\x192\x3\x2\x2\x2\x192\x196\x3"+
		"\x2\x2\x2\x193\x191\x3\x2\x2\x2\x194\x196\a\x32\x2\x2\x195\x18D\x3\x2"+
		"\x2\x2\x195\x194\x3\x2\x2\x2\x196\x197\x3\x2\x2\x2\x197\x198\a\x30\x2"+
		"\x2\x198\x19C\x5\x91I\x2\x199\x19B\x5\x91I\x2\x19A\x199\x3\x2\x2\x2\x19B"+
		"\x19E\x3\x2\x2\x2\x19C\x19A\x3\x2\x2\x2\x19C\x19D\x3\x2\x2\x2\x19D\x86"+
		"\x3\x2\x2\x2\x19E\x19C\x3\x2\x2\x2\x19F\x1A5\x5\x8FH\x2\x1A0\x1A4\x5\x8F"+
		"H\x2\x1A1\x1A4\x5\x91I\x2\x1A2\x1A4\a\x61\x2\x2\x1A3\x1A0\x3\x2\x2\x2"+
		"\x1A3\x1A1\x3\x2\x2\x2\x1A3\x1A2\x3\x2\x2\x2\x1A4\x1A7\x3\x2\x2\x2\x1A5"+
		"\x1A3\x3\x2\x2\x2\x1A5\x1A6\x3\x2\x2\x2\x1A6\x88\x3\x2\x2\x2\x1A7\x1A5"+
		"\x3\x2\x2\x2\x1A8\x1CE\x5-\x17\x2\x1A9\x1CE\x5/\x18\x2\x1AA\x1CE\x5\x31"+
		"\x19\x2\x1AB\x1CE\x5\x33\x1A\x2\x1AC\x1CE\x5\x35\x1B\x2\x1AD\x1CE\x5\x37"+
		"\x1C\x2\x1AE\x1CE\x5=\x1F\x2\x1AF\x1CE\x5? \x2\x1B0\x1CE\x5\x41!\x2\x1B1"+
		"\x1CE\x5\x43\"\x2\x1B2\x1CE\x5\x45#\x2\x1B3\x1CE\x5G$\x2\x1B4\x1CE\x5"+
		"I%\x2\x1B5\x1CE\x5K&\x2\x1B6\x1CE\x5M\'\x2\x1B7\x1CE\x5O(\x2\x1B8\x1CE"+
		"\x5Q)\x2\x1B9\x1CE\x5S*\x2\x1BA\x1CE\x5U+\x2\x1BB\x1CE\x5W,\x2\x1BC\x1CE"+
		"\x5Y-\x2\x1BD\x1CE\x5[.\x2\x1BE\x1CE\x5]/\x2\x1BF\x1CE\x5_\x30\x2\x1C0"+
		"\x1CE\x5\x61\x31\x2\x1C1\x1CE\x5\x63\x32\x2\x1C2\x1CE\x5\x65\x33\x2\x1C3"+
		"\x1CE\x5g\x34\x2\x1C4\x1CE\x5i\x35\x2\x1C5\x1CE\x5k\x36\x2\x1C6\x1CE\x5"+
		"m\x37\x2\x1C7\x1CE\x5q\x39\x2\x1C8\x1CE\x5s:\x2\x1C9\x1CE\x5y=\x2\x1CA"+
		"\x1CE\x5{>\x2\x1CB\x1CE\x5}?\x2\x1CC\x1CE\x5\x7F@\x2\x1CD\x1A8\x3\x2\x2"+
		"\x2\x1CD\x1A9\x3\x2\x2\x2\x1CD\x1AA\x3\x2\x2\x2\x1CD\x1AB\x3\x2\x2\x2"+
		"\x1CD\x1AC\x3\x2\x2\x2\x1CD\x1AD\x3\x2\x2\x2\x1CD\x1AE\x3\x2\x2\x2\x1CD"+
		"\x1AF\x3\x2\x2\x2\x1CD\x1B0\x3\x2\x2\x2\x1CD\x1B1\x3\x2\x2\x2\x1CD\x1B2"+
		"\x3\x2\x2\x2\x1CD\x1B3\x3\x2\x2\x2\x1CD\x1B4\x3\x2\x2\x2\x1CD\x1B5\x3"+
		"\x2\x2\x2\x1CD\x1B6\x3\x2\x2\x2\x1CD\x1B7\x3\x2\x2\x2\x1CD\x1B8\x3\x2"+
		"\x2\x2\x1CD\x1B9\x3\x2\x2\x2\x1CD\x1BA\x3\x2\x2\x2\x1CD\x1BB\x3\x2\x2"+
		"\x2\x1CD\x1BC\x3\x2\x2\x2\x1CD\x1BD\x3\x2\x2\x2\x1CD\x1BE\x3\x2\x2\x2"+
		"\x1CD\x1BF\x3\x2\x2\x2\x1CD\x1C0\x3\x2\x2\x2\x1CD\x1C1\x3\x2\x2\x2\x1CD"+
		"\x1C2\x3\x2\x2\x2\x1CD\x1C3\x3\x2\x2\x2\x1CD\x1C4\x3\x2\x2\x2\x1CD\x1C5"+
		"\x3\x2\x2\x2\x1CD\x1C6\x3\x2\x2\x2\x1CD\x1C7\x3\x2\x2\x2\x1CD\x1C8\x3"+
		"\x2\x2\x2\x1CD\x1C9\x3\x2\x2\x2\x1CD\x1CA\x3\x2\x2\x2\x1CD\x1CB\x3\x2"+
		"\x2\x2\x1CD\x1CC\x3\x2\x2\x2\x1CE\x8A\x3\x2\x2\x2\x1CF\x1D3\x5\x89\x45"+
		"\x2\x1D0\x1D3\x5\x39\x1D\x2\x1D1\x1D3\x5;\x1E\x2\x1D2\x1CF\x3\x2\x2\x2"+
		"\x1D2\x1D0\x3\x2\x2\x2\x1D2\x1D1\x3\x2\x2\x2\x1D3\x8C\x3\x2\x2\x2\x1D4"+
		"\x1D7\a)\x2\x2\x1D5\x1D8\x5\x93J\x2\x1D6\x1D8\t\x6\x2\x2\x1D7\x1D5\x3"+
		"\x2\x2\x2\x1D7\x1D6\x3\x2\x2\x2\x1D8\x1D9\x3\x2\x2\x2\x1D9\x1DA\a)\x2"+
		"\x2\x1DA\x8E\x3\x2\x2\x2\x1DB\x1DC\t\a\x2\x2\x1DC\x90\x3\x2\x2\x2\x1DD"+
		"\x1DE\x4\x32;\x2\x1DE\x92\x3\x2\x2\x2\x1DF\x1E3\x5\x8FH\x2\x1E0\x1E3\x5"+
		"\x91I\x2\x1E1\x1E3\x5\x8B\x46\x2\x1E2\x1DF\x3\x2\x2\x2\x1E2\x1E0\x3\x2"+
		"\x2\x2\x1E2\x1E1\x3\x2\x2\x2\x1E3\x94\x3\x2\x2\x2\x14\x2\xA3\xA5\xB4\xB6"+
		"\x17C\x17E\x187\x18B\x191\x195\x19C\x1A3\x1A5\x1CD\x1D2\x1D7\x1E2\x3\x2"+
		"\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace AnalizadorSintactico
