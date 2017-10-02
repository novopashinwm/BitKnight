using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiKnight
{
    class Program
    {
        static void Main(string[] args)
        {
            Chess chess = new Chess();
            Console.WriteLine(chess.FoundCheckmates());
        }
    }
}
