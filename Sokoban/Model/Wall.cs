using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Wall : Tile
    {

        public Wall()
        {
            GameObjectsType = ObjectEnum.Wall;
        }


        public override bool CanEnter()
        {
                return false;
        }

        public override void ChangeObjectOnTile(ObjectOnTile objectOnTile)
        {
            return;
        }

        public override void DeleteObjectOnTile()
        {
            this.ObjectOnTile = null;
        }

 
       
    }
}
