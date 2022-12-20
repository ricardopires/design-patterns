namespace Adapter
{
    public class MercadoPago : IMercadoPagoPayment
    {
        private object token;

        public Token GenerateAuthToken() => new Token();

        public bool Pay()
        {
            token = GenerateAuthToken();
            Console.WriteLine("Enviando pagamento com MercadoPago");
            return true;
        }

        public bool Receive()
        {
            Console.WriteLine("Recebendo pagamento com MercadoPago");
            return true;
        }
    }
}
