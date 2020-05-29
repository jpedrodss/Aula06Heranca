using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF pessoa = new CPF();
            pessoa.nome = "João";
            pessoa.rg = "52.270.623-X";
            pessoa.cpf = "528.891.318-82";
            Console.WriteLine(pessoa.Saudar());
            Console.WriteLine(pessoa.ValidarCPF());

        }
    }
}
