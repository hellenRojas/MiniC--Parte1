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
: declarations statements EOF # conDeclAST
| statements EOF # sinDeclAST
;

declarations 
: declaration PyCOMA ( declaration PyCOMA )* #declsAST 
;

declaration
: INT idlist # intDeclAST
| STRING idlist # strDeclAST
;

statements
: statement ( PyCOMA statement )* # statsAST
;

statement
: (ID ASIGN | ) expression # asignStatAST
| expression # exprStatAST
| # epsStatAST
;

expression
: term ( SUMA term )* # exprsAST
;

term
: factor ( MUL factor )* # termsAST
;

factor
: PIZQ expression PDER # exprFactAST
| ID # idFactAST
| NUM # numFactAST
| STR # strFactAST
;

idlist
: ID ( COMA ID )* # idlistsAST
;