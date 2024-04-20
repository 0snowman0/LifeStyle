using LifeStyle.Dto.Common;
using LifeStyle.Dto.Goals.Month.common;

namespace LifeStyle.Dto.Goals.Month.Command
{
    public class GoalsMonth_Update_D : Base_Dto , IGoalsMonth_D
    {
        public int NumberOfMonth { get; set; }
        public int NumberOfYear { get; set; }


        public string FirstGoals { get; set; }
        public string SecondGoals { get; set; }
        public string ThirdGoals { get; set; }
        public string FourthGoals { get; set; }
    }
}
