using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ExtensionMethods
{
    public static class StringExt
    {
        public static string changeFirstLettersCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] arr = inputString.ToCharArray();
                arr[0] = Char.IsLower(arr[0]) ? Char.ToUpper(arr[0]) : Char.ToLower(arr[0]);
                return new string(arr);
            }

            return inputString;
        }
    }
}
