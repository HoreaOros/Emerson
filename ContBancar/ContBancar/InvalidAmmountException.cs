using System;
using System.Runtime.Serialization;

namespace ContBancar
{
    [Serializable]
    internal class InvalidAmmountException : Exception
    {
        public InvalidAmmountException()
        {
        }

        public InvalidAmmountException(string message) : base(message)
        {
        }

        public InvalidAmmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAmmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}