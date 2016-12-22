namespace Band.Business.Songs
{
    public class SongEntity
    {
        private readonly string _entity;

        public SongEntity(string entity)
        {
            _entity = entity;
        }
           
        public override string ToString()
        {
            return _entity;
        }
    }
}
