using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.board
{
    internal class BoardException : Exception
    {
        public BoardException(string message) : base(message)
        {
        }
    }
}
