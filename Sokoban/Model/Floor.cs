using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Floor : Tile
    {

        public Floor()
        {
            GameObjectsCharacter = '.';
        }
        
        public override bool CanEnter()
        {
            if (this.ObjectOnTile == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void ChangeObjectOnTile(ObjectOnTile objectOnTile)
        {
            this.ObjectOnTile = objectOnTile;
        }

        public override void DeleteObjectOnTile()
        {
            this.ObjectOnTile = null;
        }
              

    }
}