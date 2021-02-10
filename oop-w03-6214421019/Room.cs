using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop-6214421017-w03
{

    class room
    {
        private string roomCode;
        private string roomName;
        private int roomWidth;
        private int roomLength;
        private string roomType;
        private int arc = 2;
        public room()
        {
            this.roomWidth = 4;
            this.roomLength = 4;
        }
        public room(string rc, string rn, int rw, int rl, string rt)
        {
            this.roomCode = rc;
            this.roomName = rn;
            this.roomWidth = rw;
            this.roomLength = rl;
            this.roomType = rt;

        }
        public int roomArea(int w, int l)
        {
            return w * l;
        }
        public int roomAvailable(int w, int l)
        {
            return w * l / arc;
        }
        public override string ToString()
        {
            return "Room" + this.roomName + ":"
                + this.roomArea(this.roomWidth, this.roomLength)
            + this.roomAvailable(this.roomWidth, this.roomLength);


        }
    }
}