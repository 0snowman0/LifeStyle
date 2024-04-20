using LifeStyle.Dto.Goals.Year.common;

namespace LifeStyle.Dto.Goals.Year.Command
{
    public class YearGoals_Create_Dto : IYearGoals_Dto
    {
        public int NumberOfYear { get; set; }


        public string FirstGoals { get; set; } = string.Empty;
        public string SecondGoals { get; set; } = string.Empty;
        public string ThirdGoals { get; set; } = string.Empty;
        public string FourthGoals { get; set; } = string.Empty;
    }
}
