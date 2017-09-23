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
        }

        public override bool CanEnter()
        {
             return false;
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
