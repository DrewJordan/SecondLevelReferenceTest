using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLevel;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var primary = new FirstLevel.FirstLevel();
            primary.reference.DoSomething();
        }
    }
}
