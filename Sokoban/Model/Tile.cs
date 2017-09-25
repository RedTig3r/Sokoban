using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Tile: GameObjects
    {

        public ObjectOnTile ObjectOnTile;

     
        public Kind kind { get; set; }
        public Crate crate { get; set; }
        public Truck truck { get; set; }
        public Tile RightTile { get; set; }
        public Tile LeftTile { get; set; }
        public Tile UpTile { get; set; }
        public Tile DownTile { get; set; }

        public bool hasCrate
        {
            get { return this.crate != null; }
        }

        public bool hasTruck
        {
            get { return this.truck != null; }
        }


        public abstract bool CanEnter();

        public abstract void DeleteObjectOnTile();

        public abstract void ChangeObjectOnTile(ObjectOnTile objectOnTile);

        public abstract Tile GetTileDirection(int direction);
    }

}