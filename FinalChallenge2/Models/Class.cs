using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalChallenge2.Models
{
    public class Class
    {
        public string ClassCode { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public int RoomNo { get; set; }

        public Class (string clClassCode, string clName, string rBuilding, int rRoomNo)
        {
            ClassCode = clClassCode;
            Name = clName;
            Building = rBuilding;
            RoomNo = rRoomNo;

        }

        public Class()
        {
        }
    }
}