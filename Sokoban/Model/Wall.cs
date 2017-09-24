using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Wall : Tile
    {
        public Wall(TileTypes tileType) : base(tileType)
        {
            this.tileType = tileType;

        }

        public override bool CanEnter()
        {
                return false;
        }

        public override void ChangeCrateTile(Crate crate)
        {
            this.TileCrate = crate;
        }

        public override void ChangeTruckTile(Truck truck)
        {
            this.TileTruck = truck;
        }


        public override void DeleteCrate()
        {
            this.TileCrate = null;
        }

        public override void DeleteTruck()
        {
            this.TileTruck = null;
        }

        public override Tile MoveTruck(int direction)
        {
            return null;

        }

        public override void MoveCrate(int direction)
        {

            return;

        }
    }
}
