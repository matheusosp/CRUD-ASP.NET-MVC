using Humanizer;
using System;

namespace DiferençaDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 4, 3);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = TimeSpan.FromMinutes(40);
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
        }
    }
}
