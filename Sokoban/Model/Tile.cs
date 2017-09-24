using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Tile
    {

        public TileTypes tileType;

        public Crate tileCrate;
        public Truck tileTruck;

        public bool hasCrate;
        public bool hasTruck;


        public Tile RightTile;
        public Tile LeftTile;
        public Tile UpTile;
        public Tile DownTile;



        public Tile(TileTypes tileType)
        {
            this.tileType = tileType;
        }

        public abstract bool CanEnter();


        public abstract void DeleteCrate();

        public abstract void DeleteTruck();
    }

}