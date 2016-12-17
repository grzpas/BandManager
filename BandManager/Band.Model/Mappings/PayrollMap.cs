using FluentNHibernate.Mapping;

namespace Band.Model.Mappings
{
    public class PayrollMap : ClassMap<Entities.Payroll>
    {
        public PayrollMap()
        {
            Table("payroll");
            Id(x => x.Id);
            Map(x => x.Total);
            Map(x => x.Transport);
            Map(x => x.Extra);
            Map(x => x.Date);
            Map(x => x.GP);
            Map(x => x.PG);
            Map(x => x.KP);
            Map(x => x.TH);
            Map(x => x.DB);
            Map(x => x.TimeStamp);
        }
    }
}
