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
        private InputView _inputView;
        private OutputView _outputView;
        private Maze _maze;
        private ConsoleKeyInfo _keyInfo;
        private bool _gameIsFinish;



        public GameController()
        {
            this._inputView = new InputView();
            this._outputView = new OutputView();
            this._gameIsFinish = false;
            this.StartGame();

        }

        private void StartGame()
        {
            //first view of the game
            _outputView.ShowGameInfo();
            this.SelectMazeInput();
         
            _outputView.ShowGameProces(_maze);
            this.GameControlInput();

            _inputView.AskToPressKeyToStartOver();
            System.Console.ReadKey();
            this.StartGame();

        }



        private void SelectMazeInput()
        {
            while (true)
            {

                _inputView.AskToSelectMaze();

                this._keyInfo = Console.ReadKey(true);

                switch (_keyInfo.KeyChar.ToString().ToLower())
                {
                    case "s":
                        Environment.Exit(0);
                        return;
                    case "1":
                        _maze = new Maze(1);
                        return;
                    case "2":
                        _maze = new Maze(2);

                        return;
                    case "3":

                        _maze = new Maze(3);

                        return;
                    case "4":

                        _maze = new Maze(4);

                        return;

                    default:
                        _inputView.ShowWrongInput();
                        break;
                }

            }
        }


        private void GameControlInput()
        {

            bool inputIsWrong;

            while (_gameIsFinish != true)
            {
                inputIsWrong = false;

                _inputView.AskToUseGameControl();

                _keyInfo = Console.ReadKey(true);


                switch (_keyInfo.Key)
                {
                    case ConsoleKey.S:
                        System.Environment.Exit(0);
                        break;
                    case ConsoleKey.R:
                        _maze.ResetMaze();

                        break;

                    case ConsoleKey.UpArrow:
                        MoveTruckUp();

                        break;
                    case ConsoleKey.DownArrow:
                        MoveTruckDown();

                        break;
                    case ConsoleKey.LeftArrow:
                        MoveTruckLeft();

                        break;
                    case ConsoleKey.RightArrow:
                        MoveTruckRight();

                        break;

                    default:
                        inputIsWrong = true;
                        _inputView.ShowWrongInput();
                        break;
                }

                if (!inputIsWrong)
                {
                    _outputView.ShowGameProces(_maze);
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
