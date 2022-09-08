using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.Pieces
{
    public static class PieceMoveHelper
    {
        public static bool HasEndPiece(Piece endPiece) => endPiece is not null;

        public static bool IsEndPieceSameColor(Piece startPiece, Piece endPiece)
        { 
            return HasEndPiece(endPiece) && startPiece.White == endPiece.White;
        }                                             
    }
}
