using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Group : IEnumerable<Cell>
    {
        public Group(short index)
        {
            Cells = new List<Cell>();
        }

        public short Index { get; private set; }
        public List<Cell> Cells { get; }

        public void AddCell(Cell cell)
        {
            Cells.Add(cell);
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            return ((IEnumerable<Cell>) Cells).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
