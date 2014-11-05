using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingVector
{
    class Matrix
    {
        int rows;
        int columns;
        float[,] m;

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        public float this[int indexi, int indexj]
        {
            get { return m[indexi, indexj]; }
            set { m[indexi, indexj] = value; }
        }

        public Matrix(int r, int c)
        {
            rows = r;
            columns = c;
            m = new float[r, c];
        }

        public Matrix(float[,] elem)
        {
            m = elem;
            rows = elem.GetLength(0);
            columns = elem.GetLength(1);
        }

        public Matrix() :
            this(1, 4) { }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            var m3 = new Matrix(m1.rows, m2.columns);
            if (m1.columns != m2.rows)
                throw new Exception("Not valid");

            for (int i = 0; i < m1.rows; i++)
            {
                for (int j = 0; j < m2.columns; j++)
                {
                    for (int k = 0; k < m1.columns; k++)
                    {
                        m3[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return m3;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            var m3 = new Matrix(m1.rows, m2.columns);
            if (m1.rows != m2.rows || m1.columns != m2.columns)
                throw new Exception("Not valid");

            for (int i = 0; i < m1.rows; i++)
            {
                for (int j = 0; j < m2.columns; j++)
                {
                    m3[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return m3;
        }

        public static Matrix RotZMatrix(float alpa)
        {
            var tmpMatrix = new Matrix(new[,]
                {
                    {(float) Math.Cos(alpa), (float) Math.Sin(alpa), 0, 0},
                    {-(float) Math.Sin(alpa), (float) Math.Cos(alpa), 0, 0},
                    {0, 0, 1, 0},
                    {0, 0, 0, 1}
                });
            return tmpMatrix;
        }

        public static Matrix RotXMatrix(float alpha)
        {
            var tmpMatrix = new Matrix(new[,]
                {
                    { 1, 0, 0, 0 }, 
                    { 0, (float)Math.Cos(alpha), (float)Math.Sin(alpha), 0 }, 
                    { 0, -(float)Math.Sin(alpha), (float)Math.Cos(alpha), 0 }, 
                    { 0, 0, 0, 1 }
                });
            return tmpMatrix;
        }

        public static Matrix RotYMatrix(float alpha)
        {
            var tmpMatrix = new Matrix(new[,]
                {
                    { (float)Math.Cos(alpha), 0, (float)Math.Sin(alpha), 0 }, 
                    { 0, 1, 0, 0 }, 
                    { -(float)Math.Sin(alpha), 0, (float)Math.Cos(alpha), 0 }, 
                    { 0, 0, 0, 1 }
                });
            return tmpMatrix;
        }

        public static Matrix ScaleMatrix(float factor)
        {
            var tmpMatrix = new Matrix(new[,]
                {
                    { factor, 0, 0, 0 }, 
                    { 0, factor, 0, 0 }, 
                    { 0, 0, factor, 0 }, 
                    { 0, 0, 0, 1 }
                });
            return tmpMatrix;
        }

        public static Matrix ProjectionMatrix()
        {
            var tmpMatrix = new Matrix(new float[,]
                {
                    {1,0,0,0},
                    {0,1,0,0},
                    {0,0,0,0},
                    {0,0,0,1}
                });
            return tmpMatrix;
        }
    }
}
