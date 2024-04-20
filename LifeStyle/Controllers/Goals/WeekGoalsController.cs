using AutoMapper;
using AutoMapper.Configuration.Annotations;
using LifeStyle.Dto.Goals.Week.Command;
using LifeStyle.Dto.Goals.Week.Quesreis;
using LifeStyle.Interface.Goals;
using LifeStyle.Model.Goals;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Goals
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeekGoalsController : ControllerBase
    {
        private readonly IGoalsWeek _goalsWeek;
        private readonly IMapper _mapper;

        public WeekGoalsController
            (
            IGoalsWeek goalsWeek
            , IMapper mapper
            )
        {
            _goalsWeek = goalsWeek;
            _mapper = mapper;
        }


        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var responce = new BaseCommandResponse();

            var GoalsWeek = _goalsWeek.GetAll();

            if(!GoalsWeek.Any())
            {
                responce.NotFound();
                return Ok(responce);
            }

            var Map = _mapper.Map<List<GoalsWeek_D>>(GoalsWeek);

            responce.Success(Map);
            return Ok(responce);
        }



        [HttpGet("GetGoalsWeek/{id}")]
        public ActionResult Get(int id)
        {
            var responce = new BaseCommandResponse();

            var Target = _goalsWeek.GetById(id);

            if(Target == null)
            {
                responce.NotFound();
                return Ok(responce);    
            }


            var Map = _mapper.Map<GoalsWeek_D>(Target);


            responce.Success(Map);
            return Ok(responce);
        }


        [HttpGet("GetBetween/{num1}/{num2}")]
        public ActionResult GetBetween(int num1 , int num2)
        {
            var responce = new BaseCommandResponse();

           var Target =_goalsWeek.BetweenWeek(num1 , num2);

 
            if(!Target.Any())
            {
                responce.NotFound();
                return Ok(responce);
            }


            var Map = _mapper.Map<List<GoalsWeek_D>>(Target);

            responce.Success(Map);
            return Ok(responce);

        }

        [HttpPost]
        public ActionResult Create(GoalsWeek_Create_D goalsWeek)
        {
            var responce = new BaseCommandResponse();

            var NewGoals = _mapper.Map<GoalsWeek_T>(goalsWeek);

            _goalsWeek.Add(NewGoals);
            responce.Success(NewGoals);
            return Ok(responce);
        }

        
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var responce = new BaseCommandResponse();


            var Target = _goalsWeek.GetById(id);

            if (Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }


            _goalsWeek.Remove(Target);

            responce.StatusCode = 204;

            return Ok(responce);
        }

        
        
        [HttpPut]
        public ActionResult Update(GoalsWeek_Update_D goalsWeek)
        {
            var responce = new BaseCommandResponse();


            var Traget = _goalsWeek.GetById(goalsWeek.Id);


            if (Traget == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _mapper.Map(goalsWeek,Traget);

            _goalsWeek.Update(Traget);

            responce.Success();
            responce.StatusCode = 204;
            return Ok(responce);
        }

    }
}
