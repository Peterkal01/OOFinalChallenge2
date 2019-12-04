using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalChallenge2.Models
{
    public class Computer
    {
        public int Number { get; set; }
        public int AssembledYear { get; set; }
        public string Building { get; set; }
        public int RoomNo { get; set; }

        public Computer (int cNumber, int cAssembledYear, string rBuilding, int rRoomNo)
        {
            Number = cNumber;
            AssembledYear = cAssembledYear;
            Building = rBuilding;
            RoomNo = rRoomNo;
        }



        }
    }
