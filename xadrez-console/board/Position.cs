namespace xadrez_console.board
{
    internal class Position
    {
        public int Rows;
        public int Columns;

        public Position()
        { }

        public Position(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public override string ToString()
        {
            return Rows + ", " + Columns;
        }
    }
}
