using POO_CSharp_P11.Entities;
using POO_CSharp_P11.Entities.Enums;

namespace POO_CSharp_P11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Enumerações: ");
            Console.WriteLine();
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);
            Console.WriteLine("string - enum:");
            string txt = OrderStatus.PedingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 
            
            Console.WriteLine(txt);
            Console.WriteLine(os);
            

        }
    }
}