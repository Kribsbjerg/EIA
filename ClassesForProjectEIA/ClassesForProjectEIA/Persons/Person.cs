using System;

namespace ClassesForProjectEIA
{
    public class Person
    {
        #region Private Members

        private string _name;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="address"></param>
        public Person(string name, ContactInformation contact, AddressInformation address)
        {
            Name = name;
            Contact = contact;
            Address = address;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Holds the name of the person
        /// </summary>
        public string Name
        {
            get { return _name; }
            private set {
                if (value != null)
                    _name = value;
                else
                    throw new NullReferenceException();
            } 
        }

        /// <summary>
        /// Holds the contact information of the person
        /// </summary>
        public ContactInformation Contact { get; private set; }

        /// <summary>
        /// Holds the address information of the person
        /// </summary>
        public AddressInformation Address { get; private set; }

        #endregion
    }
}
