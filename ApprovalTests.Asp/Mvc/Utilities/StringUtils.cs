using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApprovalTests.Asp.Mvc.Utilities
{
    public static class StringUtils
    {
        public static string ReplaceAllIgnoreCase(this string text, string path, string replaceWith)
        {
            var startIndex = text.IndexOf(path, StringComparison.InvariantCultureIgnoreCase);
            while (startIndex != -1)
            {
                var replacable = text.Substring(startIndex, path.Length);
                text = text.Replace(replacable, replaceWith);

                startIndex = text.IndexOf(path, StringComparison.InvariantCultureIgnoreCase);
            }

            return text;
        }
    }
}
