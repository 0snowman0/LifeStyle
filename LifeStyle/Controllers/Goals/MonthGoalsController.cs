using AutoMapper;
using AutoMapper.Configuration.Annotations;
using LifeStyle.Dto.Goals.Month.Command;
using LifeStyle.Dto.Goals.Month.Quesreis;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Model.Goals;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Goals
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthGoalsController : ControllerBase
    {
        private readonly IGoalsMonth _goalsMonth;
        private readonly IMapper _mapper;

        public MonthGoalsController(IGoalsMonth goalsMonth, IMapper mapper)
        {
            _goalsMonth = goalsMonth;
            _mapper = mapper;
        }


        [HttpGet("GetAll/GoalMonth")]
        public ActionResult<BaseCommandResponse> GetAll() 
        {
            var responce = new BaseCommandResponse();

            var GoalMonths = _goalsMonth.GetAll();

            if(!GoalMonths.Any())
            {
                responce.NotFound();
                return responce;
            }


            var Map = _mapper.Map<List<GoalsMonth_D>>(GoalMonths);

            responce.Success(Map);
            return Ok(responce);
        }


        [HttpGet("GetOne/GoalsMonth/{Id}")]
        public ActionResult<BaseCommandResponse> Get(int Id) 
        {
            var responce = new BaseCommandResponse();

            var GoalMonth = _goalsMonth.GetById(Id);

            if(GoalMonth == null)
            {
                responce.NotFound();
                return NotFound(responce);
            }


            var Map = _mapper.Map<GoalsMonth_D>(GoalMonth);
            responce.Success(Map);
            return Ok(responce);

        }


        [HttpGet("BetweenMonth/{num1}/{num2}")]
        public ActionResult<BaseCommandResponse> BetweenMonth(int num1 ,  int num2)
        {
            var responce = new BaseCommandResponse();

            var MonthGoal = _goalsMonth.BetweenMonth(num1, num2);

            if(!MonthGoal.Any())
            {
                responce.NotFound();
                return responce;
            }

            var Map = _mapper.Map<List<GoalsMonth_D>>(MonthGoal);

            responce.Success(Map);
            return Ok(responce);
        }


        [HttpPost]
        public ActionResult<BaseCommandResponse> Create(GoalsMonth_Create_D goalsMonth)
        {
            var responce = new BaseCommandResponse();


            var NewGoalMonth = _mapper.Map<GoalsMonth_T>(goalsMonth);

            _goalsMonth.Add(NewGoalMonth);

            responce.Success(NewGoalMonth);
            return Ok(responce);
        }

        [HttpDelete]
        public ActionResult<BaseCommandResponse> Remove(int Id)
        {
            var responce = new BaseCommandResponse();

            var Target = _goalsMonth.GetById(Id);

            _goalsMonth.Remove(Target);

            responce.StatusCode = 204;

            return Ok(responce);
        }

        [HttpPut]
        public ActionResult<BaseCommandResponse> Update(GoalsMonth_Update_D goalsMonth)
        {
            var responce = new BaseCommandResponse();

            var Target = _goalsMonth.GetById(goalsMonth.Id);

            if(Target == null)
            {
                responce.NotFound();
                return Ok(responce);
            }

            _mapper.Map(goalsMonth , Target);

            _goalsMonth.Update(Target);


            responce.StatusCode = 204;
            return Ok(responce);
        }

    }
}
