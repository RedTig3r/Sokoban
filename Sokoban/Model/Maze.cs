using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private Tile _firstTile;
        private int _mazeNumber;
        private FileReader _fileReader;

        private Truck _Truck;
        private Crate _Crate;


       
        public Maze()
        {

            _mazeNumber = mazeNumber;
            _fileReader = new FileReader(mazeNumber);


           
            _fileReader.CreateTiles();
        }


        public void ResetMaze()
        {

        }

        public void ShowMaze()
        {
            throw new NotImplementedException();
        }
    }
}