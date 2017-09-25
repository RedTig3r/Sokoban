using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class ObjectOnTile: GameObjects
    {

        public Tile StandsOnTile;

        public abstract void MoveObject(int direction);



    }
}