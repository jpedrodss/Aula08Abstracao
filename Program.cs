using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDebito elo = new CartaoDebito();
            System.Console.WriteLine("O token será validado. Aguarde.");
            System.Console.WriteLine(elo.ValidarToken());

        }
    }
}
