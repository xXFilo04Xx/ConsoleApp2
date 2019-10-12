using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("inserisci il carattere");
            a = Console.ReadLine();
            foreach (char c in a)
            {
                Console.WriteLine((int)c);
            }
            Console.ReadLine();
        }
    }
}
