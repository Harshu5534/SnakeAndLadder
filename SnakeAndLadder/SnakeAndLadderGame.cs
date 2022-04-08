using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        int position = 0;

        public int DieRoll()
        {
            Random random = new Random();
            int DiePosition = random.Next(1, 7);
            Console.WriteLine("Die Number is: " + DiePosition);
            return DiePosition ;
        }
    }
}
