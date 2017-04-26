using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public struct DisplacementVector
    {
        public int X,Y;

        public DisplacementVector(int initialX, int initialY) {
            X = initialX;
            Y = initialY;
        }
        public static DisplacementVector operator+ (
            DisplacementVector v1, DisplacementVector v2) {
            return new DisplacementVector(v1.X+v2.X, v1.Y+v2.Y);
        }
    }
}
