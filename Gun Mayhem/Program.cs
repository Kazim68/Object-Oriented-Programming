using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace Gun_Mayhem
{
    internal class Program
    {
        static int p_bullets_r_count = 0, p_bullets_l_count = 0;
        static void Main(string[] args)
        {
            string direction = "right";            
            int[] pbullets_x_right = new int[1000], pbullets_y_right = new int[1000], pbullets_x_left = new int[1000], pbullets_y_left = new int[1000];
            int x = 15, y = 15;
            boundary();
            printPlayerRight(x, y);
            game(x, y, direction, pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left);          
        }

        static void game(int x, int y, string direction, int[] pbullets_x_right, int[] pbullets_y_right, int[] pbullets_x_left, int[] pbullets_y_left)
        {
            int c = 0;
            bool[] r_bullets_active = new bool[1000], l_bullets_active = new bool[1000];
            while (!Keyboard.IsKeyPressed(Key.Escape))
            {
                if (Keyboard.IsKeyPressed(Key.UpArrow) && y > 11)
                {
                    erasePlayer(x, y);
                    y--;
                    printplayerwithdirection(x, y, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.RightArrow) && x < 81)
                {
                    erasePlayer(x, y);
                    x++;
                    direction = "right";
                    printplayerwithdirection(x, y, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.LeftArrow) && x > 11)
                {
                    erasePlayer(x, y);
                    x--;
                    direction = "left";
                    printplayerwithdirection(x, y, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow) && y < 22)
                {
                    erasePlayer(x, y);
                    y++;
                    printplayerwithdirection(x, y, direction);
                }
                else if (Keyboard.IsKeyPressed(Key.Space) && !((x == 11 && direction == "left") || (x == 81 && direction == "right")))
                {
                    generatebullet(x, y, direction, pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, r_bullets_active, l_bullets_active);
                }
                movebullet(pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left,  r_bullets_active, l_bullets_active);
                Player_bullet_collision(pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, r_bullets_active, l_bullets_active);
                if (c == 100)
                {
                    remove_bullets(pbullets_x_right, pbullets_y_right, pbullets_x_left, pbullets_y_left, r_bullets_active, l_bullets_active);
                    c = 0;
                }
                c++;
                Thread.Sleep(20);
            }
        }

        static void generatebullet(int x, int y, string direction, int[] pbullets_x_right, int[] pbullets_y_right, int[] pbullets_x_left, int[] pbullets_y_left, bool[] r_bullets_active, bool[] l_bullets_active)
        {
            // right hand side
            if (direction == "right")
            {
                pbullets_x_right[p_bullets_r_count] = x + 3;
                pbullets_y_right[p_bullets_r_count] = y + 1;
                r_bullets_active[p_bullets_r_count] = true; 
                p_bullets_r_count++;
                printbullet(x + 3, y + 1);
            }
            // left hand side
            else if (direction == "left")
            {
                pbullets_x_left[p_bullets_l_count] = x - 1;
                pbullets_y_left[p_bullets_l_count] = y + 1;
                l_bullets_active[p_bullets_l_count] = true;
                p_bullets_l_count++;
                printbullet(x - 1, y + 1);
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

        static void movebullet(int[] pbullets_x_right, int[] pbullets_y_right, int[] pbullets_x_left, int[] pbullets_y_left, bool[] r_bullets_active, bool[] l_bullets_active)
        {
            // right hand side bullets
            for (int i = 0; i < p_bullets_r_count; i++)
            {
                if (r_bullets_active[i])
                {
                    erasebullet(pbullets_x_right[i], pbullets_y_right[i]);
                    pbullets_x_right[i]++;
                    printbullet(pbullets_x_right[i], pbullets_y_right[i]);
                }
            }

            // left hand side bullets
            for (int i = 0; i < p_bullets_l_count; i++)
            {
                if (l_bullets_active[i])
                {
                    erasebullet(pbullets_x_left[i], pbullets_y_left[i]);
                    pbullets_x_left[i]--;
                    printbullet(pbullets_x_left[i], pbullets_y_left[i]);
                }
            }
        }

        static void Player_bullet_collision(int[] pbullets_x_right, int[] pbullets_y_right, int[] pbullets_x_left, int[] pbullets_y_left, bool[] r_bullets_active, bool[] l_bullets_active)
        {
            // right bullets
            for (int i = 0; i < p_bullets_r_count; i++)
            {
                int x = pbullets_x_right[i]+1, y = pbullets_y_right[i];
                if (x == 84 && r_bullets_active[i])
                {
                    r_bullets_active[i] = false;
                    erasebullet(x - 1, y);
                }
            }

            // left bullets
            for (int i = 0; i < p_bullets_l_count; i++)
            {
                int x = pbullets_x_left[i] - 1, y = pbullets_y_left[i];
                if (x == 10 && l_bullets_active[i])
                {
                    l_bullets_active[i] = false;
                    erasebullet(x + 1, y);
                }
            }
        }

        static void remove_bullets(int[] pbullets_x_right, int[] pbullets_y_right, int[] pbullets_x_left, int[] pbullets_y_left, bool[] r_bullets_active, bool[] l_bullets_active)
        {
            // right hand side
            for (int i = 0; i< p_bullets_r_count; i++)
            {
                if (!r_bullets_active[i])
                {
                    for (int j = i; j < p_bullets_r_count-1; j++)
                    {
                        pbullets_x_right[j] = pbullets_x_right[j + 1];
                        pbullets_y_right[j] = pbullets_y_right[j + 1];
                        r_bullets_active[j] = r_bullets_active[j + 1];
                    }
                    p_bullets_r_count--;
                }
            }

            // left hand side
            for (int i = 0; i < p_bullets_l_count; i++)
            {
                if (!l_bullets_active[i])
                {
                    for (int j = i; j < p_bullets_l_count-1; j++)
                    {
                        pbullets_x_left[j] = pbullets_x_left[j + 1];
                        pbullets_y_left[j] = pbullets_y_left[j + 1];
                        l_bullets_active[j] = l_bullets_active[j + 1];
                    }
                    p_bullets_l_count--;
                }
            }
        }
        static void printplayerwithdirection(int x, int y, string direction)
        {
            if (direction == "right")
            {
                printPlayerRight(x, y);
            }
            else
            {
                printPlayerLeft(x, y);
            }
        }

        static void boundary_top_row(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < 75; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("#");
            }
        }

        static void boundary()
        {
            boundary_top_row(10, 10);
            for (int i = 1; i < 15; i++)
            {
                Console.SetCursorPosition(10, i + 10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("#");
                for (int j = 0; j < 73; j++)
                {
                    Console.Write(" ");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("#\n");
            }
            boundary_top_row(10, 25);
            Console.WriteLine(" ");
        }

        static void printPlayerRight(int x, int y)
        {
            char[,] body = { { ' ', '0', ' ' }, { '(', 'L', '=' }, { '/', ')', ' ' } };
            print3x3character(body, 3, x, y);
        }

        static void printPlayerLeft(int x, int y)
        {
            char[,] body = { { ' ', '0', ' ' }, { '=', 'j', ')' }, { ' ', '(', '\\' } };
            print3x3character(body, 3, x, y);
        }

        static void erasePlayer(int x, int y)
        {
            char[,] body = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            print3x3character(body, 3, x, y);
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
    }
}