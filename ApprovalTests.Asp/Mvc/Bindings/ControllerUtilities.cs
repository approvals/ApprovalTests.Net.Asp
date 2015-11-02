using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web.Mvc;

namespace ApprovalTests.Asp.Mvc.Bindings
{
    public static class ControllerUtilities
    {

        public static string GetMethodName(Expression expression)
        {
            var unaryExpression = (UnaryExpression)expression;
            var methodCallExpression = (MethodCallExpression)unaryExpression.Operand;
            var constantExpression = (ConstantExpression)(methodCallExpression.Object ?? methodCallExpression.Arguments.Last());
            var methodInfo = (MemberInfo)constantExpression.Value;
            return methodInfo.Name;
        }

        public static string GetControllerName(this Type type)
        {
            return type.Name.Replace("Controller", string.Empty);
        }

        public static Type GetControllerType(this Assembly assembly, string controllerName)
        {
            string[] names = { controllerName, controllerName + "Controller" };
            return assembly.GetTypes().First(t => names.Contains(t.Name, StringComparer.InvariantCultureIgnoreCase));
        }
    }
}
