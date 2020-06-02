using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDebito elo = new CartaoDebito();
            elo.valor = 550;
            elo.saldo = 1050;

            do{
            System.Console.WriteLine("O token será validado. Aguarde...");
            System.Console.WriteLine(elo.ValidarToken());
            }while(elo.token == "");

            System.Console.WriteLine($"Seu saldo atual é de ${elo.saldo}");
            System.Console.WriteLine($"Você está prestes a realizar um pagamento no valor de ${elo.valor}.");


        }
    }
}
