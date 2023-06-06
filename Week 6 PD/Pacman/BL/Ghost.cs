using Pacman.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.BL
{
    internal class Ghost
    {
        public int x;
        public int y;
        public string ghostDirection;
        public char ghostCharacter;
        public float speed;
        public char previousItem;
        public float deltaChange;
        public Grid mazeGrid;

        // parameterized constructor
        public Ghost(int x, int y, string ghostDirection, char ghostCharacter, float speed, char previousItem, Grid mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.ghostDirection = ghostDirection;
            this.ghostCharacter = ghostCharacter;
            this.speed = speed;
            this.previousItem = previousItem;
            this.mazeGrid = mazeGrid;
            this.deltaChange = 0;
            this.mazeGrid.maze[this.y, this.x].value = this.ghostCharacter;
        }

        // set direction of ghost
        public void setDirection(string ghostDirection) { this.ghostDirection=ghostDirection; }

        // get direction of ghost
        public string getDirection() { return this.ghostDirection;}

        // remove the ghost by placing the previous char on it's place
        public void remove()
        {
            GameUI.printChar(this.x, this.y, this.previousItem);
        }

        // draw the ghost 
        public void draw()
        {
            GameUI.printChar(this.x, this.y, this.ghostCharacter);
        }

        // returns the ghost character
        public char getCharacter() { return this.ghostCharacter; }

        // change the delta 
        public void changeDelta() { this.deltaChange += this.speed; }

        // return the delta
        public float getDelta() { return this.deltaChange; }

        // resets the delta to 0
        public void setDeltaZero() { this.deltaChange = 0; }

        // move ghost
        public void move()
        {
            this.changeDelta();
            if (Math.Floor(this.getDelta()) == 1)
            {
                if (this.ghostCharacter == 'H') { moveHorizontal(); }
                else if (this.ghostCharacter == 'V') { moveVertical(); }
                else if (this.ghostCharacter == 'R') { moveRandom(); }
                else if (this.ghostCharacter == 'S') { moveSmart(); }
                this.setDeltaZero();
            }
        }

        // horizontal movement
        public void moveHorizontal()
        {
            Cell g = this.mazeGrid.FindGhost(this.ghostCharacter);
            Cell next = null;

            if (this.ghostDirection == "right") { next = this.mazeGrid.getRightCell(g); }
            else if (this.ghostDirection == "left") { next = this.mazeGrid.getLeftCell(g); }

            if (next.value == ' ' || next.value == '.')
            {
                g.value = this.previousItem;
                this.previousItem = next.value;
                this.x = next.getX();
                next.value = this.ghostCharacter;
            }
            else if (next.value == '#')
            {
                if (this.ghostDirection == "right") { this.ghostDirection = "left"; }
                else if (this.ghostDirection == "left") { this.ghostDirection = "right"; }
            }
        }

        // vertical movement
        public void moveVertical()
        {
            Cell g = this.mazeGrid.FindGhost(this.ghostCharacter);
            Cell next = null;

            if (this.ghostDirection == "up") { next = this.mazeGrid.getUpCell(g); }
            else if (this.ghostDirection == "down") { next = this.mazeGrid.getDownCell(g); }

            if (next.value == ' ' || next.value == '.')
            {
                g.value = this.previousItem;
                this.previousItem = next.value;
                this.y = next.getY();
                next.value = this.ghostCharacter;
            }
            else if (next.value == '#')
            {
                if (this.ghostDirection == "up") { this.ghostDirection = "down"; }
                else if (this.ghostDirection == "down") { this.ghostDirection = "up"; }
            }
        }

        // generate random value for movement of random ghost
        public int generateRandom()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }

        // movement of random ghost
        public void moveRandom()
        {
            int random = this.generateRandom();
            if (random == 1) { this.ghostDirection = "left"; this.moveHorizontal(); }
            else if (random == 2) { this.ghostDirection = "right"; this.moveHorizontal(); }
            else if (random == 3) { this.ghostDirection = "up"; this.moveVertical(); }
            else if (random == 4) { this.ghostDirection = "down"; this.moveVertical(); }
        }

        // smart ghost movement
        public void moveSmart()
        {
            Cell p = this.mazeGrid.FindPacman();
            Cell g = this.mazeGrid.FindGhost(this.ghostCharacter);
            double[] distance = new double[4] { 10000000, 10000000, 10000000, 10000000 };
            if (this.mazeGrid.getDownCell(g).value != '|' || this.mazeGrid.getDownCell(g).value != '#')
            {
                distance[0] = this.calculateDistance(this.mazeGrid.getDownCell(g), p);
            }
            if (this.mazeGrid.getUpCell(g).value != '|' || this.mazeGrid.getUpCell(g).value != '#')
            {
                distance[1] = this.calculateDistance(this.mazeGrid.getUpCell(g), p);
            }
            if (this.mazeGrid.getRightCell(g).value != '|' || this.mazeGrid.getRightCell(g).value != '#')
            {
                distance[2] = this.calculateDistance(this.mazeGrid.getRightCell(g), p);
            }
            if (this.mazeGrid.getLeftCell(g).value != '|' || this.mazeGrid.getLeftCell(g).value != '#')
            {
                distance[3] = this.calculateDistance(this.mazeGrid.getLeftCell(g), p);
            }
            if (distance[0] < distance[1] && distance[0] < distance[2] && distance[0] < distance[3])
            {
                this.ghostDirection = "down";
                this.moveVertical();
            }
            else if (distance[1] < distance[0] && distance[1] < distance[2] && distance[1] < distance[3])
            {
                this.ghostDirection = "up";
                this.moveVertical();
            }
            else if (distance[2] < distance[1] && distance[2] < distance[0] && distance[2] < distance[3])
            {
                this.ghostDirection = "right";
                this.moveHorizontal();
            }
            else if (distance[3] < distance[1] && distance[3] < distance[2] && distance[3] < distance[0])
            {
                this.ghostDirection = "left";
                this.moveHorizontal();
            }
        }

        // caculate distance between ghost and pacman
        public double calculateDistance(Cell current, Cell pacman)
        {
            return Math.Sqrt(Math.Pow(current.getX() - pacman.getX(), 2) + Math.Pow(current.getY()-pacman.getY(), 2));
        }
    }
}
