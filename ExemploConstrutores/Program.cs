using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[]args)
        {
           Matematica m = new Matematica(10, 20);
           m.Somar();
        }
    }
}

//Operacao op = Calculadora.Somar;
           //Operacao op = new Operacao(Calculadora.Somar);
           //op += Calculadora.Subtrair;

           //op.Invoke(10, 10);
           //op(10,10);

// const double pi = 3.14;
//            System.Console.WriteLine(pi);


//Data data = new Data();
           //data.SetMes(2);
           //data.Mes = 2;
           //System.Console.WriteLine(data.Mes);
           //data.ApresentaMes();

 // Aluno p1 = new Aluno("Lucas", "Rafael", "Teste");
            // p1.Apresentar();

// Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste instância";
            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            
            //Pessoa p1 = new Pessoa("Lucas", "Rafael");
            //p1.Apresentar();