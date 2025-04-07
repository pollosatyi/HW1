using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Segment
    {
        private int _a;
        private int _b;
        public int A { get; set; }
        public int B
        {
            get
            {
                return _b;
            }
            set
            {

                if (!(value > _a)) throw new ArgumentException("Вторая точка должна быть больше");
                _b = value;

            }

        }

        public Segment(int a, int b)
        {
            A = a;
            B = b;
        }
    }
}
