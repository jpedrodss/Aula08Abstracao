namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        public string token = "gg56fds415g6df489s4g896a6fdsa156456456fdsa132";
        public string bandeira { get; set; }
        public string titular { get; set; }
        public float numeroCartao { get; set; }
        public string cvv { get; set; }
        
        public bool ValidarToken(){
            if(token != null && token != ""){
                return true;
            }
            return false;
        }
    }
}