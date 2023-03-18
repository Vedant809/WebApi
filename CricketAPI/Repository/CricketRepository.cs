using CricketAPI.Repository;
using CricketAPI.Entity;
using Microsoft.Data.SqlClient;
using CricketAPI.Dapper;
using Dapper;

namespace CricketAPI.Repository
{
    public class CricketRepository: ICricketRepository
    {
        private readonly DapperContext _dapperContext;
        public CricketRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<Cricket>> GetCricketPlayerNames()
        {
            var query = "spGetCricketInformation";

            using(var connection=_dapperContext.CreateConnection())
            {
                DynamicParameters objParm = new DynamicParameters();
                var result = connection.Query<Cricket>(query, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

    }
}
