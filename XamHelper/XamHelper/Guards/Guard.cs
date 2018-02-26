using System;
using System.Collections.Generic;
using System.Text;

namespace XamHelper.Guards
{
    public static class Guard
    {
        public static void ThrowIfNotDate(object argumentValue, string argumentName)
        {
            ThrowIfNull(argumentValue, argumentName);
            if (argumentValue?.GetType() != typeof(DateTime))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static void ThrowIfNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }


        public static void ThrowIfNotString(object argumentValue, string argumentName)
        {
            if (argumentValue?.GetType() != typeof(string))
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
        
}
