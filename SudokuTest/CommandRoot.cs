using SudokuTest.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTest
{
    public static class CommandRoot
    {
        private static Dictionary<string,string> DescriptionToCommandNameMap { get; set; }

        public static void Register(Type type)
        {
           //TODO
        }
    }
}
