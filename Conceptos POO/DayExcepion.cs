using System.Runtime.Serialization;

namespace ConceptosPOO
{
    [Serializable]
    internal class DayExcepion : Exception
    {
        public DayExcepion()
        {
        }

        public DayExcepion(string? message) : base(message)
        {
        }

        public DayExcepion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayExcepion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}