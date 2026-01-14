namespace xadrez_console.board
{
    internal class Board
    {
        private Piece[,] pieces; // Array com todos os valores da Matriz
        public int Rows;
        public int Columns;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            pieces = new Piece[rows, columns];
        }
    }
}
