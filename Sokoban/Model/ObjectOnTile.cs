using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class ObjectOnTile
    {
        //abstracte class waarbij object op een tile staat

        public Tile StandsOnTile;   //staat op een tile

        public char GameObjectsCharacter { get; set; }  //de karakter van het object (@, #, etc.)

        public abstract void MoveObject(int direction); 

    }
}