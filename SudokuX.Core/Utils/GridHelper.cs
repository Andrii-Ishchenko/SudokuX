using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core.Utils
{
    public static class GridHelper
    {
        public static short[,] GetValuesFromString(string valueString)
        {
            var arr = new short[9,9];



            for (var i = 0; i < valueString.Length; i++)
            {
                var col = i%9;
                var row = i/9;

                short digit = (short) char.GetNumericValue(valueString[i]);

                arr[row, col] = digit;
            }

            return arr;
        }         
    }
}
