using AnalizadorSintactico;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisSintactico
{
    class ParserErrorListener:BaseErrorListener
    {
        public static ParserErrorListener Instancia = new ParserErrorListener();

        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, 
            int charPositionInLine, string msg, RecognitionException e)
        {
            
            Program.p.error.AppendText("Error de Parser: linea= "+line+", columna= " + charPositionInLine+"  ");
            if (e != null)
            {
                if (e is NoViableAltException)
                {
                    msg = "Símbolo inválido...";
                }
                else if (e is LexerNoViableAltException)
                {
                    msg = "Símbolo inválido...";
                }
                else if (e is FailedPredicateException)
                {
                    msg = "La sintaxis de la expresión no es la correcta";
                }
                else if (e is InputMismatchException)
                {
                    IntervalSet expecting = e.GetExpectedTokens();
                    msg = "La entrada "+"'"+ e.OffendingToken.Text+"'"+" no coincide con lo que se espera "+ expecting.ToString(recognizer.TokenNames);
                }
                else
                {
                    msg = "Error del programa...";
                }
                Program.p.error.AppendText(msg+"\n");

            }
            else {
                Program.p.error.AppendText(msg + "\n");
            }
            throw new ParserException();
            
        }
    }
}
