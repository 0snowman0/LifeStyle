using AutoMapper;
using LifeStyle.Dto.Text.TextMonth.Command;
using LifeStyle.Dto.Text.TextMonth.Quesreis;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Info;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Text
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextMonthController : ControllerBase
    {
        private readonly ITextMonth _textMonth;
        private readonly IMapper _mapper;
        public TextMonthController(ITextMonth textMonth, IMapper mapper)
        {
            _textMonth = textMonth;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<BaseCommandResponse> GetAll()
        {
            var responce = new BaseCommandResponse();

            var Target = _textMonth.GetAll();

            if (!Target.Any())
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<List<TextMonth_D>>(Target);

            responce.Success(Map);
            return Ok(responce);
        }

        [HttpGet("GetTextMonth/{Id}")]
        public ActionResult<BaseCommandResponse> Get(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textMonth.GetById(Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<TextMonth_D>(Target);

            responce.Success(Map);
            return Ok(responce);
        }


        [HttpPost]
        public ActionResult<BaseCommandResponse> Create(TextMonth_Create_D textMonth)
        {
            var responce = new BaseCommandResponse();

            var NewTextMonth = _mapper.Map<TextMonth_T>(textMonth);

            _textMonth.Add(NewTextMonth);

            responce.Success(NewTextMonth);
            return Ok(responce);
        }

        [HttpDelete]
        public ActionResult<BaseCommandResponse> Delete(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textMonth.GetById(Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _textMonth.Remove(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }


        [HttpPut]
        public ActionResult<BaseCommandResponse> Update(TextMonth_Update_D textMonth)
        {
            var responce = new BaseCommandResponse();

            var Target = _textMonth.GetById(textMonth.Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _mapper.Map(textMonth, Target);

            _textMonth.Update(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }
    }
}
