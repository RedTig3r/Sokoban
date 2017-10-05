using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Tile
    {

        public ObjectOnTile ObjectOnTile { get; set; }

        public ObjectEnum GameObjectsType { get; set; }

        public Tile RightTile { get; set; }
        public Tile LeftTile { get; set; }
        public Tile UpTile { get; set; }
        public Tile DownTile { get; set; }
    
        public abstract bool CanEnter();

        public abstract void DeleteObjectOnTile();

        public abstract void ChangeObjectOnTile(ObjectOnTile objectOnTile);

        public Tile GetTileDirection(int direction)
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