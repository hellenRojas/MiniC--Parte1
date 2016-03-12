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



INT 
: 'int'
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

PyCOMA : ';' ;
COMA : ',' ;
ASIGN : '=' ;
PIZQ : '(' ;
PDER : ')' ;
SUMA : '+' ;
MUL : '*' ;
DIV : '/';
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
PCUADRADO_DER: '[';
PCUADRADO_IZQ: ']';
COR_DER: '{';
COR_IZQ: '}';

NUM
: '0' | '1'..'9' ('0'..'9')*
;

ID
: CharInicial CharContenido* 
;

LQUOTE : '"' -> more, mode(STRI) ;

fragment
CharContenido
: CharInicial
| '0'..'9'
| '_'
;
fragment
CharInicial
: 'A'..'Z' | 'a'..'z'
;

mode STRI;
STR : '"' -> mode(DEFAULT_MODE) ; 
TEXT : .-> more ;
