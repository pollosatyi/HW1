using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.ChessFigure
{
    internal abstract class ChessFigure
    {
        public ChessBoardPoint StartPoint { get; set; }

        public ChessFigure(ChessBoardPoint point)
        {
            StartPoint = point;

        }

        public abstract bool IsCorrectMovie(ChessBoardPoint otherPoint);
      
    }
}
