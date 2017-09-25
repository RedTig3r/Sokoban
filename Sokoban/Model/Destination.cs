using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Destination: Tile
    {


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

        public override char getGameObjectCharacter()
        {
     
                return 'X';
      
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
