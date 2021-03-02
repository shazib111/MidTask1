using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTask
{
    class Start
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            b1.BankName = " Black & White";
            Console.WriteLine("Welcome To {0} Bank...", b1.BankName);
        }
    }
}