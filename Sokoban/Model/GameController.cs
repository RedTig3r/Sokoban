using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sokoban.Model
{
    public class GameController
    {
        private InputView Asks_for;
        private OutputView shows;
        private Maze maze;



        int sidesY = 20;
        int sidesX = 20;


        public GameController()
        {
         
        }

      



        public void input()
        {
            ConsoleKeyInfo KeyInfo;



            KeyInfo = Console.ReadKey(true);
            Console.Clear();


            switch (KeyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    sidesY++;
                    Console.SetCursorPosition(sidesY, sidesX);
                    Console.Write("kenny tu");
                    break;
                case ConsoleKey.LeftArrow:
                    sidesY--;
                    Console.SetCursorPosition(sidesY, sidesX);
                    Console.Write("kenny tu");
                    break;
                case ConsoleKey.UpArrow:
                    sidesX--;
                    Console.SetCursorPosition(sidesY, sidesX);
                    Console.Write("kenny tu");
                    break;
                case ConsoleKey.DownArrow:
                    sidesX++;
                    Console.SetCursorPosition(sidesY, sidesX);
                    Console.Write("kenny tu");
                    break;



            }
        }
       





        private void MoveTruckUp()
        {

        }

        private void MoveTruckDown()
        {
            throw new System.NotImplementedException();
        }

        private void MoveTruckLeft()
        {
            throw new System.NotImplementedException();
        }

        private void MoveTruckRight()
        {
            throw new System.NotImplementedException();
        }

    }
}
