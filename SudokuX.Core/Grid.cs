using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Grid
    {

        public List<Cell> Cells { get; private set; }
        public Group[] Blocks { get; private set; }
        public Group[] Columns { get; private set; }
        public Group[] Rows { get; private set; }

        public Grid()
        {
            for (short i = 1; i <= 9; i++)
            {
                Blocks[i] = new Group(i);
                Columns[i] = new Group(i);
                Rows[i] = new Group(i);
            }

            for (var x = 1; x <= 9; x++)
            {
                var column = Columns[x - 1];
                for (var y = 1; y <= 9; y++)
                {
                    var row = Rows[y - 1];
                    var block = Blocks[]
                    var cell = new Cell(x,y);

                }
            }
        }

        private Group GetGroupByXY(short X, short Y, Group[] groups)
        {
            int row = (Y + 1) / 3;
            int column = (X + 1) / 3;
            return groups[row + column];

        }
    }
}
