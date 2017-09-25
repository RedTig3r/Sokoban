using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class EmptySpot : Tile
    {
        public override bool CanEnter()
        {
      
                return false;
         


        }

        public override void ChangeObjectOnTile(ObjectOnTile objectOnTile)
        {
            return;
        }

        public override void DeleteObjectOnTile()
        {
            this.ObjectOnTile = null;
        }

        public override char getGameObjectCharacter()
        {
            return ' ';
        }

       

    }
}