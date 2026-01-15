using xadrez_console.board;

namespace xadrez_console.chess
{
    internal class King : Piece
    {
        public King(Board b, Color c) : base (c, b)
        {
        }
        public override string ToString()
        {
            return "K";
        }
    }
}
