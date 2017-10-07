using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class FileReader
    {
        private Maze _maze;
        private FileStream _input;
        private StreamReader _reader;
        private string _fileName;


        public Maze CreateMaze(int mazeNumber)
        {
            try
            {
                this._maze = new Maze();
                this._fileName = "..\\..\\Doolhofs\\doolhof" + mazeNumber + ".txt";

                _reader = new StreamReader(_fileName);

                List<Tile> currentTileList = new List<Tile>();
                List<Tile> previousTileList = null;


                this._input = new FileStream(this._fileName, FileMode.Open, FileAccess.Read);   
                this._reader = new StreamReader(this._input);
                string lineString = this._reader.ReadLine();   

                while (lineString != null)
                {
                    currentTileList = new List<Tile>();

                    Tile currentTile = null;
                    Tile previousTile = null;

                    for (int x = 0; x < lineString.Length; x++)
                    {
                        currentTile = null;

                        switch (lineString[x])
                        {
                            case 'x':
                                currentTile = new Destination();
                                break;
                            case '~':
                                currentTile = new Trap();
                                break;
                            case 'Z':
                                currentTile = new Floor();

                                Employee employeeASleep = new Employee(currentTile, false);
                                currentTile.ObjectOnTile = employeeASleep;
                                _maze.Employee = employeeASleep;
                                break;
                            case 'o':
                                currentTile = new Floor();

                                Crate crateNormal = new Crate(currentTile);
                                _maze.AddCrate(crateNormal);
                                currentTile.ObjectOnTile = crateNormal;

                                break;
                            case '0':
                                currentTile = new Destination();

                                Crate crateOnDestination = new Crate(currentTile);
                                _maze.AddCrate(crateOnDestination);
                                currentTile.ObjectOnTile = crateOnDestination;
                                break;
                            case '$':
                                currentTile = new Floor();

                                Employee employeeAwake = new Employee(currentTile, true);
                                currentTile.ObjectOnTile = employeeAwake;
                                _maze.Employee = employeeAwake;
                                break;
                            case '.':
                                currentTile = new Floor();
                                break;
                            case '@':
                                currentTile = new Floor();

                                Truck truck = new Truck(currentTile);
                                currentTile.ObjectOnTile = truck;
                                _maze.Truck = truck;
                                break;
                            case ' ':
                                currentTile = new EmptySpot();
                                break;
                            case '#':
                                currentTile = new Wall();
                                break;
                            default:
                                break;
                        }
                        if (previousTile != null)
                        {
                            currentTile.LeftTile = previousTile;
                            previousTile.RightTile = currentTile;
                        }
                        previousTile = currentTile;
                        currentTileList.Add(currentTile);
                    }

                    if (previousTileList != null)
                    {
                        for (int i = 0; i < currentTileList.Count; i++)
                        {
                            currentTileList[i].UpTile = previousTileList[i];
                            previousTileList[i].DownTile = currentTileList[i];
                        }
                    }
                    else
                    {
                        this._maze.OriginalTile = currentTileList[0];
                    }
                    
                    previousTileList = currentTileList;
                    
                    lineString = this._reader.ReadLine();
                }

                this._reader.Close();
                this._input.Close();
                
                return _maze;
            }
            catch
            {
                throw;
            }
        }



    }
}