using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Center_Task_2
{
    public abstract class BaseMatrix<T>
    {
        private T size = default;

        public T[] CreateMatrix(int size)
        {
            T[] matrix = new T[size];
            return matrix;
        }

        public T Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
    }
}
