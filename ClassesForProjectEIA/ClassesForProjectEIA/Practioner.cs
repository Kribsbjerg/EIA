using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Practitioner : Person
    {
        public Practitioner(string name, ContactInformation contact, AddressInformation address) 
            : base(name, contact, address) { }

        //Preferences and expertise of practitioners - Missing?
    }
}
