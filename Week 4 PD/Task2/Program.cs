using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using EZInput;
using Task2.BL;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(15,5, "right"); 
            Enemy e = new Enemy(5,5, "up");
            List<Bullet> bullets = new List<Bullet>();

            char[,] maze = new char[16, 75];
            loadMaze("maze.txt", maze);
            printMaze(maze);

            printPlayerRight(p);
            printEnemy(e);
            game(p, e, maze, bullets);
        }

        static void game(Player p, Enemy e, char[,] maze, List<Bullet> bullets)
        {
            int c = 0, score = 0;
            addScore(ref score);
            playerHealth(p);
            while (!Keyboard.IsKeyPressed(Key.Escape) && p.health > 0)
            {
                if (Keyboard.IsKeyPressed(Key.UpArrow) && maze[p.y - 1, p.x] != '#')
                {
                    erasePlayer(p);
                    p.moveUp();
                    printplayerwithdirection(p);
                }
                else if (Keyboard.IsKeyPressed(Key.RightArrow) && maze[p.y, p.x + 3] != '#')
                {
                    erasePlayer(p);
                    p.moveRight();
                    printplayerwithdirection(p);
                }
                else if (Keyboard.IsKeyPressed(Key.LeftArrow) && maze[p.y, p.x - 1] != '#')
                {
                    erasePlayer(p);
                    p.moveLeft();
                    printplayerwithdirection(p);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow) && maze[p.y + 3, p.x] != '#')
                {
                    erasePlayer(p);
                    p.moveDown();
                    printplayerwithdirection(p);
                }
                else if (Keyboard.IsKeyPressed(Key.Space) && ((maze[p.y, p.x - 1] != '#' && p.direction == "left") || (maze[p.y, p.x + 1] != '#' && p.direction == "right")))
                {
                    generatebullet(p, bullets);
                }
                moveEnemy(e, maze, p, bullets);
                movebullet(bullets);
                Player_bullet_collision(maze, bullets, e, ref score);
                Enemy_bullet_collision(maze, bullets, p);
                if (c == 100)
                {
                    remove_bullets(bullets);
                    c = 0;
                }
                c++;
                Thread.Sleep(20);
            }
        }

        static void generatebullet(Player p, List<Bullet> bullets)
        {
            // right hand side
            if (p.direction == "right")
            {
                Bullet bullet = new Bullet(p.x+3, p.y+1, "right", true, "Player", ".");
                bullets.Add(bullet);
                bullet.printBullet();
            }
            // left hand side
            else if (p.direction == "left")
            {
                Bullet bullet = new Bullet(p.x -1, p.y + 1, "left", true, "Player", ".");
                bullets.Add(bullet);
                bullet.printBullet();
            }
        }

        // moves a bullet
        static void movebullet(List<Bullet> bullets)
        {
            foreach (Bullet bullet in bullets)
            {
                bullet.moveBullet();
            }
        }

        // detects bullet collision with maze
        static void Player_bullet_collision(char[,] maze, List<Bullet> bullets, Enemy e, ref int score)
        {
            foreach (Bullet bullet in bullets)
            {
                if (bullet.user == "Player")
                {
                    int x = 0;
                    if (bullet.direction == "right")
                    {
                        x = bullet.x + 1;
                    }
                    else if (bullet.direction == "left")
                    {
                        x = bullet.x - 1;
                    }
                    int y = bullet.y;
                    if (maze[y, x] == '#' && bullet.isActive)
                    {
                        bullet.isActive = false;
                        bullet.eraseBullet();
                    }
                    else if (x == e.x + 3 && (y == e.y || y == e.y + 1 || y == e.y + 2))
                    {
                        bullet.isActive = false;
                        bullet.eraseBullet();
                        addScore(ref score);
                    }
                }
            }
        }

        // removes bullets from maze
        static void remove_bullets(List<Bullet> bullets)
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].isActive)
                {
                    bullets.RemoveAt(i);
                }
            }
        }

        // adds and print score
        static void addScore(ref int score)
        {
            score++;
            Console.SetCursorPosition(90, 15);
            Console.Write("Score: " + score);
        }

        // prints player with direction
        static void printplayerwithdirection(Player p)
        {
            if (p.direction == "right")
            {
                printPlayerRight(p);
            }
            else
            {
                printPlayerLeft(p);
            }
        }

        static void printMaze(char[,] maze)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x, y]);
                }
                Console.WriteLine();
            }
        }

        // enemy movement
        static void moveEnemy(Enemy e, char[,] maze, Player p, List<Bullet> bullets)
        {
            if (e.y == p.y || e.y + 1 == p.y || e.y + 2 == p.y)
            {
                generateEnemybullet(e, bullets);
            }
            if (e.direction == "up")
            {
                if (maze[e.y - 1, e.x] == '#')
                {
                    e.direction = "down";
                }
                else
                {
                    eraseEnemy(e);
                    e.y--;
                    printEnemy(e);
                }
            }
            if (e.direction == "down")
            {
                if (maze[e.y + 3, e.x] == '#')
                {
                    e.direction = "up";
                }
                else
                {
                    eraseEnemy(e);
                    e.y++;
                    printEnemy(e);
                }
            }
        }

        // generates enemy bullet
        static void generateEnemybullet(Enemy e, List<Bullet> bullets)
        {
            Bullet bullet = new Bullet(e.x+3, e.y+1, "right", true, "Enemy", ".");
            bullets.Add(bullet);
            bullet.printBullet();
        }

        // detects bullet collision 
        static void Enemy_bullet_collision(char[,] maze, List<Bullet> bullets, Player p)
        {
            foreach (Bullet bullet in bullets)
            {
                if (bullet.user == "Enemy")
                {
                    int x = bullet.x - 1;
                    if (bullet.direction == "right")
                    {
                        x = bullet.x + 1;
                    }
                    int y = bullet.y;
                    if (maze[y, x] == '#' && bullet.isActive)
                    {
                        bullet.isActive = false;
                        bullet.eraseBullet();
                    }
                    else if (x == p.x + 3 && (y == p.y || y == p.y + 1 || y == p.y + 2))
                    {
                        bullet.isActive = true;
                        bullet.eraseBullet();
                        p.health -= 5;
                        playerHealth(p);
                    }
                }
            }
        }

        // prints health of player
        static void playerHealth(Player p)
        {
            Console.SetCursorPosition(90, 16);
            Console.Write("Player Health: " + p.health);
        }

        // prints characters
        static void printEnemy(Enemy e)
        {
            char[,] body = { { ' ', 'E', ' ' }, { '(', 'L', '=' }, { '/', ')', ' ' } };
            e.printEnemy(body);
        }

        static void eraseEnemy(Enemy e)
        {
            char[,] body = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            e.printEnemy(body);
        }

        static void printPlayerRight(Player p)
        {
            char[,] body = { { ' ', 'P', ' ' }, { '(', 'L', '=' }, { '/', ')', ' ' } };
            p.printPlayer(body);
        }

        static void printPlayerLeft(Player p)
        {
            char[,] body = { { ' ', '0', ' ' }, { '=', 'j', ')' }, { ' ', '(', '\\' } };
            p.printPlayer(body);
        }

        static void erasePlayer(Player p)
        {
            char[,] body = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            p.printPlayer(body);
        }

        static void loadMaze(string path, char[,] maze)
        {
            StreamReader fp = new StreamReader(path);
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < 75; x++)
                {
                    maze[row, x] = record[x];
                }
                row++;
            }

            fp.Close();
        }
    }
}