using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Gundu_MT
{
        public static class ByteConversion
        {
            public static double MegabytesToBytes(double Input)
            {
                double result = Input * 1024*1024;
                return result;
            }
            public static double GigabytesToMegabytes(double Input)
            {
                double result = Input * 1024;
                return result;
            }
            public static double TerabytesToGigabytes(double Input)
            {
                double result = Input * 1024;
                return result;
            }

        }
}
