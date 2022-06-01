using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6.DapperAccessor
{
    /// <summary>
    /// Модель для получения строка подключение к базе данный 
    /// </summary>
    public class UnitOfWork
    {
        private readonly IConfiguration _configuration;
        public UnitOfWork(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Get Connection String
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            return _configuration.GetSection("PostgreSqlConnection").Value;
        }

    }
}
