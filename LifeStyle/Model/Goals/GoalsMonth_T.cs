using LifeStyle.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyle.Model.Goals
{
    [Table("goalsMonth_Ts")]
    public class GoalsMonth_T : BaseT
    {
        public int NumberOfMonth { get; set; }
        public int NumberOfYear { get; set; }


        public string FirstGoals { get; set; } = string.Empty;
        public string SecondGoals { get; set; } = string.Empty;
        public string ThirdGoals { get; set; } = string.Empty;
        public string FourthGoals { get; set; } = string.Empty;
    }
}
