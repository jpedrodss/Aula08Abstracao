using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDebito elo = new CartaoDebito();
            elo.valor = 550f;
            elo.saldo = 1050f;

            CartaoCredito visa = new CartaoCredito();
            visa.limite = 700f;

            do{
            System.Console.WriteLine("O token será validado. Aguarde...\n");
            System.Console.WriteLine(elo.ValidarToken());
            }while(elo.token == "");


            System.Console.WriteLine($"Seu saldo atual é de ${elo.saldo}");
            System.Console.WriteLine($"Você está prestes a realizar um pagamento no valor de ${elo.valor}.");
            System.Console.WriteLine("\nPor favor, digite a data de pagamento: ");
            elo.data = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine($"Data de pagamento: {elo.data}");
            System.Console.WriteLine($"\nSeu novo saldo é ${elo.SaldoAtual()}");

            System.Console.WriteLine($"\nLimite atual de ${visa.limite}.");
            System.Console.WriteLine($"Limite aumentado para ${visa.AumentarLimite(visa.limite, 500)}."); 

        }
    }
}
