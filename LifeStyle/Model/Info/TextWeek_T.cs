using LifeStyle.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyle.Model.Info
{
    [Table("textWeek_Ts")]
    public class TextWeek_T : BaseT
    {
        public int NumberOfYear { get; set; }
        public int numberOfWeek { get; set; }
        public string Content { get; set; } = null!;
    }
}
