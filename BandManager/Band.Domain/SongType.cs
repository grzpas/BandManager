
namespace Band.Domain
{
    public class SongType : BindableBase
    {
        private int _id;
        private string _name;

        public virtual int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public virtual string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}