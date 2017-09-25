using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private Tile _firstTile;
        private Truck _Truck;
        private List<Crate> _CrateList;
        private int _mazeHeight;
        private int _mazeWidth;





        public void MoveTruck(int direction)
        {
           // _Truck.MoveObject(direction);
        }


        public bool gameIsFinished()
        {


            return false;


            int amountOfCrates = this._CrateList.Count;
            int x = 0;
            foreach (Crate crate in this._CrateList)
            {
                if (crate.getStandsOnTileDirection() == true)
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