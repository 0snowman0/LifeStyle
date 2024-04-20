using LifeStyle.generic;
using LifeStyle.generic.Interface;
using LifeStyle.Model.Goals;

namespace LifeStyle.Interface.Goals
{
    public interface IYearGoals : IRepositoryBase<YearGoals_T>
    {
        YearGoals_T Get_WithNumberOfYear(int num);
    }
}
