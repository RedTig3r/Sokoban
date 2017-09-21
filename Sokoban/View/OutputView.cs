using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {
        public void ShowMenu()
        {
            System.Console.WriteLine(" _________");
            System.Console.WriteLine("|         |");
            System.Console.WriteLine("| Sokoban |");
            System.Console.WriteLine("|_________|");
            System.Console.WriteLine("________________________________________________________");
            System.Console.WriteLine(" Hier komt shit van de doolhof");
            
            System.Console.WriteLine("________________________________________________________|");
            Console.WriteLine("> gebruik pijltjestoetjes (s = stop, r = reset");
        }
    }
}