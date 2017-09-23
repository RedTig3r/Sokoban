using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sokoban.Controller
{
    public class GameController
    {
        private InputView inputView;
        private OutputView outputView;
        private Maze maze;
        private ConsoleKeyInfo KeyInfo;
        private bool gameIsFinish;



        public GameController()
        {
            this.inputView = new InputView();
            this.outputView = new OutputView();
            this.gameIsFinish = false;
            this.StartGame();
          
        }

        private void StartGame()
        {
            //first view of the game
            outputView.ShowGameInfo();
            this.SelectMazeInput();
            System.Console.Clear();
            outputView.ShowGameProces(maze);
            this.GameControlInput();


            System.Console.ReadLine();


        }



        private void SelectMazeInput()
        {
            while (true)
            {

                inputView.AskToSelectMaze();

                this.KeyInfo = Console.ReadKey(true);

                switch (KeyInfo.KeyChar.ToString().ToLower())
                {
                    case "s":
                        Environment.Exit(0);
                        return;
                    case "1":
                        maze = new Maze(1);
                        return;
                    case "2":
                        maze = new Maze(2);
             
                        return;
                    case "3":

                        maze = new Maze(3);
                  
                        return;
                    case "4":

                        maze = new Maze(4);
                  
                        return;

                    default:
                        inputView.ShowWrongInput();
                        break;
                }

            }
        }


        private void GameControlInput()
        {
        
        
            while (gameIsFinish != true)
            {

                inputView.AskToUseGameControl();

                KeyInfo = Console.ReadKey(true);


                switch (KeyInfo.Key)
                {
                    case ConsoleKey.S:
                        System.Environment.Exit(0);
                        break;
                    case ConsoleKey.R:
                        maze.ResetMaze();
                        outputView.resetGameProces(maze);
                        break;
                
                    case ConsoleKey.UpArrow:
                        MoveTruckUp();
                        outputView.resetGameProces(maze);
                        break;
                    case ConsoleKey.DownArrow:
                        MoveTruckDown();
                        outputView.resetGameProces(maze);
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveTruckLeft();
                        outputView.resetGameProces(maze);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveTruckRight();
                        outputView.resetGameProces(maze);
                        break;

                    default:
                        
                        inputView.ShowWrongInput();
                        break;
                }

            

            }
        }


    

        private void MoveTruckUp()
        {

        }

        private void MoveTruckDown()
        {
        
        }

        private void MoveTruckLeft()
        {
       
        }

        private void MoveTruckRight()
        {
       
        }




    }
}
