using Band.Domain;
using FluentNHibernate.Mapping;

namespace Band.Db.Nhibernate.Mappings
{
    public class SongTypeMap : ClassMap<SongType>
    {
        public SongTypeMap()
        {
            Table("song_type");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}