using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework_22._02._2023
{
    internal class receipt
    {
        public receipt() { }
        public void Print(int sum)
        {
            Console.WriteLine($"Issuance amount: {sum} grivnas");
        }
        public void NoPrint()
        {
            Console.WriteLine("no receipt");
        }
    }
}