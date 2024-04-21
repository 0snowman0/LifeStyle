using LifeStyle.Dto.Common;

namespace LifeStyle.Dto.Info.TextDay.Quesreis
{
    public class TextDay_D : Base_Dto
    {
        public int NumberOfYear { get; set; }
        public DateTime date { get; set; }
        public string Content { get; set; } = null!;
    }
}
