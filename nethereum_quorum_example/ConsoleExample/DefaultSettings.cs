using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExample
{
    public sealed class DefaultSettings
    {
        public static string QuorumIPAddress = "http://10.11.12.88";
        public static string QuorumPort = "22000";

        public static string GetDefaultUrl()
        {
            return QuorumIPAddress + ":" + QuorumPort;
        }
    }
}
