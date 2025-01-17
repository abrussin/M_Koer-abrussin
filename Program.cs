
namespace M_Koer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matemaatiline koer");


            Console.WriteLine("Sisestage esimene arv: ");
            double arv1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisestage teine arv: ");
            double arv2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisestage ´tehe (+, -, *, /): ");
            char tehe = Console.ReadLine()[0];

            double tulemus = 0;
            switch (tehe)
            {
                case '+':
                    tulemus = arv1 + arv2;
                    break;
                case '-':
                    tulemus = arv1 - arv2;
                    break;
                case '*':
                    tulemus = arv1 * arv2;
                    break;
                case '/':
                    if (arv2 != 0)
                    {
                        tulemus = arv1 / arv2;
                    }
                    else
                    {
                        Console.WriteLine("Jagamine nulliga pole voimalik");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Tundmatu tehe!");
                    return;
            }
            Console.WriteLine("Tulemus: " + tulemus);
        }
    }
}



