using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Center_Task_2
{
    public class DiagonalMatrix<T> : BaseMatrix<T>
    {
        private int size;
        private T[] matrixValues;
        private int row;
        private int col;

        public DiagonalMatrix(int size) : base(size)
        {
        }
        //public IndexerClassDiagonalMatrix(int size)
        //{
        //    this.Size = size;
        //    this.matrixValues = new T[size * size];
        //}
    }
}
