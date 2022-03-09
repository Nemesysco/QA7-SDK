using System;

namespace NMS.Core.Utility
{
    public static class NumberUtility
    {
        public static int ToInt(string str)
        {
            return int.TryParse(str, out int cInt) ? cInt : default(int);
        }

        public static decimal ToDecimal(string str)
        {
            return decimal.TryParse(str, out decimal cDecimal) ? cDecimal : default(decimal);
        }

        public static double ToDouble(string str)
        {
            return double.TryParse(str, out double cdouble) ? cdouble : default(double);
        }
    }
}
