using System.Data;

namespace DNT.NorthWind.DataAccess.Interface
{
    public interface IDNTConnectionFactory
    {
        IDbConnection GetConnection { get; }
        void CloseConnection();
    }
}
