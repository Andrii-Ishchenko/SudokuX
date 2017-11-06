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
           
            do
            {
                Console.WriteLine("Select What To Do:");
                Console.WriteLine("(p) :\tPrint Sudoku");
                Console.WriteLine("(c x y) :\tGet Cell Value Or Candidates");
                Console.WriteLine("(can x y) :\tGet Cell Candidates");
                Console.WriteLine("(v x y) :\tGet Cell Value");
                Console.WriteLine();
                Console.WriteLine("(exit) :\tExit.");
                input = Console.ReadLine();

                var parsed = CommandParser.Parse(input);
                BaseCommand command = null;
                switch (parsed.CommandName)
                {
                    case "p":
                    case "print":
                        command = new PrintCommand(parsed);
                        break;
                    default:
                        break;
                }

                if(command!= null)
                    command.Execute(sudoku);

                Console.WriteLine();

            } while (input.ToLower()!="exit");
        }

        private static void ProcessInput(string input)
        {
            
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
