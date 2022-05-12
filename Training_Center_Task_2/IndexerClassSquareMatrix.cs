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

        public T this[int row, int col]
        {
            get
            {
                return matrixValues[row * Size + col];
            }
            set
            {
                if (row < 0 || row >= Size)
                {
                    throw new ArgumentOutOfRangeException(ExceptionMessages.RowOutOfRange);
                }
                if (col < 0 || col >= Size)
                {
                    throw new ArgumentOutOfRangeException(ExceptionMessages.ColOutOfRange);
                }
                matrixValues[row * Size + col] = value;
            }
        }
    }
}
