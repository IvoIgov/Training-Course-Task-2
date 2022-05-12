using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Center_Task_2
{
    public class IndexerClassSquareMatrix<T>
    {
        private int size;
        private T[] matrixValues;
        public IndexerClassSquareMatrix(int size)
        {
            this.Size = size;
            this.matrixValues = new T[size * size];
        }

        public int Size { get; set; }

        public T this[int i]
        {
            get
            {
                return matrixValues[i];
            }
            set
            {
                matrixValues[i] = value;
            }
        }
    }
}
