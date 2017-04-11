using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    public class ContactInformation
    {
        #region Properties
        /// <summary>
        /// Holds the telephone number for work
        /// </summary>
        public int WorkNumber { get; private set; }

        /// <summary>
        /// Holds the landline telephone number
        /// </summary>
        public int LandLineNumber { get; private set; }

        /// <summary>
        /// Holds the mobile telephone number
        /// </summary>
        public int MobileNumber { get; private set; }
        
        /// <summary>
        /// Holds the E-mail address
        /// </summary>
        public string Email { get; private set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <param name="email"></param>
        public ContactInformation(int mobileNumber, string email)
            : this( mobileNumber, email, 0, 0) { }

        /// <summary>
        /// Extending Constructor
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <param name="email"></param>
        /// <param name="workNumber"></param>
        /// <param name="landLineNumber"></param>
        public ContactInformation(int mobileNumber, string email, int workNumber, int landLineNumber)
        {
            MobileNumber = mobileNumber;
            Email = email;
            WorkNumber = workNumber;
            LandLineNumber = landLineNumber;  
        }
        #endregion
    }
}
