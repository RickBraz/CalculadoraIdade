using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("descubra a quantos dias vc esta vivo");
            Console.Write("digite o ano de seu nascimento: ");
            string ano = Console.ReadLine();
            Console.Write("digite o mês de seu nascimento: ");
            string mês = Console.ReadLine();
            Console.Write("digite o dia de seu nascimento: ");
            string dia = Console.ReadLine();

            int x = Convert.ToInt32(ano);
            int y = Convert.ToInt32(mês);
            int z = Convert.ToInt32(dia);

            DateTime DataAtual = DateTime.Now;
            DateTime diaDomeuNascimento = new DateTime(x, y, z);

            TimeSpan intervaloVivido = DataAtual - diaDomeuNascimento;

            string dataCurta = diaDomeuNascimento.ToShortDateString();
            int intervaloEmDias = intervaloVivido.Days;
            Console.WriteLine($"Eu nasci em {diaDomeuNascimento} e ja vivi {intervaloEmDias} dias");
        }
    }
}
