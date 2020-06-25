using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace NarekLibrary.Extentions.String
{
    public static class StringExtentions
    {
        /// <summary>
        /// Returns an array of intes, where each index represents the ASCII code of a character
        /// and each value represents how many times that ASCII char apeared in the string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int[] AsciiCharsCount(this string str)
        {
            int[] result = new int[256];
            foreach (char c in str)
            {
                if (c < 256)
                {
                    result[c]++;
                }
            }
            return result;
        }

        /// <summary>
        /// Returnes the longest Class1.csrepeated substring in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string LongestRepeatedSubstring(this string str)
        {
            //Helper nested method
            static ReadOnlyMemory<char> LongCommonSub(ReadOnlyMemory<char> a, ReadOnlyMemory<char> b)
            {
                int length = (a.Length > b.Length) ? b.Length : a.Length;
                int i;
                for (i = 1; i < length; i++)
                {
                    if (!a.Slice(i - 1, 1).ToString().SequenceEqual(b.Slice(i - 1, 1).ToString()))
                    {
                        return a.Slice(0, i - 1);
                    }
                }
                return a.Slice(0, i);
            }


            ReadOnlyMemory<char> s = str.AsMemory();
            List<ReadOnlyMemory<char>> list = new List<ReadOnlyMemory<char>>();
            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s.Slice(i));
            }

            static int compare(ReadOnlyMemory<char> x, ReadOnlyMemory<char> y)
            {
                return x.Span.CompareTo(y.Span, StringComparison.OrdinalIgnoreCase);
            }

            list.Sort(compare);

            ReadOnlyMemory<char> result = ReadOnlyMemory<char>.Empty;
            ReadOnlyMemory<char> temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                temp = LongCommonSub(list[i], list[i + 1]);
                if (temp.Length > result.Length)
                {
                    result = temp;
                }
            }
            return result.ToString();
        }


        /// <summary>
        /// Returns if an string is a valid email address.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsValidEmail(this string email) => Regex.IsMatch(email, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.] +)\.([a-zA-Z]{2,5})$");

        /// <summary>
        /// Rates how much a password is secure(acceptable)
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static int IsSecurePassword(this string password)
        {
            if (password.Length < 5)
            {
                return -1;
            }

            int security = 0;
            if (password.Length >= 8)
            {
                security++;
            }
            if (password.Length > 14)
            {
                security++;
            }
            if (password.ToLower() != password && password.ToUpper() != password)
            {
                security++;
            }
            if (Regex.IsMatch(password, @"[0-9]"))
            {
                security++;
            }
            if (Regex.IsMatch(password, @"[^A-Za-z0-9]"))
            {
                security++;
            }
            return security;
        }

    }
}
