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
        public string Abbreviation { get; }
        public string Description { get; }

        public Parsed Parsed { get; }

        protected BaseCommand(string commandName, string abbreviation, string description, Parsed parsed)
        {
            CommandName = commandName;
            Abbreviation = abbreviation;
            Description = description;
            Parsed = parsed;
        }

        public abstract void Execute(Sudoku sudoku);
    }
}
