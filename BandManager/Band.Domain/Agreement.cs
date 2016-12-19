using System;

namespace Band.Domain
{
    public class Agreement 
    {
        public virtual int Id { get; private set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Member { get; set; }
        public virtual string City { get; set; }
        public virtual string Place { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual string Remarks { get; set; }
        public virtual bool Signed { get; set; }
        public virtual decimal ? Amount { get; set; }
        public virtual decimal ? DownPayment { get; set; }
        public virtual DateTime TimeStamp { get; set; }
    }
}