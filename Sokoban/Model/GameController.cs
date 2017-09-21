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
        private ConsoleKeyInfo KeyInfo;



        public GameController()
        {
            inputView = new InputView();
            outputView = new OutputView();
            StartGame();
        }

        private void StartGame()
        {
            //first view of the game
            inputView.ShowView();
            AskGameInput();
            Console.WriteLine("next shit ");
            Console.ReadLine();


        }



        private void AskGameInput()
        {
            while (true)
            {

                Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");
                Console.WriteLine("");

                KeyInfo = Console.ReadKey(true);

                switch (KeyInfo.Key)
                {
                    case ConsoleKey.S:


                        Environment.Exit(0);

                        return;
                    case ConsoleKey.NumPad1:

                        Console.WriteLine("1");
                        return;
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("2");
                        return;
                    case ConsoleKey.NumPad3:

                        Console.WriteLine("3");

                        return;
                    case ConsoleKey.NumPad4:

                        Console.WriteLine("4");

                        return;

                    default:
                        Console.WriteLine("> ?");
                        break;
                }

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
