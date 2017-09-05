using System;
using System.Collections.Generic;
using System.Text;

namespace EPI_in_CSharp
{
    public class Ch4_primitive_types
    {
        public static int countBits(int x)
        {
            int count = 0; 
            while (x != 0)
            {
                count += (x & 1);
                x = x >> 1; 
            }
            return count; 
        }
    }
}
