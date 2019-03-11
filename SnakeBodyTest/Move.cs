using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static Snake2.Draw;

namespace Snake2
{
    class Move
    {
        public static int[] movement = new int[99]; //each piece of body has a movement direction assoicated with it

        public static void BodyGrow() //this runs when  the body grows or appleGot = true
        {
            for (int i = 1; i <= snakeLength; i++)
            {
                if (movement[i] == 0)
                {
                    snakeX[i + 1] = snakeX[i] - 1;
                    snakeY[i + 1] = snakeY[i];
                }
                else if (movement[i] == 1)
                {
                    snakeX[i + 1] = snakeX[i] + 1;
                    snakeY[i + 1] = snakeY[i];
                }
                else if (movement[1] == 2)
                {
                    snakeY[i + 1] = snakeY[i] - 1;
                    snakeX[i + 1] = snakeX[i];
                }
                else if (movement[1] == 3)
                {
                    snakeY[i + 1] = snakeY[i] + 1;
                    snakeX[i + 1] = snakeX[i];
                }
            }

            movement[snakeLength + 1] = movement[snakeLength];
            snakeLength++;
        }

        public static void Body() //main loop of program, moves body
        {
            while (!Game.end) //main loop
            {
                Thread.Sleep(Game.speed);
                Game.EndCheck();

                if (appleX == snakeX[1] && appleY == snakeY[1])
                {
                    appleGot = true;
                    BodyGrow();
                    //Console.ReadLine();                             //used for debug
                }

                else
                {
                    for (int i = snakeLength; i > 0 ; i--)
                    {
                        movement[i + 1] = movement[i];
                    }
                }

                Draw.Snake(); //draws the snake every scan of loop, moves the body

                if (Console.KeyAvailable) //key input
                {
                    while (true)
                    {
                        ConsoleKeyInfo turn = Console.ReadKey(true);
                        if (turn.Key.Equals(ConsoleKey.RightArrow) && movement[1] != 1)
                        {
                            movement[1] = 0;
                        }

                        if (turn.Key.Equals(ConsoleKey.LeftArrow) && movement[1] != 0)
                        {
                            movement[1] = 1;
                        }

                        if (turn.Key.Equals(ConsoleKey.UpArrow) && movement[1] != 2)
                        {
                            movement[1] = 3;
                        }

                        if (turn.Key.Equals(ConsoleKey.DownArrow) && movement[1] != 3)
                        {
                            movement[1] = 2;
                        }
                        break;
                    }
                }

                for (int i = 1; i<=snakeLength; i++) //changes direction of snake based on key input
                {
                    switch (movement[i])
                    {
                        case 0:
                            snakeX[i]++;
                            break;

                        case 1:
                            snakeX[i]--;
                            break;

                        case 2:
                            snakeY[i]++;
                            break;

                        case 3:
                            snakeY[i]--;
                            break;
                    }
                }
            }
        }
    }
}
