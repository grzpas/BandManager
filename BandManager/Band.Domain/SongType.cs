
namespace Band.Domain
{
    public class SongType
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}