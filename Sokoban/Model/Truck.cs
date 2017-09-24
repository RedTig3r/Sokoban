using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Truck 
    {

        public Tile StandsOnTile;

        public Truck(Tile StandsOnTile)
        {
            this.StandsOnTile = StandsOnTile;
        }

        public void MoveTruck(int direction)
        {
            Tile tile = StandsOnTile.MoveTruck(direction);
            if (tile != null)
            {
                StandsOnTile = tile;
            }
        }







    }
}