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
            System.Console.WriteLine("|    ' ' : outerspace           |   Duw met de truck       |");
            System.Console.WriteLine("|    '#' : muur                 |   de krat(ten)           |");
            System.Console.WriteLine("|    '.' : vloer                |   naar de bestemming     |");
            System.Console.WriteLine("|    'o' : krat                 |                          |");
            System.Console.WriteLine("|    '0' : krat op bestemming   |                          |");
            System.Console.WriteLine("|    'x' : bestemming           |                          |");
            System.Console.WriteLine("|    '@' : truck                |                          |");
            System.Console.WriteLine("|    '$' : Employee - Awak      |                          |");
            System.Console.WriteLine("|    'Z' : Employee - sleeping  |                          |");
            System.Console.WriteLine("|    '~' : Trap                 |                          |");
            System.Console.WriteLine("|    ' ' : Trap Hole            |                          |");
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
                Tile downTile = tile.DownTile;

                while (downTile != null)
                {
                    while (tile != null)
                    {

                        Console.Write(tile.GetTileGameObjectsCharacter());
                        tile = tile.RightTile;
                    }

                    tile = downTile;
                    downTile = downTile.DownTile;
                    Console.WriteLine();

                }

                while (tile != null)
                {

                    Console.Write(tile.GetTileGameObjectsCharacter());
                    tile = tile.RightTile;
                }

                Console.WriteLine();
            }

            

        }

    }



}

