namespace Adapter
{
    public class PayPal : IPayPalPayment
    {
        private Token token;
        public Token AuthToken() => new Token();

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
