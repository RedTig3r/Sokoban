using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Trap : Tile
    {

        private int amount_Used;

        public Trap()
        {
            GameObjectsCharacter = '~';
            amount_Used = 0;
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
            amount_Used++;

            if (GameObjectsCharacter == ' ' && ObjectOnTile is Crate)
            {
                this.DeleteObjectOnTile();
            }

            if (amount_Used > 3)
            {
                GameObjectsCharacter = ' ';
            }        

        }

        public override void DeleteObjectOnTile()
        {
            this.ObjectOnTile = null;
        }
    }
}