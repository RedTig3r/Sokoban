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
        }

        public override bool CanEnter()
        {
            return true;
        }

        public override bool DeleteCrate()
        {
            throw new NotImplementedException();
        }

        public override void DeleteTruck()
        {
            throw new NotImplementedException();
        }
    }
}
