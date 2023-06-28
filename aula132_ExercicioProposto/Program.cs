using aula132_ExercicioProposto.Entities;
using aula132_ExercicioProposto.Entities.Enums;
using System.Globalization;

namespace Aula132
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Console.WriteLine("--Welcome to Store x --");

            //CLient
            Console.Write("Type the client identify: ");
            string identify = Console.ReadLine();
            Client client = new Client(identify, "Franklin CLinton");
            Console.WriteLine();
            Console.WriteLine("Account\n" + client);

            Console.WriteLine();

            //Order
            Console.Write("Type how many products your client want to buy: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product {i}");
                Console.Write("Product's name: ");
                Products pname = Enum.Parse<Products>(Console.ReadLine());
                Console.Write("Quantity: ");
                int qt = int.Parse(Console.ReadLine());
                Console.Write("Price: ");
                double pc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                OrderItem list = new OrderItem(pname, qt, pc);

                order.AddItem(list);
            }

            

            Console.WriteLine();

            //OrderResume
            Console.WriteLine($"Name: {client.Name}");
            Console.WriteLine(order);
            Console.WriteLine($"Velue of the order: ${order.Total()}");
        }
    }
}