using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        public Tile OriginalTile { get; set; }
        public Truck Truck { get; set; }

        public Employee Employee { set; get; }

        public List <Crate> CrateList { get; set; }

        public int MazeWidth { get; set; }
        public int Mazeheight { get; set; }


        public void MoveTruck(int direction)
        {
            if (Truck != null)
            {
                Truck.MoveObject(direction);

            }
      
        }

        public void MoveEmployee()
        {
            if (Employee != null)
            {
                Employee.UseEmployee();

            }

        }


        public void AddCrate(Crate crate)
        {
            if (CrateList != null)
            {
                CrateList.Add(crate);
            }
        }

        public bool gameIsFinished()
        {
            if (CrateList != null)
            {
                int amountOfCrates = this.CrateList.Count;
                int x = 0;
                foreach (Crate crate in this.CrateList)
                {
                    if (crate.getStandsOnTileDirection() == true)
                    {
                        x++;
                    }
                }


                if (amountOfCrates == x)
                {
                    return true;
                }
            }
           
           
                return false;
           

        }

    }
}