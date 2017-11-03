using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string input;
            var sudoku = new Sudoku(GetValueString());
            //Print(sudoku.Grid);

            do
            {
                Console.WriteLine("Select What To Do:");
                Console.WriteLine("1 :\tPrint Sudoku");
                Console.WriteLine("2 :\tGet Cell Value");
                Console.WriteLine();
                Console.WriteLine("Exit - type 'exit'.");
                input = Console.ReadLine();

                ProcessInput(input);

            } while (input.ToLower().Equals("exit"));
        }

        private static void ProcessInput(string input)
        {
            
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
