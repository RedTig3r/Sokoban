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
        private List<Crate> _CrateList;



        public Maze(int mazeNumber)
        {

            _mazeNumber = mazeNumber;
            _fileReader = new FileReader(mazeNumber);



            _fileReader.CreateTiles();
        }


        public void ResetMaze()
        {

        }

        public bool gameIsFinished()
        {

            int amountOfCrates = this._CrateList.Count;
            int x = 0;
            foreach (Crate crate in this._CrateList)
            {
                if (crate._standsOnTileDirection == true)
                {
                    x++;
                }
            }


            if (amountOfCrates == x)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}