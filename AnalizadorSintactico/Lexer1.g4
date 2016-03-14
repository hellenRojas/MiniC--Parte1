lexer grammar Lexer1;

WS
: ' ' -> channel(HIDDEN)
;

NEWLINE 
: ('\n'|'\r'|'\t')-> channel(HIDDEN)
;

COMMMETBLOCK
: ('/*' ('0'..'9'|'A'..'Z'| 'a'..'z'|'\n'|'\r'|' ')* '*/')-> channel(HIDDEN)
;

COMMMET
: ('//' ('0'..'9'|'A'..'Z'| 'a'..'z'|' ')* )-> channel(HIDDEN)
;
IN
: 'in'
;
INT 
: 'int'C:\Users\usuario\Desktop\MiniCSharp-Parte1\AnalizadorSintactico\Lexer1.g4
;

STRING 
: 'string'
;

FLOAT
: 'float'
;

BOOLEAN
: 'boolean'
;

VOID
: 'void'
;


CONDICION_IF
: 'if'
;

CONDICION_ELSE_IF
: 'else if'
;

CONDICION_ELSE
: 'else'
;

CICLO_WHILE
: 'while'
;

CICLO_FOR
: 'for'
;
CICLO_FOREACH
: 'foreach'
;
BREAK
: 'break'
;

RETURN
: 'return'
;

READ
: 'read'
;

WRITE
: 'write'
;

CLASE
: 'class'
;

NEW
: 'new'
;

CONSTANTE
: 'const'
;
TRUE
: 'true'
;

FALSE
: 'false'
;



PyCOMA : ';' ;
COMA : ',' ;
ASIGN : '=' ;
PIZQ : '(' ;
PDER : ')' ;
SUMA : '+' ;
MUL : '*' ;
DIV : '/';
RESTA : '-';
DIVMOD : '%';
COMPARACION : '==' ;
DIFERENTE : '!=' ;
MENOR: '<' ;
MENORIGUAL: '<=' ;
MAYOR: '>' ;
MAYORIGUAL: '>=' ;
O : '||';
Y : '&&';
INCRE : '++';
DECRE : '--';
PUNTO : '.';
PCUADRADO_IZQ: '[';
PCUADRADO_DER: ']';
COR_DER: '{';
COR_IZQ: '}';

LETTER
: 'a'..'z' | 'A'..'Z'
;

DIGIT
: '0'..'9'
;

NUMBER
: DIGIT ('0'..'9')*
;

ID
: LETTER (LETTER | DIGIT)*
;

IDENT
: LETTER | (LETTER | DIGIT| '_')*
;

CharConst: '\'' (PrintableChar|'\n'|'\r') '\'';


PrintableChar: (LETTER|DIGIT|'!'| '"'| '#'| '$'| '%'| '&'|'\''| '(' | ')' | '*'| '+'| ','| '-'| '.'| '/' |':'| ';'| '<'| '='| '>'| '?'| '@');

LQUOTE : '"' -> more, mode(STRI) ;


mode STRI;
STR : '"' -> mode(DEFAULT_MODE) ; 
TEXT : .-> more ;