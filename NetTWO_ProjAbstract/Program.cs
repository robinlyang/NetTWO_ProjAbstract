using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTWO_ProjAbstract
{
    abstract class sales
    {
        abstract public void show_sales();
        public double taxgst(double x)
        {
            return x * 0.05;
        }
    }
    class invoice : sales
    {
        public double amount = 0;
        public override void show_sales()
        {//you put in code
            Console.WriteLine(amount.ToString("c"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //sales x = new sales();   <- this won't work
            invoice i = new invoice();
            i.show_sales();
            
        }
    }
}
