using Band.Domain;

namespace Band.Business
{
    public interface IAppDependencies
    {
        IRepository<Song, string> SongRepository { get; }
    }
}
