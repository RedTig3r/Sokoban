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
        private int _mazeNumber;
        private bool _gameIsFinish;

        public GameController()
        {
            this._inputView = new InputView();
            this._outputView = new OutputView();
            this._fileReader = new FileReader();
            this._gameIsFinish = false;
            this.StartGame();

        }

        private void StartGame()
        {

            _outputView.ShowGameInfo();
           
            int askInput;
            bool inputIsCorrect = false;

            while (inputIsCorrect != true)
            {
                _mazeNumber = _inputView.AskToSelectMazeInput();

                if (_mazeNumber == -1)
                {
                    Environment.Exit(0);    //stopt programma
                }
                else if (_mazeNumber > 0 && _mazeNumber < 5)
                {
                    _maze = _fileReader.CreateMaze(_mazeNumber);    //print met fileReader de gekozen doolhof uit
                    
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
                this._maze = _fileReader.LoadMaze(_mazeNumber);
                _outputView.ShowGameProces(this._maze);


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
                            _maze = _fileReader.ResetMaze();
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

                _gameIsFinish = _maze.gameIsFinished();
            }

            _inputView.AskToPressKeyToStartOver();
            this.StartGame();

        }

       





    }
}
