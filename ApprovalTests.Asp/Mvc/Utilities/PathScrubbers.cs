using System;
using ApprovalUtilities.Utilities;
using System.IO;

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
