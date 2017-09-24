﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class FileReader
    {
        private Maze maze;
        private FileStream input;
        private StreamReader reader;
        private string fileName;
        private int _inputFileReaderNumber;

        public FileReader(int inputFileReaderNumber)
        {
            this._inputFileReaderNumber = inputFileReaderNumber;
        }

        public Maze LoadMaze(int nummer)
        {
         
            this.maze = new Maze(nummer);
            return maze;
        }

        internal void CreateTiles()
        {
          
        }
    }
}