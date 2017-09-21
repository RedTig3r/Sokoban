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
           
        }

        public void startGame()
        {
            //first view of the game
            showOutput1();
            Console.WriteLine("Kies een doolhof (1 - 4), s = stop");
            int MazeNumber = 0;
            Console.ReadLine();
            try
            {


                switch (KeyInfo.Key)
                {


                    case ConsoleKey.S:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.D1:
                        MazeNumber = 1;
                        break;
                    case ConsoleKey.D2:
                        MazeNumber = 2;
                        break;
                    case ConsoleKey.D3:
                        MazeNumber = 3;
                        break;
                    case ConsoleKey.D4:
                        MazeNumber = 4;
                        break;
                }


              

                maze = new Maze(MazeNumber);

                
            }
            catch 
            {
                System.Console.WriteLine("Try again!");
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
        }

        public void showOutput2()
        {
            
        }

    }
}
