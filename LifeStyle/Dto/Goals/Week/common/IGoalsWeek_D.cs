﻿namespace LifeStyle.Dto.Goals.Week.common
{
    public interface IGoalsWeek_D
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
