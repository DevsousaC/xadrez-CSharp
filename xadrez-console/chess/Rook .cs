using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.board;

namespace xadrez_console.chess
{
    internal class Rook : Piece
    {
        public Rook(Board b, Color c) : base(c, b)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
