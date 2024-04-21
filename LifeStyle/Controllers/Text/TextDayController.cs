using AutoMapper;
using AutoMapper.Configuration.Annotations;
using LifeStyle.Dto.Goals.Year.Command;
using LifeStyle.Dto.Info.TextDay.Command;
using LifeStyle.Dto.Info.TextDay.Quesreis;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Info;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Text
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextDayController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITextDay _textDay;

        public TextDayController(IMapper mapper, ITextDay textDay)
        {
            _mapper = mapper;
            _textDay = textDay;
        }



        [HttpGet]
        public ActionResult<BaseCommandResponse> GetAll()
        {
            var responce = new BaseCommandResponse();


            var Target = _textDay.GetAll();


            if(!Target.Any())
            {
                responce.NotFound();
                return Ok(responce);
            }

             var Map= _mapper.Map<List<TextDay_D>>(Target);

            responce.Success(Map);
            return Ok(responce);
        }


        [HttpGet("GetTextDay/{Id}")]
        public ActionResult<BaseCommandResponse> Get(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textDay.GetById(Id);


            if(Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<TextDay_D>(Target);


            responce.Success(Map);
            return Ok(responce);
        }


        [HttpPost]
        public ActionResult<BaseCommandResponse> Create(TextDay_Create_D textDay)
        {
            var responce = new BaseCommandResponse();


            var NewTextDay = new TextDay_T() 
            {
                Content = textDay.Content,
                NumberOfYear = textDay.NumberOfYear
            };
            
            if(textDay.date == "")
            {
                NewTextDay.date = DateTime.Now;
            }
            else
            {
                //convert to miladi
            }

            _textDay.Add(NewTextDay);

            responce.Success(NewTextDay);
            return Ok(responce);
        }


        [HttpDelete]
        public ActionResult<BaseCommandResponse> Delete(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _textDay.GetById(Id);

            if(Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _textDay.Remove(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }


        [HttpPut]
        public ActionResult<BaseCommandResponse> Update(TextDay_Update_D textDay)
        {
            var responce = new BaseCommandResponse();

            var Target = _textDay.GetById(textDay.Id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _mapper.Map(textDay,Target);

            _textDay.Update(Target);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);

        }

    }
}
