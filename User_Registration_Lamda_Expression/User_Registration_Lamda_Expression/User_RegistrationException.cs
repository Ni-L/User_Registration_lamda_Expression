using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_Lamda_Expression
{/// <summary>
/// User-Registration Exception Class for Handling exceptions
/// </summary>
    class User_RegistrationException : Exception
    {
        public enum ExceptionType//Enum method of exception type to declare constants for exception types
        {
            ENTERD_NULL_EXCEPTION,
            ENTERD_EMPTY_EXCEPTION,
            IVALID_INPUT,
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_PASSWORD,
            INVALID_EMAIL_ID,
            INVALID_MOBILE_NUMBER,
            INVALID_EMAILLIST
        }

        ExceptionType type;
        readonly string message;

        //Constructor class for custom exception and passing message to base class.
        public User_RegistrationException(ExceptionType type, string message) : base(message)
        {
            //instance 
            this.type = type;
            this.message = message;
        }
    }
}
