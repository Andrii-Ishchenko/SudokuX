using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Block
    {
        public Block(int n)
        {
            N = n;
        }
        public int N { get; private set; }
        public List<Cell> Cells { get; private set; }
    }
}
