using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Grid : IEnumerable<Cell>
    {

        public List<Cell> Cells { get; private set; }
        public Group[] Blocks { get; private set; }
        public Group[] Columns { get; private set; }
        public Group[] Rows { get; private set; }

        public Grid(short[,] values)
        {
            Blocks = new Group[9];
            Columns = new Group[9];
            Rows = new Group[9];
            Cells = new List<Cell>(81);

            for (short i = 0; i < 9; i++)
            {
                Blocks[i] = new Group(i);
                Columns[i] = new Group(i);
                Rows[i] = new Group(i);
            }

            for (var x = 0; x < 9; x++)
            {
                var column = Columns[x];
                for (var y = 0; y < 9; y++)
                {
                    var row = Rows[y];
                    var block = GetBlockByXY((short)x, (short)y);
                    Cells.Add(new Cell(x, y, block, row, column, values[x,y]));
                }
            }
        }

        private Group GetBlockByXY(short X, short Y)
        {
            int row3 = Y / 3;
            int column3 = X / 3;
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
