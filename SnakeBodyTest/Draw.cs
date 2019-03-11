using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static Snake2.Move;

namespace Snake2
{
    class Draw
    {
        public static int[] snakeX = new int[99];
        public static int[] snakeY = new int[99];
        public static int appleX = 0;
        public static int appleY = 0;
        public static int snakeLength = 1;
        public static bool appleGot = false;

        public static void Apple() //draws the apple
        {
            Console.SetCursorPosition(appleX, appleY); //constantly writes apple which x and y only change on appleGot
            Console.Write("O");

            if (appleGot) //randomly decide apple x and y
            {
                Random rand = new Random();
                appleX = rand.Next(1, Init.width-1);
                appleY = rand.Next(1, Init.height-1);
                appleGot = false;
            }
        }

        public static void Snake() //draws the snake
        {
            Console.Clear(); //clears the console so X doesn't show up every scan
            Console.Write("sL:{0} X[1]={1} Y[1]={2}  X[sL]={3} Y[sL]={4}  apple[x,y]={5},{6} movement={7}"
                ,snakeLength,snakeX[1],snakeY[1],snakeX[snakeLength],snakeY[snakeLength],appleX,appleY,movement[10]); //used for debug

            for (int i = 1; i<=snakeLength; i++) //writes the snakes body
            {
                if(appleGot)
                {
                    //Console.Read(); //used for debug
                }

                Console.SetCursorPosition(snakeX[i], snakeY[i]);
                Console.Write("X");
            }

            Apple();
        }
    }
}
