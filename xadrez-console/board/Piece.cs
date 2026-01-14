namespace xadrez_console.board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MoveCount { get; protected set; }
        public Board Board { get; protected set; }
        public Piece(Position p, Color c, Board b)
        {
            Position = null;
            Color = c;
            Board = b;
            MoveCount = 0;
        }
        public void IncreaseMoveCount()
        {
            MoveCount++;
        }
        public void DecreaseMoveCount()
        {
            MoveCount--;
        }
    }
}
