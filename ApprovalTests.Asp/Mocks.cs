using System.Collections.Specialized;
using System.Web;

namespace ApprovalTests.Asp
{
    public class MockContextBase : HttpContextBase
    {
        private readonly string url;

        public MockContextBase(string url)
        {
            this.url = url;
        }

        public override HttpRequestBase Request => new MockHttpRequest(url);

        public override HttpResponseBase Response => new MockHttpResponse();
    }

    public class MockHttpResponse : HttpResponseBase
    {
        public override string ApplyAppPathModifier(string virtualPath)
        {
            return virtualPath;
        }
    }

    public class MockHttpRequest : HttpRequestBase
    {
        private readonly string url;

        public MockHttpRequest(string url)
        {
            this.url = url;
        }

        public override string AppRelativeCurrentExecutionFilePath => url;

        public override string ApplicationPath => url.Substring(1);

        public override string PathInfo => "";

        public override NameValueCollection ServerVariables => new NameValueCollection();
    }
}