using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Converter
    {
        int Saldo { get; set; } = 500;
        public int Debit(int balance)
        {
            return balance - 250;
        }

        public int Credit(int balance)
        {
            return balance + 500;
          
        }

        public int CheckSaldo(int balance)
        {
            return balance;
        }
    }
}
