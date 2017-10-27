using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuX.Core.Utils
{
    public static class GridHelper
    {
        public static int[,] GetDefaultGridValues()
        {
            var arr = new int[9,9];

            var str =   "050027400" +
                        "000605008" +
                        "030100009" +
                        "063000000" +
                        "042000310" +
                        "000000650" +
                        "700006080" +
                        "600903000" +
                        "004850020";


            for (var i = 0; i < str.Length; i++)
            {
                
            }

            return arr;
        }
            
    }
}
