using LifeStyle.Dto.Common;
using LifeStyle.Dto.Text.TextMonth.common;

namespace LifeStyle.Dto.Text.TextMonth.Command
{
    public class TextMonth_Update_D : Base_Dto , ITextMonth_D
    {
        public int NumberOfYear { get; set; }
        public int NumberOfMonth { get; set; }
        public string Content { get; set; } = null!;
    }
}
