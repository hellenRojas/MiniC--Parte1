
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
: CLASE IDENT (constDecl | varDecl | classDecl)* COR_DER (methodDecl)* COR_IZQ					#programAST
;



constDecl
: CONSTANTE type IDENT ASIGN (NUMBER | CharConst) PyCOMA										#constDeclAST
;


varDecl
: type IDENT (COMA IDENT)* PyCOMA																#varDeclAST
;



classDecl
: CLASE IDENT COR_DER (varDecl)* COR_IZQ														#classDeclAST
;



methodDecl
: (type | VOID) IDENT PIZQ (formPars)? PDER (varDecl)* block									#methodDeclAST
;


formPars
: type IDENT (COMA type IDENT)*																	#formParsAST
;

type
: IDENT (PCUADRADO_IZQ PCUADRADO_DER)?															#typeAST
;

statement
: designator (ASIGN expr | PIZQ (actPars)? PDER | INCRE | DECRE) PyCOMA							#designatorStatAST
| CONDICION_IF PIZQ condition PDER statement (CONDICION_ELSE statement)?						#ifStatAST
| CICLO_FOR PIZQ expr PyCOMA (condition)? PyCOMA (statement)? PDER statement					#forStatAST
| CICLO_WHILE PIZQ condition PDER statement														#whileStatAST
| CICLO_FOREACH PIZQ type IDENT IN expr PDER statement											#foreachStatAST
| BREAK PyCOMA																					#breakStatAST
| RETURN (expr)? PyCOMA																			#returnStatAST
| READ PIZQ designator PDER PyCOMA																#readStatAST
| WRITE PIZQ expr (COMA NUMBER)? PDER PyCOMA													#writeStatAST
| block																							#blockStatAST
| PyCOMA																						#pyStatAST
;


block
: COR_DER (statement)* COR_IZQ																	#blockAST
;

actPars
: expr (COMA expr)*																				#actParsAST
;

condition
: condTerm (O condTerm)*																		#conditionAST
;

condTerm
: condFact (Y condFact)*																		#condTermAST
;
/*preguntar si lleva |*/
condFact
: expr relop expr 																				#condFactAST
;

expr
: (RESTA)? term (addop term)*		//aquí															#exprAST
;

term//ya
: factor (mulop factor)*																		#termAST
;

factor
: designator (PIZQ (actPars)? PDER)?															#designatorFactorAST
| NUMBER																						#numberFactorAST
| CharConst																						#charconstFactorAST
| (TRUE | FALSE)																				#truefalseFactorAST
| NEW IDENT (PCUADRADO_IZQ expr PCUADRADO_DER)?													#newFactorAST
| PIZQ expr PDER																				#exprFactorAST
;

designator
: IDENT (PUNTO IDENT | PCUADRADO_IZQ expr PCUADRADO_DER)*										#designatorAST
;

relop
: COMPARACION | DIFERENTE | MAYOR | MAYORIGUAL | MENOR | MENORIGUAL								#relopAST
;

addop
: SUMA | RESTA																					#addopAST
;

mulop
: MUL | DIV | DIVMOD																			#mulopAST
;
