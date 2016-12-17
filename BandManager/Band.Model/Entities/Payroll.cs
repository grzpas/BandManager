using System;

namespace Band.Model.Entities
{
    public class Payroll
    {
        public virtual int Id {get; private set;}
        public virtual DateTime Date { get; set; }
        public virtual decimal Total { get; set; }
        public virtual decimal Transport { get; set; }
        public virtual decimal GP { get; set; }
        public virtual decimal PG { get; set; }
        public virtual decimal KP { get; set; }
        public virtual decimal TH { get; set; }
        public virtual decimal DB { get; set; }
        public virtual decimal Extra { get; set; }
        public virtual DateTime TimeStamp { get; set; }
    }
}
