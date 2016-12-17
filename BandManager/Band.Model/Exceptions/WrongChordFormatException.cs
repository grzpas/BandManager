using System;

namespace Band.Model.Exceptions
{
    public class WrongChordFormatException : Exception
    {
        public WrongChordFormatException(string identity)
        :base("Wrong format of chord: " + identity)
        {
            
        }
    }
}
