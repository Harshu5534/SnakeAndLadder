using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0;

        public int DieRoll()
        {
            Random random = new Random();
            int DiePosition = random.Next(1, 7);
                 return DiePosition ;
        }
        public void Game()
        {
            while (this.position < 100)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        this.position += 0;
                        break;
                    case SNAKE:
                        this.position -= this.DieRoll();
                        if (this.position < 0)
                        { 
                            this.position = 0;
                        }
                        break;
                    case LADDER:
                        int roll = this.DieRoll() ;
                        this.position += roll;
                        if (this.position > 100)
                        {
                            this.position -= roll;
                        }
                        break;
                }
                Console.WriteLine(this.position);
            }
        }
    }
}
