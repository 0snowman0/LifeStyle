using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Goals;
using LifeStyle.Model.Info;
using System.Data;

namespace LifeStyle.Repository.Info
{
    public class TextDay_Rep : RepositoryBase<TextDay_T>, ITextDay
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<TextDay_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;
        private readonly IConfiguration _configuration;

        public TextDay_Rep
            (IDbConnection connection, ISqlQueryUtil<TextDay_T> sqlQueryUtil, 
            IGenericRepository genericRepository, IConfiguration configuration)
            :base(sqlQueryUtil, connection)
        {
            _connection = connection;
            _sqlQueryUtil = sqlQueryUtil;
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

        public TextDay_T Get_By_Date(DateOnly date)
        {
            throw new NotImplementedException();
        }
    }
}
