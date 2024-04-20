using AutoMapper.Configuration.Conventions;
using LifeStyle.generic.Interface;
using LifeStyle.Model.Goals;

namespace LifeStyle.Interface.Goals
{
    public interface IGoalsMonth : IRepositoryBase<GoalsMonth_T>
    {
        List<GoalsMonth_T> BetweenMonth(int num1 , int num2);
    }
}
