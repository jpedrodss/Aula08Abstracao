namespace Aula08Abstracao
{
    public class Boleto : Pagamento
    {
        public string dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codBarras { get; set; }
        public string RegistrarNoSistema(){
            return "Boleto registrado no Sistema";
        }
    }
}