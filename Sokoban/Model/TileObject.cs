using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class ObjectOnTile
    {

        public Tile StandsOnTile;

        public char GameObjectsCharacter { get; set; }


        public abstract void MoveObject(int direction);



    }
}