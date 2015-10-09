# Approvals.Net.Asp

```
public void VerifyRoutingTest()
{
   WebApiApprovals.VerifyRouting(WebApiConfig.Register,
       new HttpRequestMessageList { 
           { "api/Values", HttpMethod.Get },
           {"api/Values/5", HttpMethod.Put}});
}
```


Available on NuGet
---
[Install-Package ApprovalTests.Asp](http://nuget.org/packages/ApprovalTests.Asp)

	
## LICENSE
[Apache 2.0 License](https://github.com/SignalR/SignalR/blob/master/LICENSE.md)
