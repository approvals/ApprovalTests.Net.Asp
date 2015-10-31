using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;

namespace ApprovalTests.Asp.Mvc
{
    public static class ReflectionUtility
    {
        public static string GetControllerName<T>()
            where T : IController
        {
            var name = typeof(T).Name;
            return name.EndsWith("Controller") ? name.Substring(0, name.Length - "Controller".Length) : name;
        }

        public static string GetMethodName<T>(Expression<Func<T, Func<ActionResult>>> expression)
        {
            var unaryExpression = (UnaryExpression)expression.Body;
            var methodCallExpression = (MethodCallExpression)unaryExpression.Operand;
            var constantExpression = (ConstantExpression)methodCallExpression.Object;
            var methodInfo = (MemberInfo)constantExpression.Value;
            return methodInfo.Name;
        }
    }
}