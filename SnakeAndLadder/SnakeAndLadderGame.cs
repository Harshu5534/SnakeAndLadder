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
        int position = 0, count = 0,Player1=0,Player2=0;

        public int DieRoll()
        {
            Random random = new Random();
            int DiePosition = random.Next(1, 7);
                 return DiePosition ;
        }
        public int Game()
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
                        this.position += this.DieRoll(); 
                        if (this.position > 100)
                        {
                            this.position -= this.DieRoll();
                        }
                        break;
                }
                count++;
            }
            Console.WriteLine("Number of Times Dice Was Played To Win The Game: "+""+count);
            Console.WriteLine("The Position is :" + this.position);
            return position;
        }
        public void TwoPlayers()
        {
            Random random = new Random();
            int check =random.Next(0,2);
            if(check==0)
            {
                Player1 = Game();
            }
            else
            {
                Player2 = Game();
            }
            while(Player1<100 && Player2<100)
            {
                this.Player1 = this.Game();
                if(this.Player1==100)
                {
                    Console.WriteLine("Player1 Wins The Game");
                }
                else
                {
                    this.Player1 = this.Game();
                }
                if(Player2==100)
                {
                    Console.WriteLine("Player2 Wins The Game");
                }
            }
        }
    }
}
