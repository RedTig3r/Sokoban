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
            int mazeNumber = 0;
            int askInput;
            bool inputIsCorrect = false;

            while (inputIsCorrect != true)
            {
                mazeNumber = _inputView.AskToSelectMazeInput();

                if (mazeNumber == -1)
                {
                    Environment.Exit(0);
                }
                else if (mazeNumber > 0 && mazeNumber < 5)
                {
                    _maze = new Sokoban.Maze(mazeNumber);
                    inputIsCorrect = true;
                }
                else
                {
                    _inputView.ShowWrongInput();
                    inputIsCorrect = false;
                }

            }

            while (_gameIsFinish != true)
            {
                inputIsCorrect = false;
                _outputView.ShowGameProces(_maze);


                while (inputIsCorrect != true)
                {
                    askInput = _inputView.AskGameControlInput();


                    if (askInput == 0)
                    {
                        _inputView.ShowWrongInput();
                        inputIsCorrect = false;
                    }
                    else
                    {

                        if (askInput == -2)
                        {
                            Environment.Exit(0);
                  
                        }
                        else if (askInput == -1)
                        {

                            _maze.ResetMaze();
                        }
                        else
                        {
                            this.MoveTruck(askInput);
                        }

                        inputIsCorrect = true;
                    }

                }


            }

            _inputView.AskToPressKeyToStartOver();
            this.StartGame();

        }






        private void MoveTruck(int direction)
        {

            switch (direction)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;


            }



        }





    }
}
