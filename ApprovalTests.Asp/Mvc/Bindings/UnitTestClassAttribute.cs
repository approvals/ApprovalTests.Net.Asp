using System;

namespace ApprovalTests.Asp.Mvc.Bindings
{
    [AttributeUsage(AttributeTargets.Class)]
    public class UnitTestClassAttribute : Attribute
    {
        public UnitTestClassAttribute(Type type)
        {
            ClassType = type;
        }
        public Type ClassType { get; set; }
    }
}