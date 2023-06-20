using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pacman.GL
{
    internal class GameGrid
    {
        private List<List<GameCell>> cells;
        private int height;
        private int width;

        public  List<List<GameCell>> Cells { get => cells; set => cells = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        // parameterized constructor
        public GameGrid(string path, int height, int width)
        {
            this.Height = height;
            this.Width = width;
            Cells = new List<List<GameCell>>();
            loadMaze(path);
        }

        // get cell
        public GameCell getCell(int x, int y)
        {
            return cells[y][x];
        }

        // get appropriate game object
        public GameObject appropriateGameObject(char letter)
        {
            if (letter == ' ') { return new GameObject(letter, GameObjectType.NONE); }
            else if (letter == 'P') { return new GameObject(letter, GameObjectType.PLAYER); }
            else if (letter == 'G') { return new GameObject(letter, GameObjectType.ENEMY); }
            else if (letter == '.') { return new GameObject(letter, GameObjectType.REWARD); }
            return new GameObject(letter, GameObjectType.WALL);
        }

        // load maze
        protected void loadMaze(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                int y = 0;
                while ((line = file.ReadLine()) != null)
                {
                    List<GameCell> cellsTemp = new List<GameCell>();
                    for (int x = 0; x < line.Count(); x++)
                    {
                        GameCell cell = new GameCell(x, y, appropriateGameObject(line[x]));
                        cellsTemp.Add(cell);
                    }
                    y++;
                    Cells.Add(cellsTemp);
                }
            }
        }
    }
}
