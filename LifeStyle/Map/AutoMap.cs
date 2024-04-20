using LifeStyle.Dto.Goals.Month.Command;
using LifeStyle.Dto.Goals.Month.Quesreis;
using LifeStyle.Dto.Goals.Week.Command;
using LifeStyle.Dto.Goals.Week.Quesreis;
using LifeStyle.Dto.Goals.Year.Command;
using LifeStyle.Dto.Goals.Year.Quesreis;
using LifeStyle.Model.Goals;

namespace LifeStyle.Map
{
    public class AutoMap : AutoMapper.Profile
    {
        public AutoMap()
        {

            #region Goals


            #region Year
            CreateMap<YearGoals_T, YearGoals_D>().ReverseMap();

            CreateMap<YearGoals_T, YearGoals_Create_D>().ReverseMap();

            CreateMap<YearGoals_T, YearGoals_Update_D>().ReverseMap();
            #endregion

            #region Month

            CreateMap<GoalsMonth_T,GoalsMonth_D>().ReverseMap();

            CreateMap<GoalsMonth_T,GoalsMonth_Create_D>().ReverseMap();

            CreateMap<GoalsMonth_T,GoalsMonth_Update_D>().ReverseMap();

            #endregion


            #region Week


            CreateMap<GoalsWeek_T, GoalsWeek_D>().ReverseMap();

            CreateMap<GoalsWeek_T, GoalsWeek_Create_D>().ReverseMap();

            CreateMap<GoalsWeek_T, GoalsWeek_Update_D>().ReverseMap();


            #endregion


            #endregion

        }
    }
}