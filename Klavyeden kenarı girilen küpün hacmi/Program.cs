using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_kenarı_girilen_küpün_hacmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Formül : a*a*a

            Console.WriteLine("Küpün bir kenarını girin");
            int a = Int32.Parse(Console.ReadLine());

            int hacim = a * a * a;

            Console.WriteLine("Küpün hacmi =" + hacim);
            Console.ReadLine();

        }
    }
}
