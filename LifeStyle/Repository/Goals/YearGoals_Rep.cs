using Dapper;
using LifeStyle.generic;
using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Model;
using LifeStyle.Model.Goals;
using System;
using System.Data;

namespace LifeStyle.Repository.Goals
{
    public class YearGoals_Rep : RepositoryBase<YearGoals_T>, IYearGoals
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<YearGoals_T> _sqlQueryUtil;
        private readonly Context_En _context_En;
        private readonly IGenericRepository _genericRepository;
        public YearGoals_Rep(IDbConnection connection, ISqlQueryUtil<YearGoals_T> sqlQueryUtil, Context_En context_En, IGenericRepository genericRepository)
            : base(sqlQueryUtil, connection)
        {
            _connection = connection;
            _sqlQueryUtil = sqlQueryUtil;
            _context_En = context_En;
            _genericRepository = genericRepository;
        }

        public YearGoals_T Get_WithNumberOfYear(int num)
        {
            var paramters = new DynamicParameters();
            paramters.Add("@NumberOfYears", num);

            var results =  _genericRepository.Single<YearGoals_T>("GetYearGoalsWithNumberOfYears", paramters);
            return results;

        }
    }
}

