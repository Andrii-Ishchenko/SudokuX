using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuX.Core.Utils;

namespace SudokuX.Core
{
    public class Sudoku :IEnumerable<Cell>
    {
        public List<Cell> Cells { get; }
        public Group[] Blocks { get; }
        public Group[] Columns { get; }
        public Group[] Rows { get; }

        public Sudoku(string sudoku)
        {
            Blocks = new Group[9];
            Columns = new Group[9];
            Rows = new Group[9];
            Cells = new List<Cell>(81);

            Init(sudoku);
        }

        private void Init(string sudoku)
        {

            for (short i = 0; i < 9; i++)
            {
                Blocks[i] = new Group(i);
                Columns[i] = new Group(i);
                Rows[i] = new Group(i);
            }

            var values = GridHelper.GetValuesFromString(sudoku);

            for (short x = 0; x < 9; x++)
            {
                var column = Columns[x];
                for (short y = 0; y < 9; y++)
                {
                    var row = Rows[y];
                    var block = GetBlockByXY(x, y);
                    Cells.Add(new Cell(x, y, block, row, column, values[x, y]));
                }
            } 
        }

        private Group GetBlockByXY(short x, short y)
        {
            int row3 = y / 3;
            int column3 = x / 3;
            return Blocks[row3 * 3 + column3];
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            return ((IEnumerable<Cell>)Cells).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
