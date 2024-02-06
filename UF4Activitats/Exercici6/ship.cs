using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class ship : AVehicle
    {
        public int sailLength;
        public int mastilHeight;

        public int SailLength { get => sailLength; set => sailLength = value; }
        public int MastilHeight { get => mastilHeight; set => mastilHeight = value; }

        public ship(string name, string color, bool wheeled, int sailLength, int mastilHeight): base (name, color, wheeled)
        {
            Name = name;
            Color = color;
            Wheeled = wheeled;
            SailLength = sailLength;
            MastilHeight = mastilHeight;
        }
    }
}
