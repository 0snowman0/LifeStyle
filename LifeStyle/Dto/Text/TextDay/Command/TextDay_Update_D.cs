using LifeStyle.Dto.Common;
using LifeStyle.Dto.Info.TextDay.common;

namespace LifeStyle.Dto.Info.TextDay.Command
{
    public class TextDay_Update_D : Base_Dto , ITextDay_D
    {
        public int NumberOfYear { get; set; }
        public string date { get; set; }
        public string Content { get; set; } = null!;
    }
}
