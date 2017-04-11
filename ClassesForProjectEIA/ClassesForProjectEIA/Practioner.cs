using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Practitioner : Person
    {
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="address"></param>

        
        public Practitioner(string name, ContactInformation contact, AddressInformation address) 
            : base(name, contact, address) { }

        //Preferences and expertise of practitioners - Missing?

        #endregion
    }
}
