using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    class GameController
    {
        private InputView inputView;
        private OutputView shows;
        private Maze maze;


        public GameController()
        {
            inputView = new InputView();
        }


        public void showOutput1()
        {
            inputView.ShowOutput1();
        }

    }
}
