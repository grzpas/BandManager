namespace Band.Domain
{
    public class BandMember
    {
        public virtual int Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual double Rate { get; set; }
    }
}
