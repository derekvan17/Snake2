﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Snake2.Draw;

namespace Snake2 
{
    class Init
    {
        public static int height = 50;
        public static int width = 75;

        public static void Board() //draws board
        {
            Console.WindowHeight = height;
            Console.WindowWidth = width;
        }  

        public static void Snake() //draws the initial snake
        {
            Random start = new Random();
            snakeX[1] = start.Next(1, width-1);
            snakeY[1] = start.Next(1, height-1);

            Console.SetCursorPosition(snakeX[1], snakeY[1]); //we use (x1,y1) as start
            snakeLength = 1; //resets snakeLength for next game
        }

        public static void Apple() //draws the initial apple
        {
            while (true)
            {
                Random rand = new Random();
                appleX = rand.Next(1, width-1);
                appleY = rand.Next(1, height-1);
                Console.SetCursorPosition(appleX, appleY);

                if (snakeX[1] != appleX || snakeY[1] != appleY) //makes sure the apple and snake aren't at the same spot
                {
                    Console.Write("O");
                    break;
                }
                else
                {
                    appleX = rand.Next(1, 74);
                    appleY = rand.Next(1, 49);
                }
            }
        }
    }
}
