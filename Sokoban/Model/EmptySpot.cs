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

        public override Tile GetTileDirection(int direction)
        {

            Tile tile = null;

            switch (direction)
            {
                case 1:
                    tile = this.UpTile;
                    break;
                case 2:
                    tile = this.DownTile;
                    break;
                case 3:
                    tile = this.LeftTile;
                    break;
                case 4:
                    tile = this.RightTile;
                    break;
                default:
                    tile = null;
                    break;
            }

            return tile;
        }

    }
}