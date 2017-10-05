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

            GameObjectsCharacter = 'o';


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
            if (tile != null && tile.CanEnter())
            {

                if (tile is Destination)
                {
                    GameObjectsCharacter = 'x';
                }
                else
                {
                    GameObjectsCharacter = '0';
                }


                tile.ChangeObjectOnTile(this);
                StandsOnTile.DeleteObjectOnTile();
                StandsOnTile = tile;
            }
        }

        public bool getStandsOnTileDirection()
        {
            if (GameObjectsCharacter == 'x')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}




