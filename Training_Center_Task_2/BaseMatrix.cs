using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Center_Task_2
{
    public abstract class BaseMatrix<T>
    {
        private int size = 0;

        public T[] CreateMatrix(int size)
        {
            T[] matrix = new T[size];
            return matrix;
        }

        public int Size
        {
            get { return this.size; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(ExceptionMessages.NegativeOrZeroMatrixSize);
                }
                this.size = value;
            }
        }
    }
}
