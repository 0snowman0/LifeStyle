using LifeStyle.Dto.Common;

namespace LifeStyle.Dto.Goals.Week.Quesreis
{
    public class GoalsWeek_D : Base_Dto
    {
        public int NumberOfYear { get; set; }
        public int NumberOfMonth { get; set; }
        public int NumberOfWeek { get; set; }


        public string FirstGoals { get; set; }
        public string SecondGoals { get; set; }
        public string ThirdGoals { get; set; }
        public string FourthGoals { get; set; }
    }
}
