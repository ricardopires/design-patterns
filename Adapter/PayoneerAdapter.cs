namespace Adapter
{
    public class PayoneerAdapter : IPayPalPayment
    {
        private Payoneer payoneer;

        public PayoneerAdapter(Payoneer payoneer)
        {
            this.payoneer = payoneer;
            Console.WriteLine("Adaptando de Payoneer para PayPal");
        }

        public Token AuthToken() => payoneer.AuthToken();

        public void PayPalPayment() => payoneer.SendPayment();

        public void PayPalReceive() => payoneer.ReceivePayment();
    }
}
