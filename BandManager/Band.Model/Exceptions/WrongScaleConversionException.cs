using System;

namespace Band.Model.Exceptions
{
    public class WrongScaleConversionException : Exception
    {
        public WrongScaleConversionException(string targetScale, string sourceScale)
        :base("Cannot transpose " + sourceScale + " to "  + targetScale)
        {
            
        }
    }
}
