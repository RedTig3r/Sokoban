using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Employee : ObjectOnTile
    {

        Random random = new Random();
        bool isAwake;

        public Employee()
        {
            GameObjectsCharacter = '$';
            isAwake = true;
        }



        public void UseEmployee()
        {

            if(isAwake == false)
            {
                if(random.Next(100) < 10)
                {
                    this.isAwake = true;
                    GameObjectsCharacter = '$';
                }
            }else
            {
                if (random.Next(100) < 25)
                {
                    this.isAwake = false;
                    GameObjectsCharacter = 'Z';
           
                }else
                {
                    this.moveEmployee(random.Next(1,5)); 
                }
            }

        }


        public override void MoveObject(int direction)
        {
            if (isAwake == false)
            {
                isAwake = true;
                GameObjectsCharacter = '$';
            }
          
        }


        public void moveEmployee(int direction)
        {
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
            if (tile != null)
            {

                if (tile.ObjectOnTile != null)
                {
                    tile.ObjectOnTile.MoveObject(direction);
                }



                if (tile.CanEnter())
                {
                    tile.ChangeObjectOnTile(this);
                    StandsOnTile.DeleteObjectOnTile();
                    StandsOnTile = tile;
                    this.StandsOnTile.DeleteObjectOnTile();
                }

            }
        }
    }
}