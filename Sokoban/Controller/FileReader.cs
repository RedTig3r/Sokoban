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