using LifeStyle.Model.Goals;
using LifeStyle.Model.Info;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace LifeStyle.Model.Connection
{
    public class Context_En : DbContext
    {
        public Context_En(DbContextOptions<Context_En> options)
            : base(options)
        {

        }



        public DbSet<YearGoals_T> yearGoals_Ts { get; set; }
        public DbSet<GoalsMonth_T> goalsMonth_Ts { get; set; }
        public DbSet<GoalsWeek_T> goalsWeek_Ts { get; set; }



        public DbSet<TextDay_T> textDay_Ts { get; set; }
        public DbSet<TextWeek_T> textWeek_Ts { get; set; }
        public DbSet<TextMonth_T> textMonth_Ts { get; set; }
        public DbSet<TextThreeMonth_T> textThreeMonth_Ts { get; set; }
        public DbSet<TextYear_T> textYear_Ts { get; set; }


    }
}
