
parser grammar Parser1;

@header {
using System;
}

options {
language = CSharp;
tokenVocab = Lexer1;
}
/*
* Parser Rules
*/


program 
: CLASE IDENT (ConstDecl | VarDecl | ClassDecl)* COR_DER (MethodDecl)* COR_IZQ
;



constantDecl
: CONSTANTE type IDENT ASIGN (NUMBER | CHARCONST) PyCOMA 
;


varDecl
: type IDENT (COMA IDENT)* PyComa
;



classDecl
: CLASS IDENT COR_DER (VarDecl)* COR_IZQ
;



methodDecl
: (type | VOID) IDENT PIZQ (formPars) PDER (varDecl)* block
;


formPars
: type IDENT (COMA type IDENT)*
;

type
: IDENT (PCUADRADO_IZQ PCUADRADO_DER)
;

statement
: designator (ASIGN expr | PIZQ (actPars) PDER | INCRE | DECRE) PyCOMA
| CONDICION_IF PIZQ condition PDER statement (CONDICION_ELSE statement)
| CICLO_FOR PIZQ expr PyCOMA (condition) PyCOMA (statement) PDER statement
| CICLO_WHILE PIZQ condition PDER statement
| CICLO_FOREACH PARIZQ type IDENT IN expr PARDER statement
| BREAK PyCOMA
| RETURN (expr) PyComa
| READ PIZQ designator PDER PyCOMA
| WRITE PIZQ Expr (COMA NUMBER) PDER PyCOMA
| block
| PyCOMA
;


block
: COR_DER (Statement)* COR_IZQ
;



actPars
: Expr (COMA Expr)*
;

condition
: CondTerm (O CondTerm)*
;

condTerm
: CondFact (Y CondFact)*
;

condFact
: Expr Relop Expr //preguntar si lleva |
;

expr
: (RESTA) Term (Addop Term)*
;

term
: Factor (Mulop Factor)*
;

factor
: Designator (PIZQ (ActPars) PDER)
| NUMBER
| CHARCONST
| (TRUE | FALSE)*
| NEW IDENT (PCUADRADO_IZQ Expr PCUADRADO_DER)
| PIZQ Expr PDER
;

designator
: IDENT (PUNTO IDENT | PCUADRADO_IZQ Expr PCUADRADO_DER)*
;

relop
: COMPARACION | DIFERENTE | MAYOR | MAYORIGUAL | MENOR | MENORIGUAL
;

addop
: SUMA | RESTA
;

mulop
: MUL | DIV DIVMOD
;