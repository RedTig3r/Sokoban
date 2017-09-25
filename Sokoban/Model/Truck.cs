using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Truck : ObjectOnTile
    {

        public Tile StandsOnTile;

        public Truck(Tile StandsOnTile)
        {
            this.StandsOnTile = StandsOnTile;
        }

 
        public override void MoveObject(int direction)
        {
            /*
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
                StandsOnTile = tile;
                this.StandsOnTile.DeleteObjectOnTile();
            }
            else
            {
                return null;
            }
            */
        }

        public override char getGameObjectCharacter()
        {
            return '@';
        }



    }
}