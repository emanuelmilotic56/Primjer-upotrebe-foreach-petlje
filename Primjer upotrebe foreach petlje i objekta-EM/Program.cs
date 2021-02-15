using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer_upotrebe_foreach_petlje_i_objekta_EM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();

            while (true)
            {
                Console.Write("Unesite cijeli broj:");
                int broj = int.Parse(Console.ReadLine());

                if (broj == 0)
                {
                    break;
                }

                brojevi.Add(broj);
            }
            brojevi.Sort();
            brojevi.Reverse();


            Console.WriteLine("Uneseni brojevi pad.redoslijedom:");
            foreach (int broj in brojevi)
            {
                Console.Write(broj + ", ");
            }
            Console.ReadKey();

        }
    }
}
