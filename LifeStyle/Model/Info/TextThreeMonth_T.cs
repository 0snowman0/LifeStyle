using LifeStyle.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyle.Model.Info
{
    [Table("textThreeMonth_Ts")]
    public class TextThreeMonth_T : BaseT
    {
        public int NumberOfYear { get; set; }
        public int NumberOfThreeMonth { get; set; }
        public string Content { get; set; } = null!;
    }
}
