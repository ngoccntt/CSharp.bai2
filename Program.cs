using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten cua ban: ");
            string ten = Console.ReadLine();
            Console.Write("Hello {0}!",ten);
            Console.ReadKey();
        }
    }
}
