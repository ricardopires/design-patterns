using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("Param usage: --uber | --log | --eats");
                return;
            }

            Transport transport = null;
        
            switch (args[0])
            {
                case "--uber":
                    transport = new CarTransport();
                    break;
                case "--log":
                    transport = new MotorcycleTransport();
                    break;
                case "--eats":
                    transport = new MotorcycleTransport();
                    break;
                default:
                    Console.WriteLine("Param usage: --uber | --log | --eats");
                    break;
            }
            
            if (transport != null) 
                transport.StartTransport();

            Console.ReadLine();
        }
    }
}