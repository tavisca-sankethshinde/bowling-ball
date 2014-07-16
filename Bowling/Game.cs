using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        int[] Roll_No = new int[30];
        int Count = 0;


        public void Roll(int pins)
        {
           Roll_No[Count++] = pins;

            if (pins == 10)
                Count++;
        }

        public int GetScore()
        {
            int score = 0;
            for (int i = 0; i < 20; i++)
            {
                score +=Roll_No[i];
                if (Roll_No[i] == 10 && Roll_No[i + 2] == 10 && (i % 2 == 0))
                {
                    score = score + Roll_No[i + 2] + Roll_No[i + 4];
                }
                else if (Roll_No[i] == 10 && (i % 2 == 0))
                {
                    score = score + Roll_No[i + 2] + Roll_No[i + 3];
                }
                else if (((Roll_No[i] + Roll_No[i + 1]) == 10) && (i % 2 == 0))
                {
                    score += Roll_No[i + 2];
                }
            }



            return score;
        }

    }
}