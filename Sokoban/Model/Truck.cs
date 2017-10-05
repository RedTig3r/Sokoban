using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Truck : ObjectOnTile
    { 

        public Truck(Tile standsOnTile)
        {
            this.StandsOnTile = standsOnTile;
            GameObjectsCharacter = '@';

        }


        public override void MoveObject(int direction)
        {
            try{
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
                if (tile != null)
                {

                    if (tile.ObjectOnTile != null)
                    {
                        tile.ObjectOnTile.MoveObject(direction);
                    }



                    if (tile.CanEnter())
                    {
                        tile.ChangeObjectOnTile(this);
                        StandsOnTile.DeleteObjectOnTile();
                        StandsOnTile = tile;
                       
                    }

                }
            }
            catch
            {
                throw;
            }

          

        }





    }
}