using Dapper;
using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Model;
using LifeStyle.Model.Goals;
using System;
using System.Data;

namespace LifeStyle.Repository.Goals
{
    public class GoalsMonth_Rep : RepositoryBase<GoalsMonth_T>, IGoalsMonth
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<GoalsMonth_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;
        public GoalsMonth_Rep
            (IDbConnection connection,
            ISqlQueryUtil<GoalsMonth_T> sqlQueryUtil,
            IGenericRepository genericRepository)
            : base(sqlQueryUtil, connection)
        {
            _connection = connection;
            _sqlQueryUtil = sqlQueryUtil;
            _genericRepository = genericRepository;
        }

        public List<GoalsMonth_T> BetweenMonth(int num1, int num2)
        {
            var paramters = new DynamicParameters();
            paramters.Add("@NUM1", num1);
            paramters.Add("@NUM2", num2);

            var results = _genericRepository.Single<List<GoalsMonth_T>>("BetweenMonth", paramters);
            return results;
        }

    }
}
