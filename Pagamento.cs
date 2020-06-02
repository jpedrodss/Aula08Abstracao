using System;

namespace Aula08Abstracao
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }
        public float Pagar(float saldo, float valor){
            return saldo - valor;
        }
    }
}