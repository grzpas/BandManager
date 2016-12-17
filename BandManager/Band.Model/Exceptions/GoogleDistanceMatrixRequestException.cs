using System;

namespace Band.Model.Exceptions
{
    public class GoogleDistanceMatrixRequestException : Exception
    {
        public GoogleDistanceMatrixRequestException(string requestUrl, string status)
            : base("Google Distance Matrix API call failed: " + requestUrl + ", status: " + status)
        {

        }
    }
}
