using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class ChessBoardPoint
    {
        private int _a;
        private int _b;
        public int A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value < 1 && value > 8) throw new ArgumentException();
                _a = value;
            }

        }

        public int B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value < 1 && value > 8) throw new ArgumentException();
                _b = value;
            }

        }

        public ChessBoardPoint(int a, int b)
        {
            A = a;
            B = b;
        }
    }
}
