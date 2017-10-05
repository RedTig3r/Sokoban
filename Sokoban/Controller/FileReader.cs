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



        public FileReader()
        {
        
        }

        public Maze ResetMaze(int mazeNumber)
        {
            if (_maze != null)
            {
                return _maze;
            }
            else
            {
                return this.CreateMaze(mazeNumber);
            }

        }

        public Maze CreateMaze(int mazeNumber)
        {
            this._maze = new Maze();
            this._fileName = "..\\..\\Doolhof\\doolhof" + mazeNumber + ".txt";

            _reader = new StreamReader(_fileName);

            List<Tile> pastTile = null;


      

            /*

       this._input = new FileStream(this._fileName, FileMode.Open, FileAccess.Read);
       this._reader = new StreamReader((Stream)this._input);
       int num1 = 0;
       int num2 = 0;

       try
       {
           string s = this._reader.ReadLine();
           do
           {
               if (s != null)
               {
                   if (s.Length > num1)
                   {
                       num1 = s.Length;
                       num2++;
                       s = this._reader.ReadLine();
                   }
                   else
                   {
                       this._reader.Close();
                       this._input.Close();
                   }
               }
               while (s != null)
               {
                   this._maze.Width = num1;
                   this._maze.Heigth = num2;
               }
           }
       catch
       {
           throw;
       }

       */


            return new Maze();
        }

   

     



    }
}