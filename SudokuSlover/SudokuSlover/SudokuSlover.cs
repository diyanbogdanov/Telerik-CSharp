using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSlover
{
    class SudokuSlover
    {
        private static int[,] sudokuEnterNumbers = new int[9, 9];

        private static void Slover(int row, int col)
        {
            if (row == 9 && col == 0)
            {
                try
                {
                    PrintSudoku(sudokuEnterNumbers);
                    throw new Exception();
                }
                catch (Exception)
                {
                }
            }
            else if (sudokuEnterNumbers[row, col] == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (CheckRow(row, i) || CheckCol(col, i) || SquareCheck(row, col, i))
                    {
                        continue;
                    }

                    sudokuEnterNumbers[row, col] = i;
                    Slover(NextRow(row, col), NextCol(col));
                    sudokuEnterNumbers[row, col] = 0;
                }
            }
            else
            {
                Slover(NextRow(row, col), NextCol(col));
            }
        }

        private static bool CheckRow(int row, int number)
        {
            for (int col = 0; col < 9; col++)
            {
                if (sudokuEnterNumbers[row, col] == number)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckCol(int col, int number)
        {
            for (int row = 0; row < 9; row++)
            {
                if (sudokuEnterNumbers[row, col] == number)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool SquareCheck(int row, int col, int number)
        {
            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int k = startCol; k < startCol + 3; k++)
                {
                    if (sudokuEnterNumbers[i, k] == number)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static int NextRow(int row, int col)
        {
            col++;
            if (col > 8)
            {
                return row + 1;
            }
            return row;
        }

        private static int NextCol(int col)
        {
            col++;
            if (col > 8)
            {
                return 0;
            }
            return col;
        }

        private static void PrintSudoku(int[,] sudoku)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Console.Write(sudoku[row,col]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            for (int indexRow = 0; indexRow < 9; indexRow++)
            {
                string readLine = Console.ReadLine();
                for (int indexCol = 0; indexCol < 9; indexCol++)
                {
                    if (readLine[indexCol] == '-')
                    {
                        sudokuEnterNumbers[indexRow, indexCol] = 0;
                    }
                    else
                    {
                        sudokuEnterNumbers[indexRow, indexCol] = int.Parse(readLine[indexCol].ToString());
                    }
                }
            }

            Slover(0, 0);
        }
    }
}
