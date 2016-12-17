using Band.Model.Entities;
using FluentNHibernate.Mapping;

namespace Band.Model.Mappings
{
    public class SongMap : ClassMap<Song>
    {
        public SongMap()
        {
            Table("songs");
            Id(x => x.Title);
            Map(x => x.Type);
            Map(x => x.Scale);
            Map(x => x.Chords);
        }
    }
}
