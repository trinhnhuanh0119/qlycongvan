using System.Data;

namespace DataAccess.Repositories
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
