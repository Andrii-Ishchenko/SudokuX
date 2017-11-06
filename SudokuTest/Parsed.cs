using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTest
{
    public class Parsed
    {
        public Parsed(string commandName, List<string> parameters)
        {
            CommandName = commandName;
            Parameters = parameters;
        }

        public string CommandName { get; }
        public List<string> Parameters { get; }
    }
}
