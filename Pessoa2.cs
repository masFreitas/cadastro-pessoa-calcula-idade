 using System;

namespace Exercicio2CadastraPessoa
{
    public class Pessoa2
    {
        public string Nome { get; set; }

        public string DataNascimento { get; set; }

        public int CalcIdade ()
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual, mesAtual, diaAtual;
            int anoNascimento, mesNascimento, diaNascimento;
            int idade = 0;

            anoNascimento = int.Parse(DataNascimento.Substring(6));
            mesNascimento = int.Parse(DataNascimento.Substring(3,2));
            diaNascimento = int.Parse(DataNascimento.Substring(0,2));
            
            anoAtual = dataAtual.Year;
            mesAtual = dataAtual.Month;
            diaAtual = dataAtual.Day;

            if (mesAtual < mesNascimento)
            {
                idade = anoAtual - anoNascimento - 1;
            }
            else if (mesAtual == mesNascimento && diaAtual >= diaNascimento)
            {
                idade = anoAtual - anoNascimento;
            }
            else if (mesAtual == mesNascimento && diaAtual < diaNascimento)
            {
                idade = anoAtual - anoNascimento - 1;
            }
            else if (mesAtual > mesNascimento)
            {
                idade = anoAtual - anoNascimento;
            }

            return idade;
        }
          
    }
}