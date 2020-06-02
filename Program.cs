﻿using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDebito elo = new CartaoDebito();
            elo.valor = 550;
            elo.saldo = 1050;

            CartaoCredito visa = new CartaoCredito();
            visa.limite = 700;

            do{
            System.Console.WriteLine("O token será validado. Aguarde...\n");
            System.Console.WriteLine(elo.ValidarToken());
            }while(elo.token == "");

            System.Console.WriteLine($"Seu saldo atual é de ${elo.saldo}");
            System.Console.WriteLine($"Você está prestes a realizar um pagamento no valor de ${elo.valor}.");
            System.Console.WriteLine($"\nSeu novo saldo é {elo.Pagar(1050, 550)}");

            System.Console.WriteLine($"\nLimite atual de ${visa.limite}.");
            System.Console.WriteLine($"Limite aumentado para ${visa.AumentarLimite(visa.limite, 500)}."); 

        }
    }
}
