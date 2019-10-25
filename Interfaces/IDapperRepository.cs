using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace Wickers.Data.Dapper.Interfaces
{
    public interface IDapperRepository
    {
        string ConnectionString { set; }
        Task<T> QuerySingle<T>(string ProcedureName, DynamicParameters Parameters = null);
        Task<IEnumerable<T>> QueryData<T>(string ProcedureName, DynamicParameters Parameters = null);
        Task<int> ExecuteProc(string ProcedureName, DynamicParameters Parameters);
        Task<T> ExecuteScalarProc<T>(string ProcedureName, DynamicParameters Parameters);
    }
}