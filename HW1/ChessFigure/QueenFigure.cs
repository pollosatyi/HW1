using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.ChessFigure
{
    internal class QueenFigure : ChessFigure
    {
        public QueenFigure(ChessBoardPoint point) : base(point)
        {
        }

        public override bool IsCorrectMovie(ChessBoardPoint otherPoint)
        {
            return StartPoint.A == otherPoint.A || StartPoint.B == otherPoint.B || Math.Abs(StartPoint.A - otherPoint.A) == Math.Abs(StartPoint.B - otherPoint.B);
        }
    }
}
