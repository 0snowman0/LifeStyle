using MD.PersianDateTime;
using System.Globalization;
namespace LifeStyle.Interface.Calculate
{
    public interface ICalculate
    {
        int NumberOfDay(PersianDateTime StartDate);
        int NumberOfWeek(PersianDateTime StartDate);
        int NumberOfMonth(PersianDateTime StartDate);
        int NumberOfThreeMonth(PersianDateTime StartDate);
        int NumberOfYear(PersianDateTime StartDate);

    }
}
