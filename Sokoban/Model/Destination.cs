using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Destination: Tile
    {

         public Destination()
        {
            GameObjectsCharacter = '0';
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
