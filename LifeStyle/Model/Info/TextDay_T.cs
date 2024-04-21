using LifeStyle.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyle.Model.Info
{
    [Table("textDay_Ts")]
    public class TextDay_T : BaseT
    {
        public int NumberOfYear { get; set; }
        public DateTime date { get; set; }
        public string Content { get; set; } = null!;
    }
}
