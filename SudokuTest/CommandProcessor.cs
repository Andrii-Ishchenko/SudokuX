using SudokuTest.Commands;
using SudokuX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTest
{
    public  class CommandProcessor
    {

        public void Init()
        {
            new HelpCommand(null).Execute(null);
        }

        public void Process(string input, Sudoku sudoku)
        {
            var parsed = CommandParser.Parse(input);

            if (parsed == null)
                return;

            BaseCommand command = null;
            switch (parsed.CommandName)
            {
                case "p":
                case "print":
                    command = new PrintCommand(parsed);
                    break;
                case "c":
                case "cell":
                    command = new GetCellCommand(parsed);
                    break;
                case "help":
                    command = new HelpCommand(parsed);
                    break;
                case "e":
                    command = new EliminateValuesCommand(parsed);
                    break;
                default:
                    break;
            }

            if (command != null)
                command.Execute(sudoku);
        }

    }
}
