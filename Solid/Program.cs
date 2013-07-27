using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            Console.WriteLine("Laptop price is " + laptop.Price);

            ExternalMic laptopWithMic = new ExternalMic(laptop);
            Console.WriteLine("External Mic price is " + laptopWithMic.Price);

            Ssd laptopWithMicAndSsd = new Ssd(laptopWithMic);
            Console.WriteLine("External Mic price is " + laptopWithMicAndSsd.Price);
            Console.ReadLine();
        }
    }
}
