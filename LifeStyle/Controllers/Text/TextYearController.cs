using AutoMapper;
using LifeStyle.Dto.Text.TextYear.Command;
using LifeStyle.Dto.Text.TextYear.Quesreis;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Info;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Text
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextYearController : ControllerBase
    {
        private readonly ITextYear _textYear;
        private readonly IMapper _mapper;

        public TextYearController(ITextYear textYear, IMapper mapper)
        {
            _textYear = textYear;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<BaseCommandResponse> GetAll()
        {
            var response = new BaseCommandResponse();

            var target = _textYear.GetAll();

            if (!target.Any())
            {
                response.NotFound();
                return Ok(response);
            }

            var map = _mapper.Map<List<TextYear_D>>(target);

            response.Success(map);
            return Ok(response);
        }

        [HttpGet("GetTextYear/{Id}")]
        public ActionResult<BaseCommandResponse> Get(int Id)
        {
            var response = new BaseCommandResponse();

            var target = _textYear.GetById(Id);

            if (target == null)
            {
                response.NotFound();
                return Ok(response);
            }

            var map = _mapper.Map<TextYear_D>(target);

            response.Success(map);
            return Ok(response);
        }

        [HttpPost]
        public ActionResult<BaseCommandResponse> Create(TextYear_Create_D textYear)
        {
            var response = new BaseCommandResponse();

            var newTextYear = _mapper.Map<TextYear_T>(textYear);

            _textYear.Add(newTextYear);

            response.Success(newTextYear);
            return Ok(response);
        }

        [HttpDelete]
        public ActionResult<BaseCommandResponse> Delete(int Id)
        {
            var response = new BaseCommandResponse();

            var target = _textYear.GetById(Id);

            if (target == null)
            {
                response.NotFound();
                return Ok(response);
            }

            _textYear.Remove(target);

            response.Success();
            response.StatusCode = 204;
            return Ok(response);
        }

        [HttpPut]
        public ActionResult<BaseCommandResponse> Update(TextYear_Update_D textYear)
        {
            var response = new BaseCommandResponse();

            var target = _textYear.GetById(textYear.Id);

            if (target == null)
            {
                response.NotFound();
                return Ok(response);
            }

            _mapper.Map(textYear, target);

            _textYear.Update(target);

            response.Success();
            response.StatusCode = 204;
            return Ok(response);
        }
    }
}
