using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using AnalizadorSintactico;
using System.Windows.Forms;

class PrettyPrint : Parser1BaseVisitor<Object>
{

    //private var for tree
    private TreeView treeview;

    public PrettyPrint(TreeView tree)
    {
        this.treeview = tree;
    }
   
	public virtual object VisitClassDeclAST([NotNull] Parser1.ClassDeclASTContext context) {
        TreeNode clase = new TreeNode(context.CLASE().ToString());
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode CD = new TreeNode(context.COR_DER().ToString());
        TreeNode CI = new TreeNode(context.COR_IZQ().ToString());
        int largo = 4 + context.varDecl().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = clase;
        arreglo[1] = ident;
        arreglo[2] = CD;
        int cont = 3;
        for (int i = 0; i <= context.varDecl().Count(); i++)
        {
            TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
            arreglo[cont] = vardecl;
            cont++;
        }
        arreglo[cont] = CI;
        TreeNode final = new TreeNode("ClassDecl", arreglo);
            return final; 
    }

	
    public virtual object VisitCondTermAST([NotNull] Parser1.CondTermASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitConstDeclAST([NotNull] Parser1.ConstDeclASTContext context) { 
        TreeNode constante = new TreeNode(context.CONSTANTE().ToString());
        TreeNode type = (TreeNode)Visit(context.type());
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode asign = new TreeNode(context.ASIGN().ToString());
        TreeNode[] arreglo = new TreeNode[4];
        arreglo[0] = constante;
        arreglo[1] = type;
        arreglo[2] = ident;
        arreglo[3] = asign;

        int cont = 4;

        if (context.NUMBER() != null)
        {
            TreeNode number = new TreeNode(context.NUMBER().ToString());
            arreglo[cont] = number;
            cont++;
        }
        else if (context.CharConst() != null)
        {
            TreeNode charconst = new TreeNode(context.CharConst().ToString());
            arreglo[cont] = charconst;
            cont++;
        }
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        arreglo[cont] = pycoma;
        TreeNode final = new TreeNode("ConstDecl", arreglo);
        return final;
    }

	
    public virtual object VisitProgramAST([NotNull] Parser1.ProgramASTContext context) {
        TreeNode Clase = new TreeNode(context.CLASE().ToString());
        TreeNode Ident = new TreeNode(context.IDENT().ToString());
        TreeNode CD = new TreeNode(context.COR_DER().ToString());
        TreeNode CI = new TreeNode(context.COR_IZQ().ToString());

        int largo = 4;
        //estimar el tamaño del arreglo a usar conociendo si vienen datos en dichas variables o no
        if (context.constDecl()!=null){largo++;}
        else if (context.varDecl() != null){largo++;}
        else if (context.classDecl() != null) { largo++;}
        
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = Clase;
        arreglo[1] = Ident;
        int cont = 2;//estado actual de posición del arreglo

        //recorrer las variables en un ciclo porque se ejecutan una o más veces
        if (context.constDecl() != null) {
            for (int i = 0; i <= context.constDecl().Count(); i++)
            {
                arreglo[cont] = (TreeNode)Visit(context.constDecl(i));
                cont++;
            }
        }
        else if (context.varDecl() != null) {
            for (int i = 0; i <= context.varDecl().Count(); i++)
            {
                arreglo[cont] = (TreeNode)Visit(context.varDecl(i));
                cont++;
            }
        }
        else if (context.classDecl() != null) {
            for (int i = 0; i <= context.classDecl().Count(); i++)
            {
                arreglo[cont] = (TreeNode)Visit(context.classDecl(i));
                cont++;
            }
        }

        arreglo[cont] = CD; //lave derecha
        for (int i = 0; i <= context.methodDecl().Count(); i++)
        {
            arreglo[cont] = (TreeNode)Visit(context.methodDecl(i));
            cont++;
        }
        arreglo[cont] = CI;
        TreeNode final = new TreeNode("Program", arreglo);
        treeview.Nodes.Add(final);
        return final; //en caso de ERROR cambiar a null
    }

	
    public virtual object VisitMethodDeclAST([NotNull] Parser1.MethodDeclASTContext context) {
        int largo = 0;
        if (context.type() != null) { largo++; }
        if (context.varDecl() != null) { largo++; }
        TreeNode voids = new TreeNode(context.VOID().ToString());
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode block = new TreeNode(context.block().ToString());
        TreeNode[] arreglo;
        if (context.formPars() != null) //verificar si viene o no algo en el form pars
        {
            largo = 6 + context.varDecl().Count();
            arreglo = new TreeNode[largo];
            if (context.type() != null) //comprobar su viene un type, sino es void
            {
                TreeNode type = (TreeNode)Visit(context.type());
                TreeNode formpars = (TreeNode)Visit(context.formPars());
                arreglo[0] = type;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = formpars;
                arreglo[4] = PD;
                int count = 5;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
            else
            {
                TreeNode formpars = (TreeNode)Visit(context.formPars());
                arreglo[0] = voids;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = formpars;
                arreglo[4] = PD;
                int count = 5;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
        }
        else
        {
            largo = 6 + context.varDecl().Count();
            arreglo = new TreeNode[largo];
            if (context.type() != null)
            {
                TreeNode type = (TreeNode)Visit(context.type());
                arreglo[0] = type;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = PD;
                int count = 4;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
            else
            {
                arreglo[0] = voids;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = PD;
                int count = 4;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
        }
        TreeNode final = new TreeNode("MethodDecl", arreglo);
        return arreglo;
    }

	
    public virtual object VisitTypeAST([NotNull] Parser1.TypeASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitFormParsAST([NotNull] Parser1.FormParsASTContext context) {
        TreeNode type1 = (TreeNode)Visit(context.type(0));
        TreeNode ident1 = new TreeNode(context.IDENT(0).ToString());
        int largo = 2 + context.COMA().Count() + context.type().Count() + context.IDENT().Count();
        TreeNode[] arreglo = new TreeNode[largo];


        return VisitChildren(context); 
    }

	
    public virtual object VisitActParsAST([NotNull] Parser1.ActParsASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitDesignatorAST([NotNull] Parser1.DesignatorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondFactAST([NotNull] Parser1.CondFactASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitConditionAST([NotNull] Parser1.ConditionASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitReadStatAST([NotNull] Parser1.ReadStatASTContext context) { return VisitChildren(context); }


    public virtual object VisitReturnStatAST([NotNull] Parser1.ReturnStatASTContext context) { return VisitChildren(context); }


    public virtual object VisitPyStatAST([NotNull] Parser1.PyStatASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitWhileStatAST([NotNull] Parser1.WhileStatASTContext context) { return VisitChildren(context); }


    public virtual object VisitWriteStatAST([NotNull] Parser1.WriteStatASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitForeachStatAST([NotNull] Parser1.ForeachStatASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitDesignatorStatAST([NotNull] Parser1.DesignatorStatASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitIfStatAST([NotNull] Parser1.IfStatASTContext context) { return VisitChildren(context); }


    public virtual object VisitForStatAST([NotNull] Parser1.ForStatASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitBlockStatAST([NotNull] Parser1.BlockStatASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitBreakStatAST([NotNull] Parser1.BreakStatASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitBlockAST([NotNull] Parser1.BlockASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitExprAST([NotNull] Parser1.ExprASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitTermAST([NotNull] Parser1.TermASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitExprFactorAST([NotNull] Parser1.ExprFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitTruefalseFactorAST([NotNull] Parser1.TruefalseFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitNewFactorAST([NotNull] Parser1.NewFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitDesignatorFactorAST([NotNull] Parser1.DesignatorFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitNumberFactorAST([NotNull] Parser1.NumberFactorASTContext context) { return VisitChildren(context); }


    public virtual object VisitCharconstFactorAST([NotNull] Parser1.CharconstFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitVarDeclAST([NotNull] Parser1.VarDeclASTContext context) {
        TreeNode type = (TreeNode)Visit(context.type());
        TreeNode ident = new TreeNode(context.IDENT(0).ToString());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        int largo = 3+context.IDENT().Count() + context.COMA().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = type;
        arreglo[1] = ident;
        int cont = 2;
        int i2 = 0;
        for (int i = 1; i <= context.IDENT().Count(); i++)
        {
            TreeNode coma = new TreeNode(context.COMA(i2).ToString());
            TreeNode ident2 = new TreeNode(context.IDENT(i).ToString());
            arreglo[cont] = coma;
            arreglo[cont + 1] = ident2;
            cont++;
            i2++;
        }
        arreglo[cont] = pycoma;
        TreeNode final = new TreeNode("varDecl", arreglo);
        return final;
    }

	
    public virtual object VisitProgram([NotNull] Parser1.ProgramContext context) { return VisitChildren(context); }

	
    public virtual object VisitConstDecl([NotNull] Parser1.ConstDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitVarDecl([NotNull] Parser1.VarDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitClassDecl([NotNull] Parser1.ClassDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitMethodDecl([NotNull] Parser1.MethodDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitFormPars([NotNull] Parser1.FormParsContext context) { return VisitChildren(context); }

	
    public virtual object VisitType([NotNull] Parser1.TypeContext context) { return VisitChildren(context); }

	
    public virtual object VisitStatement([NotNull] Parser1.StatementContext context) { return VisitChildren(context); }

	
    public virtual object VisitBlock([NotNull] Parser1.BlockContext context) { return VisitChildren(context); }

	
    public virtual object VisitActPars([NotNull] Parser1.ActParsContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondition([NotNull] Parser1.ConditionContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondTerm([NotNull] Parser1.CondTermContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondFact([NotNull] Parser1.CondFactContext context) { return VisitChildren(context); }

	
    public virtual object VisitExpr([NotNull] Parser1.ExprContext context) { return VisitChildren(context); }

	
    public virtual object VisitTerm([NotNull] Parser1.TermContext context) { return VisitChildren(context); }

	
    public virtual object VisitFactor([NotNull] Parser1.FactorContext context) { return VisitChildren(context); }

	
    public virtual object VisitDesignator([NotNull] Parser1.DesignatorContext context) { return VisitChildren(context); }

	
    public virtual object VisitRelop([NotNull] Parser1.RelopContext context) { return VisitChildren(context); }

	
    public virtual object VisitAddop([NotNull] Parser1.AddopContext context) { return VisitChildren(context); }

	
    public virtual object VisitMulop([NotNull] Parser1.MulopContext context) { return VisitChildren(context); }


}