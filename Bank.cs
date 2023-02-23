using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework_22._02._2023
{
    internal class Bank : receipt
    {
        private int sum;

        public Bank() { }
        public Bank(int pin, int sum)
        {
            this.sum = sum;
        }

        public void EnterSum(int sum)
        {
            Console.WriteLine($"Amount processed...\nIssuance amount: {sum} grivnas");
        }
    }
}