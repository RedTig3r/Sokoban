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


        public override void DeleteCrate()
        {
            this.tileCrate = null;
        }

        public override void DeleteTruck()
        {
            this.tileTruck = null;
        }
    }
}
