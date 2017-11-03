using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core.Utils;

namespace SudokuX.Core
{
    public class Sudoku
    {
        public Sudoku(String values)
        {
            Grid = new Grid(GridHelper.GetValuesFromString(values));
        }

        public Grid Grid { get; private set; }
    }
}
