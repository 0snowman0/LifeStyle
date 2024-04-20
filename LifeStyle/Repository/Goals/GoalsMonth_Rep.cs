using Dapper;
using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Model;
using LifeStyle.Model.Goals;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LifeStyle.Repository.Goals
{
    public class GoalsMonth_Rep : RepositoryBase<GoalsMonth_T>, IGoalsMonth
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<GoalsMonth_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;
        private readonly IConfiguration _configuration;
        public GoalsMonth_Rep
            (IDbConnection connection,
            ISqlQueryUtil<GoalsMonth_T> sqlQueryUtil,
            IGenericRepository genericRepository,
            IConfiguration configuration)
            : base(sqlQueryUtil, connection)
        {
            _connection = connection;
            _sqlQueryUtil = sqlQueryUtil;
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

        public List<GoalsMonth_T> BetweenMonth(int num1, int num2)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            var paramters = new DynamicParameters();
            paramters.Add("@NUM1", num1);
            paramters.Add("@NUM2", num2);

            var results = connection.Query<GoalsMonth_T>("BetweenMonth", paramters).ToList();
            return results;
        }


        

    }
}
