using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Row
    {
        public Row(short y)
        {
            
        }
        public short Y { get; private set; }
        public Cell[] Cells { get; private set; } 
    }
}
