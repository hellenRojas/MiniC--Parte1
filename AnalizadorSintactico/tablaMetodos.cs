using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;


class TablaMetodos
{

    List<Object> t;

    public TablaMetodos()
    {
        t = new List<Object>();
    }



    public void insertar(String nombre, int tipo)
    {
        IToken token = new CommonToken(tipo, nombre);

        t.Add(token);
    }

    public IToken buscar(String nombre)
    {
        return (IToken)t.Find(item => ((IToken)item).Text.Equals(nombre));
    }

    public void imprimir()
    {
        for (int i = 0; i < t.Count; i++)
        {
            IToken s = (IToken)t.ElementAt(i);
            Console.WriteLine("Nombre: " + s.Text);
            if (s.Type == 0) Console.WriteLine("\tTipo: Indefinido");
            else if (s.Type == 1) Console.WriteLine("\tTipo: Integer\n");
            else if (s.Type == 2) Console.WriteLine("\tTipo: String\n");
        }
    }

}


