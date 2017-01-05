namespace Band.Domain
{
    public class Song : BindableBase
    {
        private int _id;
        private SongType _type;
        private string _title;
        private string _scale;
        private string _chords;

        public virtual int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public virtual SongType Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }

        public virtual string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public virtual string Scale
        {
            get { return _scale; }
            set { SetProperty(ref _scale, value); }
        }

        public virtual string Chords
        {
            get { return _chords; }
            set { SetProperty(ref _chords, value); }
        }
    }
}
