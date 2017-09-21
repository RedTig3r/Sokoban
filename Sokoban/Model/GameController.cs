using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            showOutput1();
            Console.WriteLine("Kies een doolhof (1 - 4), s = stop");
            Console.ReadLine();

            string result;
            
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
        


        public void MoveTruckUp()
        {
            throw new System.NotImplementedException();
        }

        public void MoveTruckDown()
        {
            throw new System.NotImplementedException();
        }

        public void MoveTruckLeft()
        {
            throw new System.NotImplementedException();
        }

        public void MoveTruckRight()
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
