using LifeStyle.Dto.Info.TextDay.common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyle.Dto.Info.TextDay.Command
{
    public class TextDay_Create_D : ITextDay_D
    {
        public int NumberOfYear { get; set; }
        public string date { get; set; }
        public string Content { get; set; } = null!;
    }
}
