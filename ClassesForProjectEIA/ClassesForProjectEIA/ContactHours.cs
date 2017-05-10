using System;

namespace ClassesForProjectEIA
{
    class ContactHours
    {
        #region Constructors
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public ContactHours(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Holds the time for the first possible contact hour 
        /// </summary>
        DateTime From { get; set; }

        /// <summary>
        /// Holds the time for the last possible contact hour
        /// </summary>
        DateTime To { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns true if the contact is open
        /// </summary>
        /// <returns></returns>
        public bool IsOpen() => From < DateTime.Now && To > DateTime.Now;

        #endregion
    }
}
