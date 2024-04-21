using LifeStyle.Interface.Calculate;
using MD.PersianDateTime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeStyle.Controllers.Calculate
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly ICalculate _calculate;

        public CalculateController(ICalculate calculate)
        {
            _calculate = calculate;
        }
      
        
        [HttpGet("Calculate/AllTime")]
        public ActionResult AllTime()
        {
            PersianDateTime startDate = new PersianDateTime(1403, 1, 2);

            int numberOfDays = _calculate.NumberOfDay(startDate);
            int numberOfWeeks = _calculate.NumberOfWeek(startDate);
            int numberOfMonths = _calculate.NumberOfMonth(startDate);
            int numberOfThreeMonths = _calculate.NumberOfThreeMonth(startDate);
            int numberOfYears = _calculate.NumberOfYear(startDate);

            // Create a dictionary to store the calculated values
            Dictionary<string, int> timePeriod = new Dictionary<string, int>()
    {
        {"Hour",numberOfDays * 24 },
        { "Days", numberOfDays },
        { "Weeks", numberOfWeeks },
        { "Months", numberOfMonths },
        { "ThreeMonths", numberOfThreeMonths },
        { "Years", numberOfYears }
    };

            return Ok(timePeriod); // Return the dictionary
        }




        #region Comment
        //
        //[HttpGet("Calculate/NumberOfDay")]
        //public ActionResult NumberOfDay()
        //{
        //    PersianDateTime StartDate = new PersianDateTime(1403, 1, 2);

        //    int NumberOfDay = _calculate.NumberOfDay(StartDate);

        //    return Ok(NumberOfDay);
        //}



        //[HttpGet("Calculate/NumberOfWeek")]
        //public ActionResult NumberOfWeek()
        //{
        //    PersianDateTime StartDate = new PersianDateTime(1403, 1, 2);
        //    int NumberOfWeek = _calculate.NumberOfWeek(StartDate);
        //    return Ok(NumberOfWeek);
        //}


        //[HttpGet("Calculate/NumberOfMonth")]
        //public ActionResult NumberOfMonth()
        //{
        //    PersianDateTime StartDate = new PersianDateTime(1403, 1, 2);
        //    int NumberOfMonth = _calculate.NumberOfMonth(StartDate);
        //    return Ok(NumberOfMonth);
        //}


        //[HttpGet("Calculate/NumberOfThreeMonth")]
        //public ActionResult NumberOfThreeMonth()
        //{
        //    PersianDateTime StartDate = new PersianDateTime(1403, 1, 2);
        //    int NumberOfThreeMonth = _calculate.NumberOfThreeMonth(StartDate);
        //    return Ok(NumberOfThreeMonth);
        //}


        //[HttpGet("Calculate/NumberOfYear")]
        //public ActionResult NumberOfThreeYear()
        //{
        //    PersianDateTime StartDate = new PersianDateTime(1403, 1, 2);
        //    int NumberOfYear = _calculate.NumberOfYear(StartDate);
        //    return Ok(NumberOfYear);
        //}
        //
        #endregion





    }
}
