using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6.DapperAccessor
{
    /// <summary>
    /// Dapper Generic Service
    /// </summary>
    public class DapperGeneric
    {
        protected UnitOfWork _uw;
        public DapperGeneric(UnitOfWork uw)
        {
            _uw = uw;
        }

        /// <summary>
        /// Метод для получения перво встречающего одного User-а
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        protected async Task<T> FirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null)
        {
            if (transaction == null)
            {
                var connection = new NpgsqlConnection(_uw.GetConnectionString());
                await connection.OpenAsync();
                return await connection.QueryFirstOrDefaultAsync<T>(sql, param);
            }
            else
                return await transaction.Connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
        }


        /// <summary>
        /// Метод для получение всех User-ов
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        protected async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null)
        {
            if (transaction == null)
            {
                using (var connection = new NpgsqlConnection(_uw.GetConnectionString()))
                {
                    connection.Open();
                    return await connection.QueryAsync<T>(sql, param);
                }
            }
            else
                return await transaction.Connection.QueryAsync<T>(sql, param, transaction);
        }
    }
}
