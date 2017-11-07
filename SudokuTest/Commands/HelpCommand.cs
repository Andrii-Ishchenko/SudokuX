using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core;

namespace SudokuTest.Commands
{
    public class HelpCommand : BaseCommand
    {
        public HelpCommand(Parsed parsed) : base("Help", parsed)
        {
        }

        public override void Execute(Sudoku sudoku)
        {
            Console.WriteLine("(p) :\tPrint Sudoku");
            Console.WriteLine("(c x y) :\tGet Cell Value Or Candidates");
            Console.WriteLine("(can x y) :\tGet Cell Candidates");
            Console.WriteLine("(v x y) :\tGet Cell Value");
            Console.WriteLine("(exit) :\tExit.");
        }
    }
}
