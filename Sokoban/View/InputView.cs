using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sokoban
{
    public class InputView
    {

        private ConsoleKeyInfo _keyInfo;

        public int AskGameControlInput()
        {
            System.Console.WriteLine("> gebruik pijljestoetsen (s = stop, r = reset)");

            this._keyInfo = Console.ReadKey(true);

            switch (_keyInfo.Key)
            {
                case ConsoleKey.S:
                    return -1;
                case ConsoleKey.R:
                    return -2;
                case ConsoleKey.UpArrow:
                    return 1;
                case ConsoleKey.DownArrow:
                    return 2;
                case ConsoleKey.LeftArrow:
                    return 3;
                case ConsoleKey.RightArrow:
                    return 4;
                default:
                    return 0;
            }
        }
        public int AskToSelectMazeInput()
        {

            System.Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");

            this._keyInfo = Console.ReadKey(true);

            switch (_keyInfo.KeyChar.ToString().ToLower())
            {
                case "s":
                    return -1;
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                default:
                    return 0;
            }
        }


        public void ShowErrorInput()
        {
            System.Console.WriteLine("> ?");
        }


        public void AskToPressKeyToStartOver()
        {
            System.Console.WriteLine("=== HOERA OPGELOST ===");
            System.Console.WriteLine("> press key to continue");
            System.Console.ReadKey();
        }


  


    }
}
