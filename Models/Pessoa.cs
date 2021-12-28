using System;

namespace POO.Models
{
    public class Pessoa
    {
        public string Nome {get; set; }

        public int Idade {get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade}");
        }
    }
}