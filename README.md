# Approvals.Net.Asp

Allows you to write simple tests againist Asp & Mvc pages.

Mvc Pages
---
Testing Rendered Mvc pages is fairly simple The main code is 

```
 MvcApprovals.VerifyMvcPage<YourTestableController>(c => c.TestName);

```
[Full Example](https://github.com/approvals/Approvals.Net.Asp/blob/master/ApprovalTests.Asp.Tests/Mvc/MvcTest.cs)

The Main points are:  

  1) Using CassiniDevServer to host a webserver at test time  
  2) Creating a TestableController Page to call  
  3) Adding ``` UnitTestBootStrap.Register(this);  ``` to your   [Global.asax](https://github.com/approvals/Approvals.Net.Asp/blob/master/MvcApplication.Razor/Global.asax.cs)  
  4) Using ```.Explicit()``` on your [views](https://github.com/approvals/Approvals.Net.Asp/blob/master/MvcApplication.Razor/Controllers/CoolController.cs)
   

Routes
---
You can also easily test your routes 
```
[TestMethod]
public void TestRoutes()
{
	var urls = new[] {"/Home/Index/Hello", "/"};
	AspApprovals.VerifyRouting(MvcApplication.RegisterRoutes, urls);
}
```
Which will product Golden Master Files like 

```
/Home/Index/Hello => [[controller, Home], [action, Index], [id, Hello]] 
/ => [[controller, Cool], [action, Index], [id, ]] 
```

Asp Pages
---
Approvals can also unit test any urls that produce reliable output (think static pages).  
Here's a [good video](https://www.youtube.com/watch?v=52YouQkd-f8) to explain all the inner workings

Available on NuGet (soon)
---
[Install-Package ApprovalTests.Asp](http://nuget.org/packages/ApprovalTests.Asp)

	
## LICENSE
[Apache 2.0 License](https://github.com/SignalR/SignalR/blob/master/LICENSE.md)

Contributers
---
The vast majority of this was created by @jamesrcounts & @Lnknaveen with help from @isidore
