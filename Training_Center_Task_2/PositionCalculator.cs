﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Center_Task_2
{
    public class PositionCalculator
    {
        public int CalculatePosition(int row, int col, int size)
        {
            int index = 0;
            index = row * size + col; 
            return index;
        }
    }
}
