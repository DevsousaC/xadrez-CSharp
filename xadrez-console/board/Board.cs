namespace xadrez_console.board
{
    internal class Board
    {
        private Piece[,] pieces;
        public int Rows;
        public int Columns;

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
    }
}
