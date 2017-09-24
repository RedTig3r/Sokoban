using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Tile
    {

        protected TileTypes tileType;

        public Crate tileCrate;
        public Truck tileTruck;

        public bool HasCrate { get; }
        public bool HasTruck { get; }

        public Tile RightTile { get; set; }
        public Tile LeftTile { get; set; }
        public Tile UpTile { get; set; }
        public Tile DownTile { get; set; }



        public Tile(TileTypes tileType)
        {
            this.tileType = tileType;
        }

        public TileTypes getTileType()
        {
            return this.tileType;
        }

        public abstract bool CanEnter();


        public abstract void DeleteCrate();

        public abstract void DeleteTruck();

    }

}