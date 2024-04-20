using LifeStyle.Dto.Common;

namespace LifeStyle.Dto.Goals.Year.Quesreis
{
    public class YearGoals_Dto : Base_Dto
    {
        public int NumberOfYear { get; set; }


        public string FirstGoals { get; set; } = string.Empty;
        public string SecondGoals { get; set; } = string.Empty;
        public string ThirdGoals { get; set; } = string.Empty;
        public string FourthGoals { get; set; } = string.Empty;
    }
}
