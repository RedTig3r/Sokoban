using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        public Tile OriginalTile { get; set; }
        private Truck Truck { get; set; }
        public List <Crate> CrateList { get; set; }
        public int MazeHeight { get; set; }
        public int MazeWidth { get; set; }

        public void MoveTruck(int direction)
        {
            try
            {
                
            }
            catch
            {
                throw new Exception("Truck kan niet verplaatst worden!");
            }
        }

        public bool gameIsFinished()
        {

            int amountOfCrates = this.CrateList.Count;
            int x = 0;
            foreach (Crate crate in this.CrateList)
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