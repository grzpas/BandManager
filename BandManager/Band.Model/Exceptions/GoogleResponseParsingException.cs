using System;

namespace Band.Model.Exceptions
{
    class GoogleResponseParsingException : Exception
    {
        public GoogleResponseParsingException(string message) 
            :base("Google reponse parsing exception: " + message)
        {
        
        }
    }
}
