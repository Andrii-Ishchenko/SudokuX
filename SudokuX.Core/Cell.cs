using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Cell
    {
        public Cell (int x, int y, Group block, Group row, Group column, int value)
	    {
            digits = new bool[9];
            selectedDigits = new List<short>();
            IsValueSet = false;

            block.AddCell(this);
            row.AddCell(this);
            column.AddCell(this);

            X = x;
            Y = y;
	    }

        readonly bool[] digits;
        readonly List<short> selectedDigits;

        
        public int X {get; private set;}
        public int Y {get; private set;}


        public Group Row { get; private set; }
        public Group Column { get; private set; }
        public Group Block { get; private set; }

        public bool IsValueSet { get; private set; }
        public bool IsReadOnly { get; private set; }
        public short Value { get; private set;}

        public List<short> Digits { get { return selectedDigits.Select(x => x).ToList(); } }

        public bool IsDigitSet(short digit)
        {
            return digits[digit-1];
        }

        public void SetDigit(short digit)
        {
            digits[digit-1] = true;
            if (!selectedDigits.Contains(digit))
            {
                selectedDigits.Add(digit);
            }            
        }

        public void RemoveDigit(short digit)
        {
            digits[digit - 1] = false;
            if (selectedDigits.Contains(digit))
            {
                selectedDigits.Remove(digit);
            }
        }

        public void ToggleDigit(short digit)
        {
            if (IsDigitSet(digit))
            {
                SetDigit(digit);
            }
            else
            {
                RemoveDigit(digit);
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
            foreach (var cell in Block)
            {
                if (cell == this)
                    continue;

                cell.RemoveDigit(this.Value);
            }

            foreach (var cell in Row)
            {
                if (cell == this)
                    continue;

                cell.RemoveDigit(this.Value);
            }

            foreach (var cell in Column)
            {
                if (cell == this)
                    continue;

                cell.RemoveDigit(this.Value);
            }
        }
    }
}
