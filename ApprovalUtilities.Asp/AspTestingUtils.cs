using System.Web.UI;

namespace ApprovalUtilities.Asp
{
    public class AspTestingUtils
    {
        public static bool DivertTestCall(Page aspxPage)
        {
            var methodName = aspxPage.Page.ClientQueryString;
            if (methodName.StartsWith("Test"))
            {
                var methodInfo = aspxPage.GetType().GetMethod(methodName);
                if (methodInfo != null)
                {
                    methodInfo.Invoke(aspxPage, null);
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}