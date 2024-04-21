using AutoMapper;
using LifeStyle.Dto.Text.TextThreeMonth.Command;
using LifeStyle.Dto.Text.TextThreeMonth.Quesreis;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Info;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Text
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextThreeMonthController : ControllerBase
    {
        private readonly ITextThreeMonth _textThreeMonth;
        private readonly IMapper _mapper;

        public TextThreeMonthController(ITextThreeMonth textThreeMonth, IMapper mapper)
        {
            _textThreeMonth = textThreeMonth;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<BaseCommandResponse> GetAll()
        {
            var responce = new BaseCommandResponse();

            var Target = _textThreeMonth.GetAll();

            if (!Target.Any())
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<List<TextThreeMonth_D>>(Target);

            responce.Success(Map);
            return Ok(responce);
        }

        [HttpGet("GetTextThreeMonth/{Id}")]
        public ActionResult<BaseCommandResponse> Get(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textThreeMonth.GetById(Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<TextThreeMonth_D>(Target);

            responce.Success(Map);
            return Ok(responce);
        }


        [HttpPost]
        public ActionResult<BaseCommandResponse> Create(TextThreeMonth_Create_D textThreeMonth)
        {
            var responce = new BaseCommandResponse();

            var NewTextThreeMonth = _mapper.Map<TextThreeMonth_T>(textThreeMonth);

            _textThreeMonth.Add(NewTextThreeMonth);

            responce.Success(NewTextThreeMonth);
            return Ok(responce);
        }

        [HttpDelete]
        public ActionResult<BaseCommandResponse> Delete(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textThreeMonth.GetById(Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _textThreeMonth.Remove(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }


        [HttpPut]
        public ActionResult<BaseCommandResponse> Update(TextThreeMonth_Update_D textThreeMonth)
        {
            var responce = new BaseCommandResponse();

            var Target = _textThreeMonth.GetById(textThreeMonth.Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _mapper.Map(textThreeMonth, Target);

            _textThreeMonth.Update(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }
    }
}
