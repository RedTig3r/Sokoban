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
        private List <Crate> _CrateList;
        private int _mazeHeight;
        private int _mazeWidth;

                
        public void MoveTruck(Direction direction)
        {
            try
            {
                
            }
            catch
            {
                throw new Exception("Truck kan niet verplaatst worden!");
            }
        }

        public Tile OriginTile { get; set; }
        public Truck Truck { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        
        public bool gameIsFinished()
        {

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