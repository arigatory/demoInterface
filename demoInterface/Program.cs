using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = new[] {1, 2, 4, 6, 57, 4, 2};
            Array.Sort(arrInt);

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }


            Complex[] arrComp = new Complex[]
            {
                new Complex(122, 2),
                new Complex(2, 2),
                new Complex(3, 2),
                new Complex(2, 2),
                new Complex(12, 2),
                new Complex(22, 2),
            };
            Array.Sort(arrComp);
            for (int i = 0; i < arrComp.Length; i++)
            {
                Console.WriteLine(arrComp[i]);
            }


            Console.ReadLine();
        }
    }
}
