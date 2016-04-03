using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using AnalisisSintactico;

class MyErrorListener : BaseErrorListener
{
    public static MyErrorListener INSTANCE = new MyErrorListener();

    public override void SyntaxError(IRecognizer recognizer,
                            IToken offendingSymbol,
                            int line, int charPositionInLine, string msg,
                            RecognitionException e)
    {

        if (e != null)
        {

            if (e is NoViableAltException)
                msg = "Error en el parser en la línea: " + line + ", columna: " + charPositionInLine + "\n" +
                    "El token: " + offendingSymbol.Text + " no es una alternativa viable!!!\n\n";
            else if (e is LexerNoViableAltException)
                msg = "Error en el scanner en la línea: " + line + ", columna: " + charPositionInLine + "\n" +
                    "El símbolo: " + offendingSymbol.Text + " no es un token válido!!!\n\n";
            else if (e is FailedPredicateException)
                msg = "Error en el parser en la línea: " + line + ", columna: " + charPositionInLine + "\n" +
                    "La semántica de la expresión es inválida!!!";
            else if (e is InputMismatchException)
                msg = "Error en el parser en la línea: " + line + ", columna: " + charPositionInLine + "\n" +
                    "Se esperaba: TOKEN_ESPERADO " + /*AQUÍ TOKENS*/"" + " y en su lugar se encontró '" + offendingSymbol.Text + "'!!!\n\n";
            else
                msg = "Error general!!!\n\n";

        }
        else
            msg = "Error en el parser en la línea: " + line + ", columna: " + charPositionInLine + "\n" +
                msg + "\n\n"; //= "Error general!!!\n";*/
        
        Program.errores.Append(msg);
        Program.p.error.AppendText(Program.errores.ToString());
       //throw new ParserException();

    }
}
