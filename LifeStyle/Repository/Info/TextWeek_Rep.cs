using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Goals;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Goals;
using LifeStyle.Model.Info;
using System.Data;

namespace LifeStyle.Repository.Info
{
    public class TextWeek_Rep : RepositoryBase<TextWeek_T>, ITextWeek
    {
        private readonly IDbConnection _connection;
        ISqlQueryUtil<TextWeek_T> _sqlQueryUtil;
        private readonly IGenericRepository _genericRepository;
        private readonly IConfiguration _configuration;

        public TextWeek_Rep
            (IDbConnection connection, ISqlQueryUtil<TextWeek_T> sqlQueryUtil,
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
