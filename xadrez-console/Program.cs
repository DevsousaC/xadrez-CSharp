using xadrez_console.board;
using xadrez_console.chess;

namespace xadrez_console { 
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.placePiece(new Rook(board, Color.Black), new Position(0, 0));
            board.placePiece(new Rook(board, Color.Black), new Position(1, 2));
            board.placePiece(new King(board, Color.Black), new Position(4, 4));

            View.ViewBoard(board);
        }
    }
}