using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Payoneer : IPayoneerPayment
    {
        private Token token;

        public Token AuthToken() => new Token();

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Payoneer");
        }

        public void SendPayment()
        {
            Console.WriteLine("Enviando pagamento com Payoneer");
        }
    }
}
