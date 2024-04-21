using LifeStyle.Dto.Text.TextThreeMonth.common;

namespace LifeStyle.Dto.Text.TextThreeMonth.Command
{
    public class TextThreeMonth_Create_D : ITextThreeMonth_D
    {
        public int NumberOfYear { get; set; }
        public int NumberOfThreeMonth { get; set; }
        public string Content { get; set; } = null!;
    }
}
