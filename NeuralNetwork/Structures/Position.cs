using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Structures
{
    public struct Position2D
    {
        private int _x;
        private int _y;

        public Position2D(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }
    }
}
