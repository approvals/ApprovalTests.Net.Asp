using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApprovalUtilities.Utilities;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace ApprovalTests.Asp.Mvc.Utilities
{
    public static class PathScrubbers
    {
        public static Func<string, string> ScrubPath()
        {
            var path = PathUtilities.GetDirectoryForCaller(1);
            return text =>
            {
                var replaceWith = "..." + Path.DirectorySeparatorChar;
                return text.ReplaceAllIgnoreCase(path, replaceWith);
            };
        }
    }
}
