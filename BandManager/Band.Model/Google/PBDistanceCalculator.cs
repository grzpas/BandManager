using System;
using Band.Model.Internet;

namespace Band.Model.Google
{
    public class PBDistanceCalculator : DistanceCalculator
    {
        public static string ORIGIN = "Rejterówka";
        public PBDistanceCalculator(MyHttpResponse httpResponse) : base(httpResponse)
        {
            AddLocation(ORIGIN);
        }

        public override long CalculateDistance()
        {
            return (long)Math.Round((base.CalculateDistance() * 2.0)/1000);
        }
    }    
}
