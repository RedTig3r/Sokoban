using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Tile
    {

        protected TileTypes tileType { get; set; }

        public Crate TileCrate;
        public Truck TileTruck;

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

        public abstract bool CanEnter();


        public abstract void DeleteCrate();

        public abstract void DeleteTruck();


        public abstract Tile MoveTruck(int direction);


        public abstract void MoveCrate(int direction);

        public abstract void ChangeCrateTile(Crate crate);

        public abstract void ChangeTruckTile(Truck truck);
    }

}