using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.ChessFigure
{
    internal class HorseFigure : ChessFigure
    {
        public HorseFigure(ChessBoardPoint point) : base(point)
        {
        }

        public override bool IsCorrectMovie(ChessBoardPoint otherPoint)
        {
            return Math.Abs(StartPoint.A - otherPoint.A) == 1 && Math.Abs(StartPoint.B - otherPoint.B) == 2
                || Math.Abs(StartPoint.A - otherPoint.A) == 2 && Math.Abs(StartPoint.B - otherPoint.B) == 1;
        }
    }
}
