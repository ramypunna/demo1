using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedCSharpDemos
{
    public class UserInvalidException : Exception
    {
        public UserInvalidException(string message) : base(message)
        {

        }

        public UserInvalidException(string message, Exception innerException) : base(message,innerException)
        {

        }

    }
}
