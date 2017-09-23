using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Tile
    {

        protected char _icon;

        public Crate crate;
        public Truck truck;


        public Tile RightTile;
        public Tile LeftTile;
        public Tile UpTile;
        public Tile DownTile;


        public abstract bool CanEnter();

      
    }
}