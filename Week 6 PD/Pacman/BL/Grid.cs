using Pacman.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.BL
{
    internal class Grid
    {
        public Cell[,] maze;
        public int rowSize;
        public int colSize;

        // parameterized constructor
        public Grid(int rowSize, int colSize, string path)
        {
            this.rowSize = rowSize;
            this.colSize = colSize;
            this.maze = new Cell [this.rowSize, this.colSize];
            loadMaze(path);
        }

        // return the left most cell
        public Cell getLeftCell(Cell c)
        {
            return maze[c.getY(), c.getX() - 1];
        }

        // return the right most cell
        public Cell getRightCell(Cell c)
        {
            return maze[c.getY(), c.getX() + 1];
        }

        // return the up most cell
        public Cell getUpCell(Cell c)
        {
            return maze[c.getY()-1, c.getX()];
        }

        // return the down most cell
        public Cell getDownCell(Cell c)
        {
            return maze[c.getY()+1, c.getX()];
        }

        // return the cell with pacman
        public Cell FindPacman()
        {
            foreach (Cell cell in maze)
            {
                if (cell.isPacmanPresent()) { return cell; }
            }
            return null;
        }

        // return the cell with ghost
        public Cell FindGhost(char ghost)
        {
            foreach (Cell cell in maze)
            {
                if (cell.isGhostPresent(ghost)) { return cell; }
            }
            return null;
        }

        // returns a bool if a certain condition is met
        public bool isStoppingCondition()
        {
            Cell p = this.FindPacman();
            if (this.isGhostPresent( this.getDownCell(p)) || this.isGhostPresent(this.getUpCell(p)) || this.isGhostPresent(this.getRightCell(p)) || this.isGhostPresent(this.getLeftCell(p)))
            {
                return true;
            }
            return false;
        }

        // returns true if ghost is present
        public bool isGhostPresent(Cell cell)
        {
            if (cell.value != ' ' && cell.value != '.' && cell.value != '#') { return true; }
            return false;
        }

        // draw the maze
        public void draw()
        {
            GridUI.print(this.maze, this.rowSize,this.colSize);
        }

        // read data from file
        public void loadMaze(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                int c = 0;
                while ((line = file.ReadLine()) != null)
                {
                    for (int i = 0; i < this.colSize; i++)
                    {
                        this.maze[c, i] = new Cell(line[i], i, c);
                    }
                    c++;
                }
                file.Close();
            }
            else
            {
                this.maze= null;
            }
        }
    }
}
