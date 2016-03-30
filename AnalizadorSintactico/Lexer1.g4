lexer grammar Lexer1;

WS:	(' ')-> channel(HIDDEN)
;

NEWLINE 
: ('\n'|'\r'|'\t')-> channel(HIDDEN)
;

COMMMETBLOCK
: ('/*' ('0'..'9'|'A'..'Z'| 'a'..'z'|'\n'|'\r'|' '|PrintableChar)* '*/')-> channel(HIDDEN)
;

COMMMET
: ('//' ('0'..'9'|'A'..'Z'| 'a'..'z'|' ' |PrintableChar)* )-> channel(HIDDEN)
;

IN
: 'in'
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




NUMBER
: '1'..'9' (DIGIT)*|'0'
;


ID
: LETTER (LETTER | DIGIT | '_')*
;




CharConst: '\'' (PrintableChar|'\n'|'\r') '\'';

fragment
LETTER: 'a'..'z' | 'A'..'Z';

fragment
DIGIT: '0'..'9';

fragment
PrintableChar: (LETTER|DIGIT|'!'| '"'| '#'| '$'| '%'| '&'|'\''| '(' | ')' | '*'| '+'| ','| '-'| '.'| '/' |':'| ';'| '<'| '='| '>'| '?'| '@');

LQUOTE : '"' -> more, mode(STRI) ;


mode STRI;
STR : '"' -> mode(DEFAULT_MODE) ; 
TEXT : .-> more ;