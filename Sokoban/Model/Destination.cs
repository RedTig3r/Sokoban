using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Destination : Tile
    {
        public Destination(TileTypes tileType) : base(tileType)
        {
            this.tileType = tileType;
        }

        public override bool CanEnter()
        {
            if (this.TileTruck == null & this.TileCrate == null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public override void ChangeCrateTile(Crate crate)
        {
            this.TileCrate = crate;
        }

        public override void ChangeTruckTile(Truck truck)
        {
            this.TileTruck = truck;
        }


        public override void DeleteCrate()
        {
            this.TileCrate = null;
        }

        public override void DeleteTruck()
        {
            this.TileTruck = null;
        }

        public override Tile MoveTruck(int direction)
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
            }
            if (tile != null)
            {

                if (tile.CanEnter() == true || tile.HasCrate == true)
                {
                    tile.MoveCrate(direction);
                }

                tile.ChangeTruckTile(this.TileTruck);
                this.DeleteTruck();
                return tile;
            }
            else
            {
                return null;
            }

        }

        public override void MoveCrate(int direction)
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

        }

  
     
    }
}
