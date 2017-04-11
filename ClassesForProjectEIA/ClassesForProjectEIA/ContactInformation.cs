using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    public class ContactInformation
    {
        public int WorkNumber { get; private set; }
        public int LandLineNumber { get; private set; }
        public int MobileNumber { get; private set; }
        public string Email { get; private set; }

        public ContactInformation(int mobileNumber, string email)
            : this( mobileNumber, email, 0, 0) { }

        public ContactInformation(int mobileNumber, string email, int workNumber, int landLineNumber)
        {
            MobileNumber = mobileNumber;
            Email = email;
            WorkNumber = workNumber;
            LandLineNumber = landLineNumber;  
        }
    }
}
