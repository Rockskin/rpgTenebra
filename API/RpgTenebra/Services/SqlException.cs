using System;
using System.Runtime.Serialization;

namespace RpgTenebra.Services
{
    [Serializable]
    internal class SqlException : Exception
    {
        public SqlException()
        {
        }

        public SqlException(string message) : base(message)
        {
        }

        public SqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}