using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
