using System;

namespace Greatt.DAL.Exception
{
    public class EntityException : ArgumentException
    {
        public EntityException() : base()
        {
        }

        public EntityException(string message) : base(message)
        {
        }
    }
}
