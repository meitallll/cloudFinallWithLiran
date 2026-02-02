using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloudFinal.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }      
        public int PricePerNight { get; set; }
        public int Rating { get; set; }
        public override string ToString()
        {
            string roomDataStr = string.Empty;

            roomDataStr += "\n\n[Room]";
            roomDataStr += "\nRoom number: " + RoomNumber;

            if (string.IsNullOrEmpty(RoomType))
                roomDataStr += "\nThere is no room type documented at the moment.";
            else
                roomDataStr += "\nRoom type: " + RoomType;

            if (PricePerNight == 0)
                roomDataStr += "\nThere is no price per night documented at the moment.";
            else
                roomDataStr += "\nPrice per night: " + PricePerNight;

            if (Rating == 0)
                roomDataStr += "\nThere is no room rating documented at the moment.";
            else
                roomDataStr += "\nRoom rating: " + Rating;

            return roomDataStr;
        }

    }
}
