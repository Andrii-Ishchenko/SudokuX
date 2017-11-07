using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core;

namespace SudokuTest.Commands
{
    public class EliminateValuesCommand : BaseCommand
    {
        public EliminateValuesCommand(Parsed parsed) : base("Eliminate", parsed)
        {
        }

        public override void Execute(Sudoku sudoku)
        {
            foreach(var cell in sudoku.Cells)
            {
                if (cell.IsValueSet)
                {
                    cell.EliminateValueFromGroups();
                }
            }
        }
    }
}
