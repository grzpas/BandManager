using System.Collections.Generic;

namespace Band.Model.Entities
{
    public class Band
    {
        public const string GP = "GP";
        public const string PG = "PG";
        public const string KP = "KP";
        public const string TH = "TH";
        public const string DB = "DB";

        public static List<BandMember> BandMembers()
        {
            var members = new List<BandMember> {
                                  new BandMember(GP, 1.0),
                                  new BandMember(PG, 1.0),
                                  new BandMember(KP, 1.0),
                                  new BandMember(TH, 1.0),
                                  new BandMember(DB, 350/500.0)
                              };
            return members;
        }

        public static BandMember GetBandMemberByName(string name)
        {
            return BandMembers().Find(x => x.Name == name);
        }
    }
}
