
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



ConstantDecl
: CONSTANTE Type IDENT ASIGN (NUMBER | CHARCONST) PyCOMA 
;


VarDecl
: Type IDENT (COMA IDENT)* PyComa
;



ClassDecl
: CLASS IDENT COR_DER (VarDecl)* COR_IZQ
;



MethodDecl
: (Type | VOID) IDENT PIZQ [FormPars] PDER (VarDecl)* Block
;


FormPars
: Type IDENT (COMA Type IDENT)*
;

Type
: IDENT [PCUADRADO_IZQ PCUADRADO_DER]
;

Statment
: Designator (ASIGN Expr | PIZQ [ActPars] PDER | INCRE | DECRE) PyCOMA
| CONDICION_IF PIZQ Condition PDER Statement [CONDICION_ELSE Statement]
| CICLO_FOR PIZQ Expr PyCOMA [Condition] PyCOMA [Statement] PDER Statement
| CICLO_WHILE PIZQ Condition PDER Statement
| CICLO_FOREACH PARIZQ Type IDENT IN Expr PARDER Stament
| BREAK PyCOMA
| RETURN [Expr] PyComa
| READ PIZQ Designator PDER PyCOMA
| WRITE PIZQ Expr [COMA NUMBER] PDER PyCOMA
| Block
| PyCOMA
;


Block
: COR_DER (Statement)* COR_IZQ
;



ActPars
: Expr (COMA Expr)*
;

Condition
: CondTerm (O CondTerm)*
;

CondTerm
: CondFact (Y CondFact)*
;

CondFact
: Expr Relop Expr //preguntar si lleva |
;

Expr
: [RESTA] Term (Addop Term)*
;

Term
: Factor (Mulop Factor)*
;

Factor
: Designator [PIZQ [ActPars] PDER]
| NUMBER
| CHARCONST
| (TRUE | FALSE)*
| NEW IDENT [ PCUADRADO_IZQ Expr PCUADRADO_DER]
| PIZQ Expr PDER
;

Designator
: IDENT (PUNTO IDENT | PCUADRADO_IZQ Expr PCUADRADO_DER)*
;

Relop
: COMPARACION | DIFERENTE | MAYOR | MAYORIGUAL | MENOR | MENORIGUAL
;

Addop
: SUMA | RESTA
;

Mulop
: MUL | DIV DIVMOD
;