using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Tile: GameObjects
    {

        public ObjectOnTile ObjectOnTile;

        public bool hasCrate { get; set; }

        public Tile RightTile { get; set; }
        public Tile LeftTile { get; set; }
        public Tile UpTile { get; set; }
        public Tile DownTile { get; set; }


        public abstract bool CanEnter();

        public abstract void DeleteObjectOnTile();

        public abstract void ChangeObjectOnTile(ObjectOnTile objectOnTile);

        public abstract Tile GetTileDirection(int direction);
    }

}