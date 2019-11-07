# Approvals.Net.Asp

[![Build status](https://ci.appveyor.com/api/projects/status/5anju45px3p3twak?svg=true)](https://ci.appveyor.com/project/isidore/approvaltests-net-asp) [![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0) [![NuGet Status](http://img.shields.io/nuget/v/ApprovalTests.svg?style=flat)](https://www.nuget.org/packages/ApprovalTests.asp)


Allows you to write simple tests against Asp & Mvc pages.

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
  3) Adding ``` UnitTestBootStrap.RegisterWithDebugCondition("YourAssembyName");  ``` to your   [Global.asax](https://github.com/approvals/Approvals.Net.Asp/blob/master/MvcApplication.Razor/Global.asax.cs)  
  4) Using ```.Explicit()``` on your [views](https://github.com/approvals/Approvals.Net.Asp/blob/master/MvcApplication.Razor/Controllers/ExampleController.cs) or extending ``` : ControllerWithExplicitViews ```
   

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

Available on NuGet
---
[Install-Package ApprovalTests.Asp](http://nuget.org/packages/ApprovalTests.Asp)

	
## LICENSE
[Apache 2.0 License](https://github.com/SignalR/SignalR/blob/master/LICENSE.md)

Contributors
---
The vast majority of this was created by @jamesrcounts & @Lnknaveen with help from @isidore

## Explicit Names
If you need to add seams into your production code for testing, you will need the following added to you runtime

```c#
using System;
using System.Web.Mvc;
using ApprovalUtilities.CallStack;

public static class MvcUtilites
{
	public static ViewResult CallViewResult<T>(Func<T, ActionResult> call, T parameter)
	{
	    var actionResult = (ViewResult) call(parameter);
	    actionResult.ViewName = call.Method.Name;
	    return actionResult;
	}

	public static ViewResult Explicit(this ViewResult view)
	{
	    view.ViewName = new Caller().Method.Name;
	    return view;
	}
}

```
