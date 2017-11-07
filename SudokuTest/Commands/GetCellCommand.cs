using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core;

namespace SudokuTest.Commands
{
    public class GetCellCommand : BaseCommand
    {
        public GetCellCommand(Parsed parsed) : base("GetCell", parsed)
        {
        }

        public override void Execute(Sudoku sudoku)
        {
            if(Parsed.Parameters.Count < 2)
            {
                Console.WriteLine("Should be 2 parameters: x, y.");
                return;
            }
            
            short x, y;
            if (!short.TryParse(Parsed.Parameters[0],out x))
            {
                Console.WriteLine("Wrong format: x");
                return;
            }

            if (!short.TryParse(Parsed.Parameters[1], out y))
            {
                Console.WriteLine("Wrong format: y");
                return;
            }

            Cell cell = sudoku.Cells.FirstOrDefault(c => { return (c.X == x && c.Y == y); });
            if (cell == null)
            {
                Console.WriteLine("Cell not found.");
            }

            Console.WriteLine(" Cell ({0},{1}):\n ValueSet: {2}\n Value:{3}\n ReadOnly:{4}\n Candidates: {5}", x, y, cell.IsValueSet, cell.Value,cell.IsReadOnly, String.Join(",", cell.Candidates));


        }
    }
}
