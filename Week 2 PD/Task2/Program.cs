using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            string direction = "right";
            Player p = new Player();
            Enemy e = new Enemy();
            List<int> pbullets_x_right = new List<int>(), pbullets_y_right = new List<int>(), pbullets_x_left = new List<int>(), pbullets_y_left = new List<int>();
            List<int> ebullets_x_right = new List<int>(), ebullets_y_right = new List<int>(), ebullets_x_left = new List<int>(), ebullets_y_left = new List<int>();
            p.xpos = 15;
            p.ypos = 5;
            e.xpos = 5;
            e.ypos = 5;
            e.direction = "up";
            char[,] maze = new char[16,75];
            loadMaze("maze.txt", maze);
            printMaze(maze);
            printPlayerRight(p);
            printEnemy(e);
            game(p, e, maze, direction, pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, ebullets_x_right, ebullets_y_right, ebullets_x_left, ebullets_y_left);
        }

        static void game(Player p, Enemy e, char[,] maze, string direction, List<int> pbullets_x_right, List<int> pbullets_y_right, List<int> pbullets_x_left, List<int> pbullets_y_left, List<int> ebullets_x_right, List<int> ebullets_y_right, List<int> ebullets_x_left, List<int> ebullets_y_left)
        {
            int c = 0;
            List<bool> r_bullets_active = new List<bool>(), l_bullets_active = new List<bool>(), er_bullets_active = new List<bool>();
            while (!Keyboard.IsKeyPressed(Key.Escape))
            {
                if (Keyboard.IsKeyPressed(Key.UpArrow) && maze[p.ypos -1, p.xpos] != '#')
                {
                    erasePlayer(p);
                    p.ypos--;
                    printplayerwithdirection(p, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.RightArrow) && maze[p.ypos, p.xpos +3] != '#')
                {
                    erasePlayer(p);
                    p.xpos++;
                    direction = "right";
                    printplayerwithdirection(p, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.LeftArrow) && maze[p.ypos, p.xpos-1] != '#')
                {
                    erasePlayer(p);
                    p.xpos--;
                    direction = "left";
                    printplayerwithdirection(p, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow) && maze[p.ypos+3, p.xpos] != '#')
                {
                    erasePlayer(p);
                    p.ypos++;
                    printplayerwithdirection(p, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.Space) && ((maze[p.ypos, p.xpos-1] != '#' && direction == "left") || (maze[p.ypos, p.xpos + 1] != '#' && direction == "right")))
                {
                    generatebullet(p, direction, pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, r_bullets_active, l_bullets_active);
                }
                moveEnemy(e, maze, p, ebullets_x_right, ebullets_y_right, ebullets_x_left, ebullets_y_left, er_bullets_active);
                movebullet(pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, r_bullets_active, l_bullets_active);
                moveEnemybullet(ebullets_x_right, ebullets_y_right, ebullets_x_left, ebullets_y_left, er_bullets_active);
                Player_bullet_collision(maze, pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, r_bullets_active, l_bullets_active);
                Enemy_bullet_collision(maze, ebullets_x_right, ebullets_y_right, ebullets_x_left, ebullets_y_left, er_bullets_active);
                if (c == 100)
                {
                    remove_bullets(pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, r_bullets_active, l_bullets_active);
                    c = 0;
                }
                c++;
                Thread.Sleep(20);
            }
        }

        static void generatebullet(Player p, string direction, List<int> pbullets_x_right, List<int> pbullets_y_right, List<int> pbullets_x_left, List<int> pbullets_y_left, List<bool> r_bullets_active, List<bool> l_bullets_active)
        {
            // right hand side
            if (direction == "right")
            {
                pbullets_x_right.Add(p.xpos + 3);
                pbullets_y_right.Add(p.ypos + 1);
                r_bullets_active.Add(true);
                printbullet(p.xpos + 3, p.ypos + 1);
            }
            // left hand side
            else if (direction == "left")
            {
                pbullets_x_left.Add(p.xpos - 1);
                pbullets_y_left.Add(p.ypos + 1);
                l_bullets_active.Add(true);
                printbullet(p.xpos - 1, p.ypos + 1);
            }
        }

        static void printbullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(".");
        }

        static void erasebullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        static void movebullet(List<int> pbullets_x_right, List<int> pbullets_y_right, List<int> pbullets_x_left, List<int> pbullets_y_left, List<bool> r_bullets_active, List<bool> l_bullets_active)
        {
            // right hand side bullets
            for (int i = 0; i < pbullets_x_right.Count; i++)
            {
                if (r_bullets_active[i])
                {
                    erasebullet(pbullets_x_right[i], pbullets_y_right[i]);
                    pbullets_x_right[i]++;
                    printbullet(pbullets_x_right[i], pbullets_y_right[i]);
                }
            }

            // left hand side bullets
            for (int i = 0; i < pbullets_x_left.Count; i++)
            {
                if (l_bullets_active[i])
                {
                    erasebullet(pbullets_x_left[i], pbullets_y_left[i]);
                    pbullets_x_left[i]--;
                    printbullet(pbullets_x_left[i], pbullets_y_left[i]);
                }
            }
        }

        static void Player_bullet_collision(char[,] maze, List<int> pbullets_x_right, List<int> pbullets_y_right, List<int> pbullets_x_left, List<int> pbullets_y_left, List<bool> r_bullets_active, List<bool> l_bullets_active)
        {
            // right bullets
            for (int i = 0; i < pbullets_x_right.Count; i++)
            {
                int x = pbullets_x_right[i] + 1, y = pbullets_y_right[i];
                if (maze[y, x] == '#' && r_bullets_active[i])
                {
                    r_bullets_active[i] = false;
                    erasebullet(x - 1, y);
                }
            }

            // left bullets
            for (int i = 0; i < pbullets_x_left.Count; i++)
            {
                int x = pbullets_x_left[i] - 1, y = pbullets_y_left[i];
                if (maze[y, x] == '#' && l_bullets_active[i])
                {
                    l_bullets_active[i] = false;
                    erasebullet(x + 1, y);
                }
            }
        }

        static void remove_bullets(List<int> pbullets_x_right, List<int> pbullets_y_right, List<int> pbullets_x_left, List<int> pbullets_y_left, List<bool> r_bullets_active, List<bool> l_bullets_active)
        {
            // right hand side
            for (int i = 0; i < pbullets_x_right.Count; i++)
            {
                if (!r_bullets_active[i])
                {
                    for (int j = i; j < pbullets_x_right.Count - 1; j++)
                    {
                        pbullets_x_right[j] = pbullets_x_right[j + 1];
                        pbullets_y_right[j] = pbullets_y_right[j + 1];
                        r_bullets_active[j] = r_bullets_active[j + 1];
                    }
                }
            }

            // left hand side
            for (int i = 0; i < pbullets_x_left.Count; i++)
            {
                if (!l_bullets_active[i])
                {
                    for (int j = i; j < pbullets_x_left.Count - 1; j++)
                    {
                        pbullets_x_left[j] = pbullets_x_left[j + 1];
                        pbullets_y_left[j] = pbullets_y_left[j + 1];
                        l_bullets_active[j] = l_bullets_active[j + 1];
                    }
                }
            }
        }
        static void printplayerwithdirection(Player p, string direction)
        {
            if (direction == "right")
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

        static void moveEnemy(Enemy e, char[,] maze, Player p, List<int> ebullets_x_right, List<int> ebullets_y_right, List<int> ebullets_x_left, List<int> ebullets_y_left, List<bool> er_bullets_active)
        {
            if (e.ypos == p.ypos || e.ypos+1 == p.ypos || e.ypos+2 == p.ypos)
            {
                generateEnemybullet(e, ebullets_x_right, ebullets_y_right, ebullets_x_left, ebullets_y_left, er_bullets_active);
            }
            if (e.direction == "up")
            {
                if (maze[e.ypos-1, e.xpos] == '#')
                {
                    e.direction = "down";
                }
                else
                {
                    eraseEnemy(e);
                    e.ypos--;
                    printEnemy(e);
                }
            }
            if (e.direction == "down")
            {
                if (maze[e.ypos + 3, e.xpos] == '#')
                {
                    e.direction = "up";
                }
                else
                {
                    eraseEnemy(e);
                    e.ypos++;
                    printEnemy(e);
                }
            }
        }

        static void generateEnemybullet(Enemy e, List<int> ebullets_x_right, List<int> ebullets_y_right, List<int> ebullets_x_left, List<int> ebullets_y_left, List<bool> er_bullets_active)
        {
            ebullets_x_right.Add(e.xpos + 3);
            ebullets_y_right.Add(e.ypos + 1);
            er_bullets_active.Add(true);
            printbullet(e.xpos + 3, e.ypos + 1);
        }

        static void moveEnemybullet(List<int> ebullets_x_right, List<int> ebullets_y_right, List<int> ebullets_x_left, List<int> ebullets_y_left, List<bool> er_bullets_active)
        {
            for (int i = 0; i < ebullets_x_right.Count; i++)
            {
                if (er_bullets_active[i])
                {
                    erasebullet(ebullets_x_right[i], ebullets_y_right[i]);
                    ebullets_x_right[i]++;
                    printbullet(ebullets_x_right[i], ebullets_y_right[i]);
                }
            }
        }

        static void Enemy_bullet_collision(char[,] maze, List<int> ebullets_x_right, List<int> ebullets_y_right, List<int> ebullets_x_left, List<int> ebullets_y_left, List<bool> er_bullets_active)
        {
            for (int i = 0; i < ebullets_x_right.Count; i++)
            {
                int x = ebullets_x_right[i] + 1, y = ebullets_y_right[i];
                if (maze[y, x] == '#' && er_bullets_active[i])
                {
                    er_bullets_active[i] = false;
                    erasebullet(x - 1, y);
                }
            }
        }
        static void printEnemy(Enemy e)
        {
            char[,] body = { { ' ', 'E', ' ' }, { '(', 'L', '=' }, { '/', ')', ' ' } };
            print3x3character(body, 3, e.xpos, e.ypos);
        }

        static void eraseEnemy(Enemy e)
        {
            char[,] body = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            print3x3character(body, 3, e.xpos, e.ypos);
        }

        static void printPlayerRight(Player p)
        {
            char[,] body = { { ' ', 'P', ' ' }, { '(', 'L', '=' }, { '/', ')', ' ' } };
            print3x3character(body, 3, p.xpos, p.ypos);
        }

        static void printPlayerLeft(Player p)
        {
            char[,] body = { { ' ', '0', ' ' }, { '=', 'j', ')' }, { ' ', '(', '\\' } };
            print3x3character(body, 3, p.xpos, p.ypos);
        }

        static void erasePlayer(Player p)
        {
            char[,] body = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            print3x3character(body, 3, p.xpos, p.ypos);
        }

        static void print3x3character(char[,] body, int size, int x, int y)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x + j, y + i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(body[i, j]);
                }
            }
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