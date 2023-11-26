using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Generator
{
    internal class Room
    {
        private int roomNo;
        private string type;
        public int RoomNo
        { get { return roomNo; } set { roomNo = value; } }
        public string Type
        { get { return type; } set { type = value; } }
        public Room(int roomNo, string type)
        {
            RoomNo = roomNo;
            Type = type;
        }
    }
}
