using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuTest.Commands;

namespace SudokuTest
{
    public static class CommandParser
    {
        public static Parsed Parse(string input)
        {
            string[] parts = input.Trim().Split(' ');

            var name = parts[0].ToLower();
        
            if (string.IsNullOrWhiteSpace(name))
                return null;

            var parameters = parts.Skip(1).ToList();

            return new Parsed(name,parameters);        
        }

    }
}
