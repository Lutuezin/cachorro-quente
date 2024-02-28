using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cachorro_quente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float h, p;
            h = float.Parse(Console.ReadLine());
            p = float.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0:C2}", (h / p)));
            Console.ReadKey();
        }
        
    }
}
