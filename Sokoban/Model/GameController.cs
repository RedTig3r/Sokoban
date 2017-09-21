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
        private InputView inputView;
        private OutputView outputView;
        private Maze maze;

        private string input;

        public GameController()
        {
            inputView = new InputView();
            outputView = new OutputView();
            maze = new Maze();
        }

        public void startGame()
        {
            //first view of the game
            //showOutput1();
            showOutput2();

        }
        


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


        public void showOutput1()
        {
            inputView.showView();
            Console.ReadLine();

            string result = Console.ReadLine();

            try
            {
                if (input == "s")
                {
                    Environment.Exit(0);
                }

                result = Convert.ToString(input);
            }
            catch
            {
                System.Console.WriteLine("Try again!");
            }
        }

        public void showOutput2()
        {
            outputView.ShowMenu();
            Console.ReadLine();
        }

    }
}
