﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGAME
{
    public class ladder

    {
        int position = 0;
        public int DieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            return diePosition;        }

    }
}
