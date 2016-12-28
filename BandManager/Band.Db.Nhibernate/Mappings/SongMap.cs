using Band.Domain;
using FluentNHibernate.Mapping;

namespace Band.Db.Nhibernate.Mappings
{
    public class SongMap : ClassMap<Song>
    {
        public SongMap()
        {
            Table("songs");
            Id(x => x.Id);
            Map(x => x.Title).Unique();
            References(x => x.Type).ForeignKey();
            Map(x => x.Scale);
            Map(x => x.Chords);
        }
    }
}
