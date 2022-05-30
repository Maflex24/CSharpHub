using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class RemoveTheParenthies
    {
        public static string RemoveParentheses(string s)
        {
            var matches = Regex.Matches(s, @"\(.+\)");

            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    s = s.Replace(match.ToString(), "");
                }
            }
            return s;
        }
    }
}
