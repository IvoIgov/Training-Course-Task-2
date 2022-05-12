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
        private int row;
        private int col;
        public IndexerClassSquareMatrix(int size)
        {
            this.Size = size;
            this.Row = row;
            this.Col = col;
            this.matrixValues = new T[size * size];
        }

        public int Size { get; set; }

        public int Row
        {
            get { return this.row; }
            set
            {
                if (value < 0 || value >= Size)
                {
                    throw new ArgumentOutOfRangeException(ExceptionMessages.RowOutOfRange);
                }
                this.row = value;
            }
        }
        public int Col
        {
            get { return this.col; }
            set
            {
                if (value < 0 || value >= Size )
                {
                    throw new ArgumentOutOfRangeException(ExceptionMessages.ColOutOfRange);
                }
                this.col = value;
            }
        }

        public int CalculatePosition(int row, int col, int size)
        {
            int index = 0;
            index = Row * Size + Col;
            return index;
        }

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
