using System;
using System.Runtime.Serialization;

namespace exception_handling_form
{
    [Serializable]
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
        }

        public InvalidAgeException(string message) : base(message)
        {
        }

        public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}