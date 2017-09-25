using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{



    public class Crate : ObjectOnTile
    {

        public Crate(Tile standsOnTile)
        {
            StandsOnTile = standsOnTile;


        }

        public override void MoveObject(int direction)
        {

            Tile tile = null;
            switch (direction)
            {
                case 1:
                    tile = StandsOnTile.UpTile;
                    break;
                case 2:
                    tile = StandsOnTile.DownTile;
                    break;
                case 3:
                    tile = StandsOnTile.LeftTile;
                    break;
                case 4:
                    tile = StandsOnTile.RightTile;
                    break;
            }
            if (tile != null && tile.CanEnter() == true)
            {

                tile.ChangeObjectOnTile(this);
                StandsOnTile.DeleteObjectOnTile();
                StandsOnTile = tile;
              

            }
        }

        public bool getStandsOnTileDirection()
        {
            if (this.gameObjectCharacter == '0')
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public override char getGameObjectCharacter()
        {
            if (this.StandsOnTile.gameObjectCharacter == 'X')
            {
                return '0';
            }
            else
            {
                return 'O';
            }
        }
    }
}



   
