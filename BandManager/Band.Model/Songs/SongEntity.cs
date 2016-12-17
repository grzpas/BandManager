namespace Band.Model.Songs
{
    public class SongEntity
    {
        private string _entity;

        public SongEntity(string entity)
        {
            _entity = entity;
        }
           
        public new string ToString()
        {
            return _entity;
        }
    }
}
