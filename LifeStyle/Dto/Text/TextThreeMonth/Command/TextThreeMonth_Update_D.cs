using LifeStyle.Dto.Common;
using LifeStyle.Dto.Text.TextThreeMonth.common;

namespace LifeStyle.Dto.Text.TextThreeMonth.Command
{
    public class TextThreeMonth_Update_D : Base_Dto , ITextThreeMonth_D
    {
        public int NumberOfYear { get; set; }
        public int NumberOfThreeMonth { get; set; }
        public string Content { get; set; } = null!;
    }
}
