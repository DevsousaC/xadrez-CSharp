using xadrez_console.Tabuleiro;

namespace xadrez_console { 
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 3);

            Console.WriteLine("Posição: " + P);
        }
    }
}