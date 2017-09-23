using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class InputView
    {


        public void AskToSelectMaze()
        {

            System.Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");
        }



        public void AskToUseGameControl()
        {

            Console.WriteLine("> gebruik pijltjestoetjes (s = stop, r = reset");
        }



        public void ShowWrongInput()
        {

            System.Console.WriteLine("> ?");
        }



    }
}
