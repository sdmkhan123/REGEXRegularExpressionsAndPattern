using System;
using System.Collections.Generic;
using System.Text;

namespace REGEXRegularExpressionsAndPattern
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionsType
        {
            MESSAGE,
        }
        public ExceptionsType type;
        public UserRegistrationException(ExceptionsType ex, string msg) : base(msg)
        {
            this.type = ex;

        }
    }
}