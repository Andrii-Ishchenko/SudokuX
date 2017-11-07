using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuTest.Commands;
using SudokuX.Core;

namespace SudokuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            var sudoku = new Sudoku(GetValueString());

            CommandProcessor processor = new CommandProcessor();
            processor.Init();

            do
            {
                input = Console.ReadLine();
                processor.Process(input, sudoku);
            }
            while (input.ToLower() != "exit");

        }

        static string GetValueString()
        {
            return  ".5..274.." +
                    "...6.5..8" +
                    ".3.1....9" +
                    ".63......" +
                    ".42...31." +
                    "......65." +
                    "7....6.8." +
                    "6..9.3..." +
                    "..485..2.";
        }

    }
}
