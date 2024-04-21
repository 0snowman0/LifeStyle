using LifeStyle.generic.Interface;
using LifeStyle.Model.Info;

namespace LifeStyle.Interface.Info
{
    public interface ITextDay : IRepositoryBase<TextDay_T>
    {
        TextDay_T Get_By_Date(DateOnly date);
    }
}
