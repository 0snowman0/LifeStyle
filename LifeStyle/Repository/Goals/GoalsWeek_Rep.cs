using AutoMapper.Configuration.Annotations;
using Dapper;
using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Model.Goals;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LifeStyle.Repository.Goals
{
    public class GoalsWeek_Rep : RepositoryBase<GoalsWeek_T>, IGoalsWeek
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<GoalsWeek_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;
        private readonly IConfiguration _configuration;

        public GoalsWeek_Rep
            (IDbConnection connection,
            ISqlQueryUtil<GoalsWeek_T> sqlQueryUtil,
            IGenericRepository genericRepository,
            IConfiguration configuration)
            : base(sqlQueryUtil, connection)
        {
            _connection = connection;
            _sqlQueryUtil = sqlQueryUtil;
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

        public List<GoalsWeek_T?> BetweenWeek(int num1, int num2)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            var paramters = new DynamicParameters();
            paramters.Add("@NUM1", num1);
            paramters.Add("@NUM2", num2);

            var results = connection.Query<GoalsWeek_T>("BetweenWeek", paramters).ToList();
            return results;
        }


    }
}
