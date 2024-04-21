using AutoMapper;
using LifeStyle.Dto.Text.TextWeek.Command;
using LifeStyle.Dto.Text.TextWeek.Quesreis;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Info;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Text
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextWeekController : ControllerBase
    {
        private readonly ITextWeek _textWeek;
        private readonly IMapper _mapper;
        public TextWeekController(ITextWeek textWeek, IMapper mapper)
        {
            _textWeek = textWeek;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<BaseCommandResponse> GetAll()
        {
            var responce = new BaseCommandResponse();

            var Target = _textWeek.GetAll();

            if (!Target.Any())
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<List<TextWeek_D>>(Target);

            responce.Success(Map);
            return Ok(responce);
        }

   
        [HttpGet("GetTextWeek/{Id}")]
        public ActionResult<BaseCommandResponse> Get(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textWeek.GetById(Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<TextWeek_D>(Target);

            responce.Success(Map);
            return Ok(responce);
        }


        [HttpPost]
        public ActionResult<BaseCommandResponse> Create(TextWeek_Create_D textWeek)
        {
            var responce = new BaseCommandResponse();

            var NewTextWeek = _mapper.Map<TextWeek_T>(textWeek);

            _textWeek.Add(NewTextWeek);

            responce.Success(NewTextWeek);
            return Ok(responce);
        }

        [HttpDelete]
        public ActionResult<BaseCommandResponse> Delete(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textWeek.GetById(Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _textWeek.Remove(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }

       
        [HttpPut]
        public ActionResult<BaseCommandResponse> Update(TextWeek_Update_D textWeek)
        {
            var responce = new BaseCommandResponse();

            var Target = _textWeek.GetById(textWeek.Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _mapper.Map(textWeek, Target);

            _textWeek.Update(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }
    }
}
