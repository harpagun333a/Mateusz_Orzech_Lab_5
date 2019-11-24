using System;

namespace Cwiczenie_7_Klasa_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 7\n");

            int[] tab = new int[] { 1, 2, 3, 4, 5 };

            Matrix m = new Matrix(2, 3, tab);
            int[] dimensions;
            
            m.print();
            m.AddElem(9, 1, 2);
            Console.WriteLine();
            m.print();
            Console.WriteLine();
            m.GetDimensions(out dimensions);
            Console.WriteLine("Wymiary: {0}, {1}", dimensions[0], dimensions[1]);
            int val = m.GetValue(0, 1);
            Console.WriteLine("Pobrana Wartość: {0}", val);

            int[] tab1 = new int[] { 1, 1, 1, 1, 1, 1 };
            Matrix m1 = new Matrix(2, 3, tab1);
            int[] tab2 = new int[] { 2, 2, 2, 2, 2, 2 };
            Matrix m2 = new Matrix(3, 2, tab2);

            Matrix m3 = m1.AddMatrix(m2);

            Console.WriteLine();
            m1.print();
            Console.WriteLine();
            m2.print();
            Console.WriteLine();
            m3.print();
        }
    }

    public class Matrix
    {
        int[] _matrix;
        int c;
        int r;

        public Matrix(int columns, int rows, int[] tab = null)
        {
            this.c = columns;
            this.r = rows;

            int min_dim;

            _matrix = new int[columns * rows];

            for(int i = 0; i < (columns * rows); i++)
            {
                _matrix[i] = 0;
            }

            if(tab != null)
            {
                min_dim = tab.Length > (columns * rows) ? columns * rows : tab.Length;

                for(int i = 0; i < min_dim; i++)
                {
                    _matrix[i] = tab[i];
                }
            }
        }

        public void print()
        {
            for(int i = 0; i < this.r; i++)
            {
                for(int j = 0; j < this.c; j++)
                {
                    Console.Write("[{0, 2}]", _matrix[j + i * c]);
                }
                Console.WriteLine();
            }
        }

        public void AddElem(int el, int col, int row)
        {
            _matrix[col + row * this.c] = el;
        }

        public void GetDimensions(out int[] dim)
        {
            dim = new int[] { this.c, this.r };
        }

        public int GetValue(int col, int row)
        {
            int val = _matrix[col + row * this.c];
            return val;
        }

        public Matrix AddMatrix(Matrix m)
        {
            int[] dim;
            int[] max_dim = new int[2];
            int[] min_dim = new int[2];

            m.GetDimensions(out dim);

            max_dim[0] = dim[0] > this.c ? dim[0] : this.c;
            max_dim[1] = dim[1] > this.r ? dim[1] : this.r;

            min_dim[0] = dim[0] < this.c ? dim[0] : this.c;
            min_dim[1] = dim[1] < this.r ? dim[1] : this.r;

            int[] tab = new int[max_dim[0] * max_dim[1]];

            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = 0;
            }

            for(int i = 0; i < dim[1]; i++)
            {
                for(int j = 0; j < dim[0]; j++)
                {
                    tab[j + i * max_dim[1]] += m.GetValue(j, i);
                }
            }

            for (int i = 0; i < this.r; i++)
            {
                for (int j = 0; j < this.c; j++)
                {
                    tab[j + i * max_dim[1]] += _matrix[j + i * c];
                }
            }

            return new Matrix(max_dim[0], max_dim[1], tab);
        }
    }
}
