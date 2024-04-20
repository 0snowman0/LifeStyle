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
            CreateMap<YearGoals_T, YearGoals_Dto>().ReverseMap();

            CreateMap<YearGoals_T, YearGoals_Create_Dto>().ReverseMap();

            CreateMap<YearGoals_T, YearGoals_Update_Dto>().ReverseMap();
            #endregion



            #endregion

        }
    }
}