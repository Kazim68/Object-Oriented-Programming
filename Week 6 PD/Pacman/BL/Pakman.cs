using Pacman.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.Threading;

namespace Pacman.BL
{
    internal class Pakman
    {
        public int x; 
        public int y;
        public int score;
        public Grid maze;

        // parameterized constructor
        public Pakman(int x, int y, Grid maze)
        {
            this.x = x;
            this.y = y;
            this.maze = maze;
            this.score = 0;
            this.maze.maze[this.y, this.x].value = 'P';
        }

        // remove the pacman from screen
        public void remove()
        {
            GameUI.printChar(this.x, this.y, ' ');
        }

        // draw the pacman
        public void draw()
        {
            GameUI.printChar(this.x, this.y, 'P');
        }

        // increment the score
        public void addScore(Cell next)
        {
            if (next.value == '.') { this.score++; }
        }

        // left movement
        public void moveLeft(Cell next, Cell current)
        {
            if (next.value == ' ' || next.value == '.')
            {
                this.addScore(next);
                current.value = ' ';
                this.x = next.getX();
                next.value = 'P';
            }
        }

        // right movement
        public void moveRight(Cell next, Cell current)
        {
            if (next.value == ' ' || next.value == '.')
            {
                this.addScore(next);
                current.value = ' ';
                this.x = next.getX();
                next.value = 'P';
            }
        }

        // up movement
        public void moveUp(Cell next, Cell current)
        {
            if (next.value == ' ' || next.value == '.')
            {
                this.addScore(next);
                current.value = ' ';
                this.y = next.getY();
                next.value = 'P';
            }
        }

        // down movement
        public void moveDown(Cell next, Cell current)
        {
            if (next.value == ' ' || next.value == '.')
            {
                this.addScore(next);
                current.value = ' ';
                this.y = next.getY();
                next.value = 'P';
            }
        }

        // move functionality
        public void move()
        {
            Cell p = this.maze.FindPacman();
            if (Keyboard.IsKeyPressed(Key.UpArrow)) { this.moveUp(this.maze.getUpCell(p), p); }
            else if (Keyboard.IsKeyPressed(Key.DownArrow)) { this.moveDown(this.maze.getDownCell(p), p); }
            else if (Keyboard.IsKeyPressed(Key.RightArrow)) { this.moveRight(this.maze.getRightCell(p), p); }
            else if (Keyboard.IsKeyPressed(Key.LeftArrow)) { this.moveLeft(this.maze.getLeftCell(p), p); }
            else if (Keyboard.IsKeyPressed(Key.Escape)) { pause(); }
        }

        // print score
        public void printScore()
        {
            GameUI.printScore(this.score);
        }

        // pause 
        public void pause()
        {
            Thread.Sleep(1000);
            while(true)
            {
                if (Keyboard.IsKeyPressed(Key.Escape)) { break; }
            }
        }
    }
}
