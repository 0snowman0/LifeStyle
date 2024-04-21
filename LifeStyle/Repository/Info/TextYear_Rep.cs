using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Info;
using System.Data;

namespace LifeStyle.Repository.Info
{
    public class TextYear_Rep : RepositoryBase<TextYear_T>, ITextYear
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<TextYear_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;
        private readonly IConfiguration _configuration;

        public TextYear_Rep
            (IDbConnection connection, ISqlQueryUtil<TextYear_T> sqlQueryUtil,
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
