using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Info;
using System.Data;

namespace LifeStyle.Repository.Info
{
    public class TextMonth_Rep : RepositoryBase<TextMonth_T>, ITextMonth
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<TextMonth_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;
        private readonly IConfiguration _configuration;

        public TextMonth_Rep
            (IDbConnection connection, ISqlQueryUtil<TextMonth_T> sqlQueryUtil,
            IGenericRepository genericRepository, IConfiguration configuration)
            : base(sqlQueryUtil, connection)
        {
            _connection = connection;
            _sqlQueryUtil = sqlQueryUtil;
            _genericRepository = genericRepository;
            _configuration = configuration;
        }
    }
}
