using LifeStyle.Model.Goals;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace LifeStyle.Model
{
    public class Context_En : DbContext
    {
        public Context_En(DbContextOptions<Context_En> options)
            :base(options) 
        {
            
        }



        public  DbSet<YearGoals_T> yearGoals_Ts { get; set; }
        public  DbSet<GoalsMonth_T> goalsMonth_Ts { get; set; }
        public  DbSet<GoalsWeek_T> goalsWeek_Ts{ get; set; }



    }
}
