using System;

namespace ClassesForProjectEIA
{
    public class ContactInformation
    {
        #region Private Members

        /// <summary>
        /// Backing field for the work number
        /// </summary>
        private int _workNumber;
        /// <summary>
        /// Backing field for the Landline number
        /// </summary>
        private int _landLineNumber;
        /// <summary>
        /// Backing field for the mobile phone number
        /// </summary>
        private int _mobilNumber;
        /// <summary>
        /// Backing field for the email
        /// </summary>
        public string _eMail;

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

        #region Public Properties
        /// <summary>
        /// Holds the telephone number for work
        /// </summary>
        public int WorkNumber
        {
            get { return _workNumber; }
            private set
            {
                if (value >= 10000000 && value <= 99999999)
                    _workNumber = value;
                else
                    throw new ArgumentOutOfRangeException();              
            }
        }

        /// <summary>
        /// Holds the landline telephone number
        /// </summary>
        public int LandLineNumber
        {
            get { return _landLineNumber; }
            private set
            {
                if (value >= 10000000 && value <= 99999999)
                    _landLineNumber = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Holds the mobile telephone number
        /// </summary>
        public int MobileNumber
        {
            get { return _mobilNumber; }
            private set
            {
                if (value >= 10000000 && value <= 99999999)
                    _mobilNumber = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Holds the E-mail address
        /// </summary>
        public string Email
        {
            get { return _eMail; }
            private set
            {
                if (value.Contains("@"))
                    _eMail = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion
    }
}
