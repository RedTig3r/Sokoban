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
        private FileReader _fileReader;
        private Maze _maze;
        private bool _gameIsFinish;

        public GameController()
        {
            this._inputView = new InputView();
            this._outputView = new OutputView();
            this._fileReader = new FileReader();
            this.StartGame();

        }

        private void StartGame()
        {

            _outputView.ShowGameInfo();
           
            int askInput;
            bool inputIsCorrect = false;
            this._gameIsFinish = false;
            int mazeNumber = 0;

            while (inputIsCorrect != true)
            {
                mazeNumber = _inputView.AskToSelectMazeInput();

                if (mazeNumber == -1)
                {
                    Environment.Exit(0);
                }
                else if (mazeNumber > 0 && mazeNumber < 7)
                {
                    _maze = _fileReader.CreateMaze(mazeNumber);

                    inputIsCorrect = true;
                }
                else
                {
                    _inputView.ShowErrorInput();
                    inputIsCorrect = false;
                }

            }

            if (_maze != null)
            {
                while (_gameIsFinish != true)
                {
                    inputIsCorrect = false;
                    _outputView.ShowGameProces(_maze);


                    while (inputIsCorrect != true)
                    {
                        askInput = _inputView.AskGameControlInput();

                        if (askInput == 0)
                        {
                            _inputView.ShowErrorInput();
                            inputIsCorrect = false;
                        }
                        else
                        {

                            if (askInput == -2)
                            {
                                _maze = _fileReader.CreateMaze(mazeNumber);
                            }
                            else if (askInput == -1)
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                _maze.MoveTruck(askInput);
                            }

                            inputIsCorrect = true;
                        }

                    }

                    _maze.MoveEmployee();

                    _gameIsFinish = _maze.gameIsFinished();
                }
            }else
            {
                _inputView.ShowErrorInput();
            }

           

            _inputView.AskToPressKeyToStartOver();
            this.StartGame();

        }

       





    }
}
