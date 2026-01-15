namespace xadrez_console.board
{
    internal class Board
    {
        private Piece[,] pieces;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            pieces = new Piece[rows, columns];
        }

        public Piece piece(int row, int column)
        {
            return pieces[row, column];
        } 

        public void placePiece(Piece piece, Position position)
        {
            pieces[position.Rows, position.Columns] = piece;
            piece.Position = position;
        }
    }
}
