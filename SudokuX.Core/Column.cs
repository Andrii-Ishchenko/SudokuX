using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Column
    {
        public Column(short x)
        {
                
        }
        public short X { get; private set; }
        public Cell[] Cells { get; private set; } 
    }
}
