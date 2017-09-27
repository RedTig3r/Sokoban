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
        private int _inputFileReaderNumber;

        private List<Tile> ConstructLine(string line, int x)
        {
            List<Tile> tileList = new List<Tile>();
            

            for (int i = 0; i < line.Length; i++)
            {
                ObjectEnum _enum;

                switch (line[i])
                {
                    case ' ':
                        _enum = ObjectEnum.Space;
                        break;
                    case '█':
                        _enum = ObjectEnum.Wall;
                        break;
                    case '.':
                        _enum = ObjectEnum.Floor;
                        break;
                    case 'x':
                        _enum = ObjectEnum.Destination;
                        break;
                    case '@':
                    case 'o':
                    default:
                        throw new Exception("Bestand fout");
                }
                Tile leftTile = null;
                Tile rightTile = null;
                if (leftTile != null)
                {
                    rightTile.LeftTile = leftTile;
                    leftTile.RightTile = rightTile;
                }
                leftTile = rightTile;
                tileList.Add(rightTile);
                if ((int)line[i] == 64)
                {
                    Truck truck = new Truck(rightTile);
                    this._maze.Truck = truck;
                    rightTile.truck = truck;
                }
                if ((int)line[i] == 111)
                {
                    Crate k = new Crate(rightTile);
                    this._maze.CrateList.Add(k);
                    rightTile.crate = k;
                }
            }    
            
            return tileList;
        }
        
               

       private void MakeApplication()
        {
            this._input = new FileStream(this._fileName, FileMode.Open, FileAccess.Read);
            this._reader = new StreamReader((Stream)this._input);
            int num1 = 0;
            int num2 = 0;

            try
            {
                string str = this._reader.ReadLine();
                do
                {
                    if (str != null)
                    {
                        if (str.Length > num1)
                            num1 = str.Length;
                        ++num2;
                        str = this._reader.ReadLine();
                    }
                    else
                    {
                        this._reader.Close();
                        this._input.Close();
                    }
                }
                while (str != null);
                this._maze.MazeWidth = num1;
                this._maze.MazeHeight = num2;
            }
            catch 
            {
                throw;
            }

        }

        public Maze LoadMaze(int number) {

            this._maze = new Maze();
            this._fileName = ".\\Doolhof\\doolhof" + number + ".text";
            List<Tile> pastTile = null;
            int x = 0;

            try
            {
                this.MakeApplication();
                this._input = new FileStream(this._fileName, FileMode.Open, FileAccess.Read);
                this._reader = new StreamReader(this._input);
                string inregel = this._reader.ReadLine();
                do
                {
                    if (inregel != null)
                    {
                        List<Tile> currentTile = this.ConstructLine(inregel, x);
                        if (pastTile != null)
                            this.ConnectLines(pastTile, currentTile);
                        else
                            this._maze.OriginalTile = currentTile[0];
                        pastTile = currentTile;
                        x++;
                        inregel = this._reader.ReadLine();
                    }
                    else
                    {
                        this._reader.Close();
                        this._input.Close();
                    }
                }
                while (inregel != null);
                return this._maze;
            }
            catch
            {
                throw new Exception("Bestand fout"); ;
            }            

        }

        private void ConnectLines(List<Tile> pastTile, List<Tile> currentTile)
        {
            for (int i = 0; i < currentTile.Count; ++i)
            {
                if (pastTile[i] != null && currentTile[i] != null)
                {
                    currentTile[i].UpTile = pastTile[i];
                    pastTile[i].DownTile = currentTile[i];
                }
            }
        }

        public Maze CreateMaze(int _mazeNumber)
        {
            return new Maze();
        }

        public Maze ResetMaze()
        {
            return _maze;
        }
    }
}