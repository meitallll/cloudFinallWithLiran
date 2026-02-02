using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cloudFinal.Models
{
    public class Hotel
    {
        public string id { get; set; }              // מזהה ייחודי
        public string HotelName { get; set; }        // שם המלון
        public double Stars { get; set; }               
        public bool HasPool { get; set; }
       
        public Room[] Rooms { get; set; }             // חדרים
        public Employee[] Employees { get; set; }
        public static List<Hotel> ConvertStringIntoList(string hotelsAsList)
        {
            if (hotelsAsList == null || hotelsAsList == "") return new List<Hotel>();
            return JsonSerializer.Deserialize<List<Hotel>>(hotelsAsList);
        }

        public override string ToString()
        {
            string hotelDataStr = string.Empty;

            hotelDataStr += " Hotel #" + id;

            hotelDataStr += (string.IsNullOrEmpty(HotelName))
                ? "\nNo hotel name documented at the moment"
                : "\nHotel name is: " + HotelName;

           
            hotelDataStr += (Stars == 0)
                ? "\nNo stars documented at the moment"
                : "\nStars: " + Stars;

            
            hotelDataStr += "\nHas pool: " + HasPool;

            
            int roomsCounter = 0;
            string roomsInfo = string.Empty;

            if (Rooms != null && Rooms.Length > 0)
            {
                for (int i = 0; i < Rooms.Length; i++)
                {
                    if (Rooms[i] != null)
                    {
                        roomsCounter++;
                        roomsInfo += Rooms[i].ToString();
                    }
                }
            }

            hotelDataStr += (roomsCounter == 0)
                ? "\nNo rooms are documented at the moment"
                : $"\n{roomsCounter} rooms are documented: {roomsInfo}";

            
            int empCounter = 0;
            string empInfo = string.Empty;

            if (Employees != null && Employees.Length > 0)
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i] != null)
                    {
                        empCounter++;
                        empInfo += Employees[i].ToString();
                    }
                }
            }

            hotelDataStr += (empCounter == 0)
                ? "\nNo employees are documented at the moment"
                : $"\n{empCounter} employees are documented: {empInfo}";

            return hotelDataStr;
        }
    }
}
