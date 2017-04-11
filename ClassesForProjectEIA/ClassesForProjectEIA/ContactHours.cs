using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class ContactHours
    {
        DateTime From { get; set; }
        DateTime To { get; set; }

        public ContactHours(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }
    }
}
