using System;

namespace Exercicio2CadastraPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa2[] pess = new Pessoa2[5];

            for (int i = 0; i < pess.Length; i++)
            {
                pess[i] = new Pessoa2();
                Console.WriteLine("Informe o nome: ");
                pess[i].Nome = Console.ReadLine();
                Console.WriteLine("Informe sua data de nascimento (ex: 27/10/1998): ");
                pess[i].DataNascimento = Console.ReadLine();

            }

           for (int i = 0; i < pess.Length; i++)
           {
               Console.WriteLine("{0} você tem {1} anos.", pess[i].Nome, pess[i].CalcIdade());
           }


        }
    }
}
