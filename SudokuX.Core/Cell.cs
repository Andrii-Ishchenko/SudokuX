﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core
{
    public class Cell
    {
        public Cell (int x, int y, Block block, Row row, Column column)
	    {
            digits = new bool[9];
            selectedDigits = new List<short>();
            IsValueSet = false;
	    }

        readonly bool[] digits;
        readonly List<short> selectedDigits;

        public int X {get; private set;}
        public int Y {get; private set;}

        public Row Row { get; private set; }
        public Column Column { get; private set; }
        public Block Block { get; private set; }

        public bool IsValueSet { get; private set; }
        public bool IsPredefined { get; private set; }
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
            if(IsValueSet || IsPredefined)
                return;

            Value = value;
            IsValueSet = true;
        }
    }
}