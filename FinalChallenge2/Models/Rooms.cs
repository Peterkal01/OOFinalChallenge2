using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalChallenge2.Models
{
    public class Rooms
    {
        public string Building { get; set; }
        public int  RoomNo { get; set; }
        public int Capacity { get; set; }
        

        public Rooms (string rBuilding, int rRoomNo, int rCapacity)
        {
            Building = rBuilding;
            RoomNo = rRoomNo;
            Capacity = rCapacity;
        }
    }
}