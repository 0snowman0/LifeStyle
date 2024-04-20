using LifeStyle.generic.Interface;
using LifeStyle.Model.Goals;

namespace LifeStyle.Interface.Goals
{
    public interface IGoalsWeek : IRepositoryBase<GoalsWeek_T>
    {
        List<GoalsWeek_T?> BetweenWeek(int num1, int num2);

    }
}
