using System;
using POO.Models;

namespace POO
{
    class Program
    {
        static void Main(string[]args)
        {
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());






//********************************************************************//

            // Corrente c = new Corrente();
            // c.Creditar(1000);

            // c.ExibirSaldo();


//********************************************************************//

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(5, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(5, 10, 7));







//********************************************************************//

            // Aluno p1 = new Aluno();
            // p1.Nota = 8;
            // p1.Nome = "Antônio Carlos";
            // p1.Idade = 18;

            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Salario = 8000;
            // p2.Nome = "Márcio";
            // p2.Idade = 38;

            // p2.Apresentar();

//********************************************************************//


            //Valores Válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 20);

            // Console.WriteLine($"Área: {r.ObterArea()}");
            
            
            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, -1);

            // Console.WriteLine($"Área: {r2.ObterArea()}");
            
//********************************************************************//           
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 25;

            // p1.Apresentar();
        }
    }
}
