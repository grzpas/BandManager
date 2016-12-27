using Band.Domain;
using FluentNHibernate.Mapping;

namespace Band.Db.Nhibernate.Mappings
{
    public class BandMemberMap : ClassMap<BandMember>
    {
        public BandMemberMap()
        {
            Table("band_members");
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Rate);
        }
    }
}