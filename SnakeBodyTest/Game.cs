using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Snake2.Draw;

namespace Snake2
{
    class Game
    {
        public static int speed;
        public static string diffSel;
        public static bool end;

        public static void Start() //difficulty prompt... i want this to return a value to the main
        {
        restart:
            end = false;
            Console.WriteLine("Snake! Select Difficulty\n1=Hardest 5=Easiest");
            diffSel = Console.ReadLine();
            int difficulty;

            if(int.TryParse(diffSel, out difficulty) && difficulty <= 5 && difficulty >0)
            {
                speed = 30 * difficulty;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Difficulty Selection!");
                goto restart;
            }

            switch (difficulty)
            {
                case 1:
                    diffSel = "expert";
                    break;

                case 2:
                    diffSel = "hard";
                    break;

                case 3:
                    diffSel = "medium";
                    break;

                case 4:
                    diffSel = "easy";
                    break;

                case 5:
                    diffSel = "very easy";
                    break;
            }
        }
        public static void EndCheck() //checks for game end... i want this to return a value to move
        {

            if (snakeX[1] <= 0 || snakeY[1] <= 0 || snakeX[1] == Init.width || snakeY[1] == Init.height) //border crash
            {
                end = true;
            }

            for (int i = 2; i <= snakeLength; i++) //eaten itself
            {
                if (snakeX[1] == snakeX[i] && snakeY[1] == snakeY[i])
                {
                    end = true;
                }
            }
        }
    }
}
