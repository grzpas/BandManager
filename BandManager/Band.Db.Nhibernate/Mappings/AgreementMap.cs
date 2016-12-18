using Band.Model.Entities;
using FluentNHibernate.Mapping;

namespace Band.Db.Nhibernate.Mappings
{
    public class AgreementMap : ClassMap<Agreement>
    {
        public AgreementMap()
        {
            Table("agreements");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            Map(x => x.Phone);
            Map(x => x.Member);
            Map(x => x.City);
            Map(x => x.Place);
            Map(x => x.StartTime);
            Map(x => x.Remarks);
            Map(x => x.Signed);
            Map(x => x.Amount);
            Map(x => x.DownPayment);
            Map(x => x.TimeStamp);
        }
    }
}