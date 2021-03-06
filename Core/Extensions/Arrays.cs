﻿using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class Arrays
    {
        public static List<T> AsList<T>(params T[] arg)
        {
            return new List<T>(arg);
        }

        public static string ToString(params object[] a)
        {
            if (a == null)
                return "null";

            var iMax = a.Length - 1;
            if (iMax == -1)
                return "[]";

            var b = new StringBuilder();
            b.Append('[');
            for (var i = 0;; i++)
            {
                b.Append(a[i]);
                if (i == iMax)
                    return b.Append(']').ToString();
                b.Append(", ");
            }
        }

        public static bool IsEmpty<T>(this T[] source)
        {
            return source == null || source.Length == 0;
        }
    }
}