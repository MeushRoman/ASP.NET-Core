using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Abstracts;

namespace WebApplication4.Entities
{
    public class ConnectionMSSQL : IConnection
    {
        public string GetConnection()
        {
            return "MSSQL Connection";
        }
    }
    public class ConnectionOracleSql : IConnection
    {
        public string GetConnection()
        {
            return "Oracle Connection";
        }
    }

    public class ConnectionPostgreSql : IConnection
    {
        public string GetConnection()
        {
            return "PostGreSql Connection";
        }
    }
}
