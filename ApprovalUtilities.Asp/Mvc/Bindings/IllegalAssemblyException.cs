using System;

namespace ApprovalUtilities.Asp.Mvc.Bindings
{
    public class IllegalAssemblyException : Exception
    {
        public readonly string assemblyPath;

        public IllegalAssemblyException(string assemblyPath)
        {
            this.assemblyPath = assemblyPath;
        }
    }
}