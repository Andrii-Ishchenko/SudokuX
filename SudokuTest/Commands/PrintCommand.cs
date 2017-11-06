using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core;

namespace SudokuTest.Commands
{
    public class PrintCommand: BaseCommand
    {

        public PrintCommand(Parsed parsed) 
            : base("Print", "p", "Print Command",parsed)
        {
        }

        public override void Execute(Sudoku sudoku){
            StringBuilder sb = new StringBuilder();
            foreach (var row in sudoku.Rows)
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
