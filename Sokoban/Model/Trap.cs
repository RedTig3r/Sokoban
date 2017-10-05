using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Trap : Tile
    {

        private int amountOfTimesUsed;

        public Trap()
        {
            GameObjectsCharacter = '~';
            amountOfTimesUsed = 0;
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
            amountOfTimesUsed++;

            if (amountOfTimesUsed > 3)
            {
                GameObjectsCharacter = ' ';
            }

            if (GameObjectsCharacter == ' ' && ObjectOnTile is Crate)
            {
                this.ObjectOnTile = null;
            }

        }

        public override void DeleteObjectOnTile()
        {
            this.ObjectOnTile = null;
        }
    }
}