using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.UI;

namespace Game.BL
{
    internal class GameObject
    {
        public char[,] shape;
        public Point startingPoint;
        public Boundary premises;
        public string direction;
        public char[,] body;

        // default constructor
        public GameObject()
        {
            this.shape = new char[,] { {'_', '_', '_' } };
            this.startingPoint = new Point();
            this.premises = new Boundary();
            this.direction = "LeftToRight";
            makeBody();
        }

        // paritally parameterized constructor
        public GameObject(char[,] shape, Point startingPoint)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = new Boundary();
            this.direction = "LeftToRight";
            makeBody();
        }

        // fully parameterized constructor
        public GameObject(char[,] shape, Point startingPoint, string direction, Boundary premises)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = premises;
            this.direction = direction;
            makeBody();
        }

        // erase character array
        public void makeBody() 
        {
            this.body = this.shape;
            for (int i = 0; i < this.body.GetLength(0); i++)
            {
                for (int j = 0; j < this.body.GetLength(1); j++)
                {
                    this.body[i, j] = ' ';
                }
            }
        }

        // left to right
        public void leftToRight()
        {
            int x = this.startingPoint.getX();
            while (x < this.premises.bottomRight.getX())
            {
                GameObjectUI.printCharacter(x, this.startingPoint.getY(), this.shape);
                this.startingPoint.setX(x + 1);
            }
        }

        // right to left
        public void rightToLeft()
        {
            int x = this.startingPoint.getX();
            while (x > this.premises.bottomLeft.getX())
            {
                GameObjectUI.printCharacter(x, this.startingPoint.getY(), shape);
                this.startingPoint.setX(x - 1);
            }
        }

        // start from starting point and move
        // towards left and reverses direction
        public void patrol()
        {
            this.leftToRight();
            this.rightToLeft();
        }

        // projectile motion
        public void projectile()
        {
            int i = 0;
            string up = "up";
            while (this.startingPoint.getX() < this.premises.bottomRight.getX() -1)
            {
                i++;
                erase();
                this.startingPoint.setX(this.startingPoint.getX()+1);
                if (up == "up")
                {
                    this.startingPoint.setY(this.startingPoint.getY() - 1);
                    GameObjectUI.printCharacter(this.startingPoint.getX(), this.startingPoint.getY(), this.shape);
                }
                if (i == 5) { up = "down"; }
                if (up == "down")
                {
                    this.startingPoint.setY(this.startingPoint.getY() + 1);
                    GameObjectUI.printCharacter(this.startingPoint.getX(), this.startingPoint.getY(), this.shape);
                }
                if (i == 10) { break; }
            }
        }

        // from starting point to the bottom right diagonal
        public void diagonal()
        {
            int y;
            int x = this.startingPoint.getX();
            while (this.startingPoint.getX() < this.premises.bottomRight.getX())
            {
                x++;
                y = this.diagonalEquation(x);
                GameObjectUI.printCharacter(x, y, shape);
                this.startingPoint.setXY(x, y);
            }
        }

        // get gradient
        public float getGradient()
        {
            return (float)(this.startingPoint.getY() - this.premises.bottomRight.getY()) / (this.startingPoint.getX() - this.premises.bottomRight.getX());
        }

        // equation of a diagonal -> y = m(x-X)+Y --> it basically returns the value of y
        public int diagonalEquation(int x)
        {
            return (int)Math.Round(getGradient() * (x - this.premises.bottomRight.getX()) + this.premises.bottomRight.getY());
        }

        // move 
        public void move()
        {
            if (this.direction == "LeftToRight") { this.leftToRight(); }
            else if (this.direction == "RightToLeft") { this.rightToLeft(); }
            else if (this.direction == "Patrol") { this.patrol(); }
            else if (this.direction == "Projectile") { this.projectile(); }
            else if (this.direction ==  "Diagonal") { this.diagonal(); }
        }

        // erase character
        public void erase()
        {   
            GameObjectUI.printCharacter(this.startingPoint.getX(), this.startingPoint.getY(), this.body);
        }

        // draw the shape on console
        public void draw()
        {
            GameObjectUI.printCharacter(this.startingPoint.getX(), this.startingPoint.getY(), this.shape);
        }
    }
}
