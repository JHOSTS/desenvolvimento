using System;

namespace POO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou um aluno nota {Nota} e tenho {Idade} anos.");
        }
    }
}