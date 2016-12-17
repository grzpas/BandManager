using System.Collections.Generic;
using Band.Model.Entities;

namespace Band.Model.Payroll
{
    public class PayrollManager
    {
        private readonly decimal _amount;        
        private readonly decimal _transportCost;
        private readonly List<BandMember> _bandMembers;
        public PayrollManager(decimal amount, decimal transportCost, List<BandMember> bandMembers)
        {
            _amount = amount;            
            _transportCost = transportCost;
            _bandMembers = bandMembers;
        }
                                                       
        public decimal GetPayByName(string name)
        {
            return 0;
        }
       
        public  BandMember GetBandMemberByName(string name)
        {
            return _bandMembers.Find(x => x.Name == name);
        }
    }
}
