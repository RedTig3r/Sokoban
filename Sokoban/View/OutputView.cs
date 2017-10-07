using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {

        public void ShowGameInfo()
        {
            System.Console.WriteLine(" ___________________________________________________________");
            System.Console.WriteLine("|                                                          |");
            System.Console.WriteLine("|   Welkom bij Sokoban                                     |");
            System.Console.WriteLine("|                                                          |");
            System.Console.WriteLine("| Betekenis van symbolen        |   Doel van het spel      |");
            System.Console.WriteLine("|                               |                          |");
            System.Console.WriteLine("|    ' ' : Outerspace           |   Duw met de truck       |");
            System.Console.WriteLine("|    '#' : Muur                 |   de krat(ten)           |");
            System.Console.WriteLine("|    '.' : Vloer                |   naar de bestemming     |");
            System.Console.WriteLine("|    'o' : Krat                 |                          |");
            System.Console.WriteLine("|    '0' : Krat op bestemming   |                          |");
            System.Console.WriteLine("|    'x' : Bestemming           |                          |");
            System.Console.WriteLine("|    '@' : Truck                |                          |");
            System.Console.WriteLine("|    '$' : Employee - Wakker    |                          |");
            System.Console.WriteLine("|    'Z' : Employee - Slapend   |                          |");
            System.Console.WriteLine("|    '~' : Val                  |                          |");
            System.Console.WriteLine("|    ' ' : Valkuil              |                          |");
            System.Console.WriteLine("|__________________________________________________________|");
            Console.WriteLine("");

        }


        public void ShowGameProces(Maze maze)
        {
            System.Console.Clear();

            System.Console.WriteLine(" _________");
            System.Console.WriteLine("|         |");
            System.Console.WriteLine("| Sokoban |");
            System.Console.WriteLine("|_________|");
            System.Console.WriteLine("________________________________________________________");
            this.ShowMaze(maze);
            System.Console.WriteLine("________________________________________________________|");

        }

        public void MazeAccomplished()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("=== HOERA OPGELOST ===");
            System.Console.WriteLine("> press key to continue");
            System.Console.ReadKey();
        }


        public void ShowMaze(Maze maze)
        {

            if (maze.OriginalTile != null)
            {
                Tile tile = maze.OriginalTile;
                Tile downTile = tile;

                while (downTile != null)
                {
                    while (tile != null)
                    {
                        Console.Write(tile.GetTileGameObjectsCharacter());
                        tile = tile.RightTile;
                    }
                                
                    downTile = downTile.DownTile;
                    tile = downTile;
                    Console.WriteLine();
                }   

                Console.WriteLine();
            }           
        }


    }
}

