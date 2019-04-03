using System;
using System.Runtime.Serialization;

namespace ChuckNorrisAPI
{
    /// <summary>
    /// Thrown when a joke is requested that does not exist
    /// </summary>
    [Serializable]
    public class NoSuchQuoteException : Exception
    {
        public NoSuchQuoteException()
        {
        }

        public NoSuchQuoteException(string message) : base(message)
        {
        }

        public NoSuchQuoteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSuchQuoteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}