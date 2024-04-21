
using LifeStyle.Dto.Common;
using LifeStyle.Dto.Text.TextWeek.common;

namespace LifeStyle.Dto.Text.TextWeek.Command
{
    public class TextWeek_Create_D : Base_Dto , ITextWeek_D
    {
        public int NumberOfYear { get; set; }
        public int numberOfWeek { get; set; }
        public string Content { get; set; } 
    }
}
