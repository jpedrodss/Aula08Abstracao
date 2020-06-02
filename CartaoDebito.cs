namespace Aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }
        public float SaldoAtual(){
            return saldo = saldo - valor;
        }
        public string Transferir(float valor){
            return $"R${valor} transferido de sua conta.";
        }
        public string PagarTitulo(){
            return "Títulos pagos";
        }
    }
}