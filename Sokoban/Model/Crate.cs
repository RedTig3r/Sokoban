using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{



    public class Crate : ObjectOnTile
    {

        private Tile _tileLocation;
        private bool _standsOnTileDirection;

        public Crate(Tile tileLocation)
        {
            _tileLocation = tileLocation;


        }

        public override void MoveObject(int direction)
        {
/*
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
            }
            if (tile != null)
            {

                if (tile.CanEnter() == true)
                {
                    tile.MoveCrate(direction);
                }

                tile.ChangeCrateTile(this.TileCrate);
                this.DeleteCrate();

            }
*/
        }

        public bool getStandsOnTileDirection()
        {
            if (this.gameObjectCharacter == '0')
            {
                return true;
            }else
            {

                return false;
            }
        }

        public override char getGameObjectCharacter()
        {
            if (this._tileLocation.gameObjectCharacter == 'X')
            {
                return '0';
            }
            else
            {
                return '0';
            }
        }
    }
}



   
