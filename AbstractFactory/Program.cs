using AbstractFactory.App;
using AbstractFactory.Factories;

public class Program
{
    static Application ConfigureApplication(string company)
    {
        switch (company.ToLower())
        {
            case "ninetyNine":
                return new Application(new NinetyNineTransport());
            case "lime":
                return new Application(new LimeTransport());
            case "uber":
            default:
                return new Application(new UberTransport());
        }
    }
    private static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Param usage: --uber | --ninetyNine | --lime");
            return;
        }

        ConfigureApplication(args[0]).StartRoute();
    }
}