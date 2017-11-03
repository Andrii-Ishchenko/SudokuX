using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core;

namespace SudokuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var sudoku = new Sudoku(GetValueString());
            Print(sudoku.Grid);
            Console.ReadKey();
        }

        static string GetValueString()
        {
            return  "050027400" +
                    "000605008" +
                    "030100009" +
                    "063000000" +
                    "042000310" +
                    "000000650" +
                    "700006080" +
                    "600903000" +
                    "004850020";
        }

        static void Print(Grid g)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var row in g.Rows)
            {
                foreach (var cell in row)
                {
                    sb.Append(cell.IsValueSet ? cell.Value.ToString() : ".");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
