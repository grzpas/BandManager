namespace Band.Domain
{
    public class Song
    {
        public virtual int Id { get; set; }
        public virtual SongType Type { get; set; }
        public virtual string Title { get; set; }
        public virtual string Scale { get; set;}
        public virtual string Chords { get; set; }
    }
}
