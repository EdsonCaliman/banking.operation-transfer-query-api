using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Net.Core.Template.Domain.Abstractions.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException()
        {
        }

        public BusinessException(string message) : base(message)
        {
        }

        public BusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public BusinessException(string type, string message) : base(message)
        {
            Message = message;
            Type = type;
        }

        public string Type { get; private set; }
        public new string Message { get; private set; }
    }
}
