using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReferringAuthority r = new ReferringAuthority();

            int bd = 170990;

            DateTime d = new DateTime((bd % 100) + 1900, (bd / 100) % 100, (bd / 100000));

            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
