using System.Text.RegularExpressions;

namespace ApprovalTests.Asp.Mvc.Utilities
{
    public class MvcScrubbers
    {

        public static string ScrubMvcVerificationToken(string input)
        {
            string AspViewState = "<input name=\"__RequestVerificationToken\" type=\"hidden\" value=\".+/>";
            return Regex.Replace(input, AspViewState, "<!-- request verification token -->");
        }
    }
}