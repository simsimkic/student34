using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Exception
{
    class NotUniqueException : System.Exception
    {
        public NotUniqueException()
        {

        }
        public NotUniqueException(string message) : base(message)
        {

        }

        public NotUniqueException(string message, System.Exception inner) : base(message, inner)
        {

        }
    }
}
