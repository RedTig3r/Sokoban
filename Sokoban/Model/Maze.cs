using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private Tile vak;
        private int[] vakken;
        private FileReader inputFileReader;
        private Truck truck;
        private Crate crate;


        public Maze(int inputFileReaderNumber)
        {

        }


        public void ResetMaze()
        {

        }

        internal void ShowMaze()
        {
            System.Console.WriteLine("maze");
        }
    }
}