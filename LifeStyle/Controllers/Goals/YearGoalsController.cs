using AutoMapper;
using AutoMapper.Configuration.Annotations;
using LifeStyle.Dto.Goals.Year.Command;
using LifeStyle.Dto.Goals.Year.Quesreis;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Model.Goals;
using LifeStyle.Responce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace LifeStyle.Controllers.Goals
{
    [Route("api/[controller]")]
    [ApiController]
    public class YearGoalsController : ControllerBase
    {
        private readonly IYearGoals _yearGoals;
        private readonly IMapper _mapper;
        private readonly IGenericRepository genericRepository;
        public YearGoalsController(IYearGoals yearGoals, IMapper mapper, IGenericRepository genericRepository)
        {
            _yearGoals = yearGoals;
            _mapper = mapper;
            this.genericRepository = genericRepository;
        }



        [HttpGet]
        public ActionResult<BaseCommandResponse> GetAll()
        {
            var Responce = new BaseCommandResponse();

            var YearGoals = _yearGoals.GetAll();

            if(!YearGoals.Any())
            {
                Responce.NotFound();
                return Ok(Responce);
            }

            var Map = _mapper.Map<List<YearGoals_D>>(YearGoals);


            Responce.Success(Map);
          
            return Ok(Responce);
        }


        [HttpGet("GetOne/{id}")]
        public ActionResult<BaseCommandResponse> Get(int id)
        {
            var Responce = new BaseCommandResponse();

            var GoalYaer = _yearGoals.GetById(id);

            if (GoalYaer == null)
            {
                Responce.NotFound();
                Responce.Message = $"not found goalYears with numberOfYears {id}.";
                return Ok(Responce);
            }

            var Map = _mapper.Map<YearGoals_D>(GoalYaer);

            Responce.Success(Map);

            return Ok(Responce);
        }

        [HttpGet("GetOne/Years/{NumberOfDay}")]
        public ActionResult<BaseCommandResponse> Get_WithNumberOfYear(int NumberOfDay)
        {
            var Responce = new BaseCommandResponse();

            var GoalYaer = _yearGoals.Get_WithNumberOfYear(NumberOfDay);

            if (GoalYaer == null)
            {
                Responce.NotFound();
                Responce.Message = $"not found goalYears with numberOfYears {NumberOfDay}.";
                return Ok(Responce);
            }

            var Map = _mapper.Map<YearGoals_D>(GoalYaer);

            Responce.Success(Map);

            return Ok(Responce);
        }



        [HttpPost]
        public async Task<ActionResult> Post(YearGoals_Create_D goals_Create_Dto) 
        {
            var responce = new BaseCommandResponse();


            //validation


            var NewGoalYaer = _mapper.Map<YearGoals_T>(goals_Create_Dto);


            _yearGoals.Add(NewGoalYaer);

            responce.Success(NewGoalYaer);

            return Ok(responce);
        }


        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            var Target = _yearGoals.GetById(Id);
            _yearGoals.Remove(Target);
            return NoContent();
        }


        [HttpPut]
        public ActionResult Update(YearGoals_Update_D yearGoals_Update)
        {

            var Target = _yearGoals.GetById(8);

            _mapper.Map(yearGoals_Update , Target);

            _yearGoals.Update(Target);
            return NoContent();
        }

    }
}
