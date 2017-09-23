using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class InputView
    {


        public int AskToSelectMaze()
        {
            int num = 0;
            char s = '?';

            while (num < 1 || num > 4 && s != 's')
            {
                System.Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                s = consoleKeyInfo.KeyChar;
                System.Console.WriteLine();
                if (s >= '1' && s <= '4')
                {
                    string input = char.ToString(consoleKeyInfo.KeyChar);
                    num = Convert.ToInt32(input);   //print de ingevoerde input 
                }else if (s != 's')
                {
                    System.Console.WriteLine("> ?");
                }
            }
            if (s == 's') 
            {
                Environment.Exit(0);
            }         

            return num;
        }



        public void AskToUseGameControl()
        {

            Console.WriteLine("> gebruik pijltjestoetjes (s = stop, r = reset");
        }



        public void ShowWrongInput()
        {

            System.Console.WriteLine("> ?");
        }

        public void AskToPressKeyToStartOver()
        {
            System.Console.WriteLine("=== HOERA OPGELOST ===");
            System.Console.WriteLine("> press key to continue");
        }


    }
}
