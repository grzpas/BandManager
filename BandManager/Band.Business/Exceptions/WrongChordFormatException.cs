using System;

namespace Band.Business.Exceptions
{
    public class WrongChordFormatException : Exception
    {
        public WrongChordFormatException(string identity)
        :base("Wrong format of chord: " + identity)
        {
            
        }
    }
}
