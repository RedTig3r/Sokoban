using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Destination : Tile
    {
        public override bool CanEnter()
        {
            return true;
        }
    }
}
