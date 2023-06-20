using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class GameCell
    {
        private int x;
        private int y;
        private GameObject gameObject;
        private GameGrid grid;

        // default parameter
        public GameCell() { }

        // parameterized constructor
        public GameCell(int x, int y, GameObject gameObject)
        {
            this.x = x;
            this.y = y;
            this.gameObject = gameObject;
            this.Grid = null;
        }

        public GameCell(int x, int y, GameGrid grid)
        {
            this.x = x;
            this.y = y;
            this.gameObject = null;
            this.Grid = grid;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public GameObject Object { get => gameObject; set => gameObject = value; }
        public GameGrid Grid { get => grid; set => grid = value; }

        // return next cell
        public GameCell NextCell(GameDirection direction)
        {
            GameCell cell = new GameCell();

            if (direction == GameDirection.Left) 
            {
                cell =  Grid.Cells[this.Y][this.X - 1];         // getting cell from grid
            }
            else if (direction == GameDirection.Right) 
            {
                cell = Grid.Cells[this.Y][this.X + 1]; 
            }
            else if (direction == GameDirection.Up) 
            {
                cell =  Grid.Cells[this.Y - 1][this.X];
            }
            else if (direction == GameDirection.Down) 
            {
                cell = Grid.Cells[this.Y + 1][this.X]; 
            }

            if (okToMove(cell)) { return cell; }            // return after checking to move
            return null;
        }

        // is ok to move for pacman
        public bool okToMove(GameCell cell)
        {
            if (cell.Object.Type == GameObjectType.REWARD || cell.Object.Type == GameObjectType.NONE)
            {
                return true;
            }
            return false;
        }
    }
}
