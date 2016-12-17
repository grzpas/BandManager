using Band.Model.Entities;

namespace Band.Model.Payroll
{
    public interface IPayrollProcessor
    {
        decimal GetPayOfRightFullMemberByName(BandMember bandMember);
        decimal GetPayByName(string name);
    }
}
