using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Test
    {
        public static string toFixed(this decimal number, uint decimals)
        {
            return number.ToString("N" + decimals);
        }
    }
}
