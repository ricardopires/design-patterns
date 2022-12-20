using Adapter;

PayPal ppPayment = new PayPal();
Payoneer pPayment = new Payoneer();
MercadoPago mpPayment = new MercadoPago();

IPayPalPayment payment = new MercadoPagoAdapter(mpPayment);

payment.PayPalPayment();
payment.PayPalReceive();

Console.ReadLine();