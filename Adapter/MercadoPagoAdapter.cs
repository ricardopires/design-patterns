namespace Adapter
{
    public class MercadoPagoAdapter : IPayPalPayment
    {
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Adaptando de MercadoPago para PayPal");
        }

        public MercadoPago mercadoPago { get; }

        public Token AuthToken() => mercadoPago.GenerateAuthToken();

        public void PayPalPayment() => mercadoPago.Pay();

        public void PayPalReceive() => mercadoPago.Receive();
    }
}
