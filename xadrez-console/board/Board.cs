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

        public Piece piece(Position p)
        {
            return pieces[p.Rows, p.Columns];
        }

        public bool existingPiece(Position position)
        {
            validatePosition(position);
            return piece(position) != null;
        }

        public void placePiece(Piece piece, Position position)
        {
            pieces[position.Rows, position.Columns] = piece;
            piece.Position = position;
        }

        public bool validPosition(Position position)
        {
            if (position.Rows < 0 || position.Rows >= Rows || position.Columns < 0 || position.Columns >= Columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position position)
        {
            if (!validPosition(position)) {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
