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

        public Input AskGameControlInput()
        {
            System.Console.WriteLine("> gebruik pijljestoetsen (s = stop, r = reset)");

            this._keyInfo = Console.ReadKey(true);

            switch (_keyInfo.Key)
            {
                case ConsoleKey.S:
                    return Input.S;
                case ConsoleKey.R:
                    return Input.R;


                case ConsoleKey.UpArrow:
                    return Input.Up;


                case ConsoleKey.DownArrow:
                    return Input.Down;


                case ConsoleKey.LeftArrow:
                    return Input.Left;

                case ConsoleKey.RightArrow:
                    return Input.Left;
                default:
                    return Input.Wrong;
            }
        }
        public int AskToSelectMazeInput()
        {


            System.Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");

            this._keyInfo = Console.ReadKey(true);

            switch (_keyInfo.KeyChar.ToString().ToLower())
            {
                case "s":
                    Environment.Exit(0);
                    return -1;
                case "1":
                    return 1;

                case "2":


                    return 2;
                case "3":



                    return 3;
                case "4":



                    return 4;

                default:

                    return 0;


            }
        }


        public void ShowWrongInput()
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
