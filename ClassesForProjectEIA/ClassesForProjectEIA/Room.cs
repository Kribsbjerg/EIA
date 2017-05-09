using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Room
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="roomNumber"></param>
        public Room(string roomNumber)
        {
            RoomNumber = roomNumber;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Holds the room number
        /// </summary>
        public string RoomNumber { get; set; }

        #endregion
    }
}
