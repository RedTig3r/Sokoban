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
            try
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
                        GameObjectsCharacter = '0';
                    }
                    else
                    {
                        GameObjectsCharacter = 'o';
                    }
                    
                    tile.ChangeObjectOnTile(this);
                    StandsOnTile.DeleteObjectOnTile();
                    StandsOnTile = tile;
                }
            }
            catch
            {
                throw;
            }
        }


    }
}




