using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBlog.Models.Common
{
    public static class ArrayExtensions
    {
        public static int Push<T>(this T[] source, T value)
        {
            var index = Array.IndexOf(source, default(T));

            if (index != -1)
            {
                source[index] = value;
            }

            return index;
        }
    }
}
