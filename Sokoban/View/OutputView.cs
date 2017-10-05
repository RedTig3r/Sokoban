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
            System.Console.WriteLine(" _______________________________________________________");
            System.Console.WriteLine("|                                                       |");
            System.Console.WriteLine("|   Welkom bij Sokoban                                  |");
            System.Console.WriteLine("|                                                       |");
            System.Console.WriteLine("| Betekenis van symbolen     |   Doel van het spel      |");
            System.Console.WriteLine("|                            |                          |");
            System.Console.WriteLine("| spatie : outerspace        |   Duw met de truck       |");
            System.Console.WriteLine("|      \u2588 : muur              |   de krat(ten)           |");
            System.Console.WriteLine("|      * : vloer             |   naar de bestemming     |");
            System.Console.WriteLine("|      O : krat              |                          |");
            System.Console.WriteLine("|      Θ : krat op bestemming|                          |");
            System.Console.WriteLine("|      X : bestemming        |                          |");
            System.Console.WriteLine("|      @ : truck             |                          |");
            System.Console.WriteLine("|_______________________________________________________|");
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
            /*
            int height = maze.Heigth;
            int width = maze.Width;
            Tile tile = maze.OriginTile;
            Tile tileUnder = tile.DownTile;

            for (int index1 = 0; index1 < height; index1++)
            {
                for (int index2 = 0; index2 < width; index2++)
                {
                    switch (tile.kind)
                    {
                        case Kind.floor:
                            if (tile.hasCrate)
                            {
                                System.Console.Write("O");
                                break;
                            }
                            if (tile.hasTruck)
                            {
                                System.Console.Write("@");
                                break;
                            }
                            System.Console.Write(".");
                            break;
                        case Kind.wall:
                            System.Console.Write("█");
                            break;
                        case Kind.target:
                            if (tile.hasCrate)
                            {
                                System.Console.Write("0");
                                break;
                            }
                            if (tile.hasTruck)
                            {
                                System.Console.Write("@");
                                break;
                            }
                            System.Console.Write("x");
                            break;
                        case Kind.space:
                            System.Console.Write(" ");
                            break;
                        default:
                            System.Console.Write("?");
                            break;
                    }
                    tile = tile.RightTile;
                }
                tile = tileUnder;
                if (tileUnder != null)
                {
                    tileUnder = tile.DownTile;
                    System.Console.WriteLine();
                }
            }
                */
        }


    }
}

