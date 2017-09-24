using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{



    public class Crate 
    {

        private Tile _tileLocation;
        private bool _standsOnTileDirection;

        public Crate(Tile tileLocation)
        {
            _tileLocation = tileLocation;


        }

        public void MoveCrate(Tile tileLocation)
        {
            if (tileLocation.CanEnter() == true)
            {
              _tileLocation = tileLocation;
            }
         
        }

        public bool getStandsOnTileDirection()
        {
            if (_tileLocation.tileType == TileTypes.CrateDestination)
            {
                _standsOnTileDirection = true;

                return _standsOnTileDirection;
            }else
            {
                _standsOnTileDirection = false;
                return _standsOnTileDirection;
            }
        }
    
    }
}



   
