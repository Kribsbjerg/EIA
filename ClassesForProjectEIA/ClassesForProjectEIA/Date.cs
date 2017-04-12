using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Date
    {
        DateTime date1 = new DateTime(int year, int month, int day, int time, int minute);
        public DateTime Date { get; set; }
        Console.WriteLine(date1.ToString("f", 
                        CultureInfo.CreateSpecificCulture("da-DK")));


        {
            
        }
    }

}
