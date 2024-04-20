using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Model.Goals;
using System.Data;

namespace LifeStyle.Repository.Goals
{
    public class GoalsWeek_Rep : RepositoryBase<GoalsWeek_T>, IGoalsWeek
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<GoalsWeek_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;


        public GoalsWeek_Rep
            (IDbConnection connection,
            ISqlQueryUtil<GoalsWeek_T> sqlQueryUtil,
            IGenericRepository genericRepository)
            : base(sqlQueryUtil, connection)
        {
            _connection = connection;
            _sqlQueryUtil = sqlQueryUtil;
            _genericRepository = genericRepository;
        }
    }
}
