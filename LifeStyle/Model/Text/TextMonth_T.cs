using LifeStyle.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyle.Model.Info
{
    [Table("textMonth_Ts")]
    public class TextMonth_T : BaseT
    {
        public int NumberOfYear { get; set; }
        public int NumberOfMonth { get; set; }
        public string Content { get; set; } = null!;
    }
}
