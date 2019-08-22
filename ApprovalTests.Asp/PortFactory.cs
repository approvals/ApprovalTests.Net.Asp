using System;

namespace ApprovalTests.Asp
{
    public class PortFactory
    {
        private static int? aspPort;

        private static int? mvcPort;

        public static int AspPort
        {
            get
            {
                if (aspPort == null)
                    throw new MissingFieldException(
                        $@"{typeof(PortFactory).FullName}.AspPort is uninitialized.
You are using a method that is using {typeof(PortFactory).FullName}.AspPort,
but you have not set a value for this port first");
                return (int) aspPort;
            }
            set => aspPort = value;
        }

        public static int MvcPort
        {
            get
            {
                if (mvcPort == null)
                    throw new MissingFieldException(
                        $@"{typeof(PortFactory).FullName}.MvcPort is uninitialized.
You are using a method that is using {typeof(PortFactory).FullName}.MvcPort,
but you have not set a value for this port first");
                return (int) mvcPort;
            }
            set => mvcPort = value;
        }
    }
}