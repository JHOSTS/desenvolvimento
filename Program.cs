using System;
using POO.Models;

namespace POO
{
    class Program
    {
        static void Main(string[]args)
        {
            Professor p1 = new Professor();
            p1.Salario = 5000;
            p1.Nome = "Antônio Carlos";
            p1.Idade = 18;
            p1.Documento = "5844569554"

            p1.Apresentar();

            Console.WriteLine($"Salário: {p1.Salario}");










            //Valores Válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 20);

            // Console.WriteLine($"Área: {r.ObterArea()}");
            
            
            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, -1);

            // Console.WriteLine($"Área: {r2.ObterArea()}");
            
            
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 25;

            // p1.Apresentar();
        }
    }
}
