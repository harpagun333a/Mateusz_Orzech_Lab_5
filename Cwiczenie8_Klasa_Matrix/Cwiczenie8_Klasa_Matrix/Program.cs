using System;

namespace Cwiczenie8_Klasa_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 8\n");

            int[][] tab = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };

            Matrix m = new Matrix(2, 3, tab);
            m.print();

            int[][] tab1 = new int[][]
            {
                new int[] {1, 1, 1},
                new int[] {1, 1, 1},
                new int[] {1, 1, 1}
            };

            int[][] tab2 = new int[][]
            {
                new int[] {2, 2, 2},
                new int[] {2, 2, 2},
                new int[] {2, 2, 2}
            };

            Matrix m1 = new Matrix(2, 3, tab1);
            Matrix m2 = new Matrix(3, 2, tab2);

            Console.WriteLine();
            m1.print();
            Console.WriteLine();
            m2.print();

            Matrix m3 = m1.AddMatrix(m2);
            Console.WriteLine();
            m3.print();

            Matrix m4 = m1.SubMatrix(m2);
            Console.WriteLine();
            m4.print();

        }

        public class Matrix
        {
            public int[][] _matrix;
            public int c;
            public int r;

            public Matrix(int columns, int rows, int[][] tab = null)
            {
                this.c = columns;
                this.r = rows;

                int[] min_dim = new int[2];

                _matrix = new int[c][];

                for(int i = 0; i < c; i++)
                {
                    _matrix[i] = new int[r];
                }

                if (tab != null)
                {
                    min_dim[0] = tab.Length > _matrix.Length ? _matrix.Length : tab.Length;
                    min_dim[1] = tab[0].Length > _matrix[0].Length ? _matrix[0].Length : tab[0].Length;

                    for (int i = 0; i < min_dim[1]; i++)
                    {
                        for(int j = 0; j < min_dim[0]; j++)
                        {
                            _matrix[j][i] = tab[i][j];
                        }
                    }
                }
            }

            public void print()
            {
                for(int i = 0; i < r; i++)
                {
                    for(int j = 0; j < c; j++)
                    {
                        Console.Write("[{0,2}]", _matrix[j][i]);
                    }
                    Console.WriteLine();
                }
            }

            public Matrix AddMatrix(Matrix m)
            {
                int dim_c = this.c > m.c ? this.c : m.c;
                int dim_r = this.r > m.r ? this.r : m.r;

                Matrix new_m = new Matrix(dim_c, dim_r);

                for(int i = 0; i < this.r; i++)
                {
                    for(int j = 0; j < this.c; j++)
                    {
                        new_m._matrix[j][i] += this._matrix[j][i];
                    }
                }

                for (int i = 0; i < m.r; i++)
                {
                    for (int j = 0; j < m.c; j++)
                    {
                        new_m._matrix[j][i] += m._matrix[j][i];
                    }
                }

                return new_m;
            }

            public Matrix SubMatrix(Matrix m)
            {
                int dim_c = this.c > m.c ? this.c : m.c;
                int dim_r = this.r > m.r ? this.r : m.r;

                Matrix new_m = new Matrix(dim_c, dim_r);

                for (int i = 0; i < this.r; i++)
                {
                    for (int j = 0; j < this.c; j++)
                    {
                        new_m._matrix[j][i] += this._matrix[j][i];
                    }
                }

                for (int i = 0; i < m.r; i++)
                {
                    for (int j = 0; j < m.c; j++)
                    {
                        new_m._matrix[j][i] -= m._matrix[j][i];
                    }
                }

                return new_m;
            }
        }
    }
}
