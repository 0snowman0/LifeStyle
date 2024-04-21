using LifeStyle.Dto.Common;

namespace LifeStyle.Dto.Text.TextMonth.Quesreis
{
    public class TextMonth_D : Base_Dto
    {
        public int NumberOfYear { get; set; }
        public int NumberOfMonth { get; set; }
        public string Content { get; set; } = null!;
    }
}
