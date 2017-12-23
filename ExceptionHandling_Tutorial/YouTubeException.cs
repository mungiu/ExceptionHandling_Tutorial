using System;

namespace ExceptionHandling_Tutorial
{
    //////////////////////////////// CUSTOM EXCEPTIONS ////////////////////////
    /// Used for concealing exceptions (typically lower level)
    public class YouTubeException : Exception
    {
        //NOTE: calling the "base" ctor of the exception class and passing data
        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {
            //This exception can display anything
            //It passes any message and inner exception to "base"

        }
    }
}
