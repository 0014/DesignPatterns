using System;
using System.IO;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter writer = new StringWriter();
            writer.WriteLine("Sending order UPS:");

            var order = new FedExOrderShipment { ShippingAddress = "20 Roosevelt Way, Landing, NJ 07850" };
            //OR
            //var order = new UpsOrderShipment { ShippingAddress = "20 Roosevelt Way, Landing, NJ 07850" };

            order.Ship(writer);

            Console.WriteLine(writer.ToString());
        }
    }
}
