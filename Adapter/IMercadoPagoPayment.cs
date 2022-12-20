namespace Adapter
{
    public interface IMercadoPagoPayment
    {
        Token GenerateAuthToken();
        bool Pay();
        bool Receive();
    }
}
