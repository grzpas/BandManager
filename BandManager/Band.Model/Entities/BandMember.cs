namespace Band.Model.Entities
{
    public class BandMember
    {
        private string _name;
        private double _rate;                
        public BandMember(string name, double rate)
        {
            Name = name;
            Rate = rate;                        
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }               
    }
}
