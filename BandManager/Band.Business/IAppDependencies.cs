using Band.Domain;

namespace Band.Business
{
    public interface IAppDependencies
    {
        IRepository<Song, string> SongRepository { get; set; }
        IRepository<Agreement, int> AgreementsRepository { get; set; }
    }
}
