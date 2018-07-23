using System;
using System.Runtime.Serialization;

namespace WMISample
{
    [Serializable]
    internal class ManagementException : Exception
    {
        public ManagementException()
        {
        }

        public ManagementException(string message) : base(message)
        {
        }

        public ManagementException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ManagementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}