using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Destination : Tile
    {
        public Destination(TileTypes tileType) : base(tileType)
        {
            this.tileType = tileType;
        }

        public override bool CanEnter()
        {
            if(this.tileTruck == null & this.tileCrate == null)
            {
                return true;
            }else
            {
                return false;
            }

          
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
