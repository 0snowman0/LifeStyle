using LifeStyle.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyle.Model.Info
{
    [Table("textYear_Ts")]
    public class TextYear_T : BaseT
    {
        public int NumberOfYear { get; set; }
        public string Content { get; set; } = null!;
    }
}
