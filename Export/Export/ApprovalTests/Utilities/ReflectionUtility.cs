using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web.Mvc;

namespace ApprovalTests.Utilities
{
    public static class ReflectionUtility
    {
        public static string GetControllerName<T>()
            where T : IController
        {
            return typeof(T).GetControllerName();
        }

        public static string GetControllerName(this Type type)
        {
            return type.Name.Replace("Controller", string.Empty);
        }

        public static string GetMethodName(Expression expression)
        {
            var unaryExpression = (UnaryExpression)expression;
            var methodCallExpression = (MethodCallExpression)unaryExpression.Operand;
            var constantExpression = (ConstantExpression)methodCallExpression.Object;
            var methodInfo = (MemberInfo)constantExpression.Value;
            return methodInfo.Name;
        }

        public static T GetCustomAttribute<T>(this Type t)
            where T : class
        {
            return t.GetCustomAttributes(typeof(T), true).FirstOrDefault() as T;
        }

        public static Type GetController(this Assembly assembly, string controllerName)
        {
            return assembly.GetTypes().First(t => t.Name.Equals(string.Concat(controllerName, "Controller"), StringComparison.OrdinalIgnoreCase));
        }

    }
}
