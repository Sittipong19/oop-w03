using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w03
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLat;
        private string buildingLong;
        public Building(string c, string n, string la, string lo)
        {
            this.buildingCode = c;
            this.buildingName = n;
            this.buildingLat = la;
            this.buildingLong = lo;
        }
        public override string ToString()
        {
            return "building Code: " + this.buildingCode + "\t building Name: " + this.buildingName + "\t building Lat: " + this.buildingLat + "\t building Long: " + this.buildingLong;
        }
    }
}

