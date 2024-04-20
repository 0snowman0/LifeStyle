using AutoMapper.Configuration.Conventions;
using LifeStyle.Model.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace LifeStyle.Model.Goals
{
    [Table("yearGoals_Ts")]
    public class YearGoals_T : BaseT
    {
        public int NumberOfYear { get; set; }


        public  string FirstGoals { get; set; } = string.Empty;
        public  string SecondGoals { get; set; } = string.Empty;
        public string ThirdGoals { get; set; } = string.Empty;
        public string FourthGoals { get; set; } = string.Empty;
    }
}
