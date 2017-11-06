using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Cell
    {
        public Cell (short x, short y, Group block, Group row, Group column, short value)
	    {
            candidatesFlags = new bool[9];
            candidates = new List<short>();

            Block = block;
            Row = row;
            Column = column;

            if (value == 0)
            {
                IsValueSet = false;
                IsReadOnly = false;
            }
            else
            {
                Value = value;
                IsValueSet = true;
                IsReadOnly = true;
            }
        
            block.AddCell(this);
            row.AddCell(this);
            column.AddCell(this);

            X = x;
            Y = y;
	    }

        readonly bool[] candidatesFlags;
        readonly List<short> candidates;

        
        public short X {get; }
        public short Y {get; }

        public short Index => (short)(X + 9*Y);

        public Group Row { get; private set; }
        public Group Column { get; private set; }
        public Group Block { get; private set; }

        public bool IsValueSet { get; private set; }
        public bool IsReadOnly { get; private set; }
        public short Value { get; private set;}

        /*Makes a copy of the list to not break incapsulation*/
        public List<short> Candidates { get { return candidates.Select(x => x).ToList(); } }

        public bool IsCandidateSet(short candidate)
        {
            return candidatesFlags[candidate-1];
        }

        public void SetCandidate(short candidate)
        {
            candidatesFlags[candidate-1] = true;
            if (!candidates.Contains(candidate))
            {
                candidates.Add(candidate);
            }            
        }

        public void RemoveCandidate(short candidate)
        {
            candidatesFlags[candidate - 1] = false;
            if (candidates.Contains(candidate))
            {
                candidates.Remove(candidate);
            }
        }

        public void ToggleCandidate(short candidate)
        {
            if (IsCandidateSet(candidate))
            {
                SetCandidate(candidate);
            }
            else
            {
                RemoveCandidate(candidate);
            }
        }

        public void SetValue(short value)
        {
            if(IsValueSet || IsReadOnly)
                return;

            Value = value;
            IsValueSet = true;
        }

        public void EliminateValueFromGroups()
        {
            Block.EliminateCandidate(Value, this);
            Row.EliminateCandidate(Value, this);
            Column.EliminateCandidate(Value, this);
        }
    }
}
