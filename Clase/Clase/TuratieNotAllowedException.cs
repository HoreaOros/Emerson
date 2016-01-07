using System;
using System.Runtime.Serialization;

namespace Clase
{
    [Serializable]
    internal class TuratieNotAllowedException : Exception
    {
        public TuratieNotAllowedException()
        {
        }

        public TuratieNotAllowedException(string message) : base(message)
        {
        }

        public TuratieNotAllowedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TuratieNotAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}