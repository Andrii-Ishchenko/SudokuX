using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core;

namespace SudokuTest.Commands
{
    public abstract class BaseCommand
    {
        public string CommandName { get; }

        public Parsed Parsed { get; }

        protected BaseCommand(string commandName, Parsed parsed)
        {
            CommandName = commandName;
            Parsed = parsed;
        }

        public abstract void Execute(Sudoku sudoku);
    }
}
