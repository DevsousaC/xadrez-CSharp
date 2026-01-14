using xadrez_console.board;

namespace xadrez_console
{
    internal class View
    {
        public static void ViewBoard(Board b)
        {
            for (int i = 0; i < b.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    if (b.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(b.piece(i, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
