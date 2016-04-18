using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;


public class TablaClasesInternas
{
    public List<subTClase> tablaClases;


    public TablaClasesInternas()
    {
        tablaClases = new List<subTClase>();
    }

    public class subTClase { 
        public string nombre;
        public int nivel;
        public List<Elemento> listaVar;

         public subTClase(string nombre1,int nivel1) {
            nombre = nombre1;
            nivel = nivel1;
            listaVar = new List<Elemento>();

        }
    
    }

    public class Elemento
    {
        public IToken token;
        public int nivel;

        public Elemento(IToken token1,int nivel1) {
            token = token1;
            nivel = nivel1;
        }


    }

    public void insertarClase(String nombre, int nivel) {
        subTClase clase = new subTClase(nombre,nivel);
        tablaClases.Add(clase);
   
    }
    public void insertarVariable(String nombre, int tipo, int nivel)
    {
        subTClase claseTemp = (subTClase)tablaClases.Find(x => ((subTClase)x).nivel == nivel);
        IToken token = new CommonToken(tipo,nombre);
        Elemento e = new Elemento(token,nivel);
        claseTemp.listaVar.Add(e);
    }


    public Elemento buscarPNivel(String nombre,int nivel)
    {
        subTClase claseTemp = (subTClase)tablaClases.Find(x => ((subTClase)x).nivel == nivel);
        return (Elemento)claseTemp.listaVar.Find(x => ((Elemento)x).token.Text.Equals(nombre));
    }



}


