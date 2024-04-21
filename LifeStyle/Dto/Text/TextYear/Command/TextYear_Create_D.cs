using LifeStyle.Dto.Text.TextYear.common;

namespace LifeStyle.Dto.Text.TextYear.Command
{
    public class TextYear_Create_D : ITextYear_D
    {
        public int NumberOfYear { get; set; }
        public string Content { get; set; } = null!;
    }
}
