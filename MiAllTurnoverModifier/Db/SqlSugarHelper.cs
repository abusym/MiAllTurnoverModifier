using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MiAllTurnoverModifier.Db
{
    public class SqlSugarHelper
    {
        public static SqlSugarScope Db = new SqlSugarScope(new ConnectionConfig()
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            },
            db => { db.Aop.OnLogExecuting = (sql, pars) => { Console.WriteLine(sql); }; });
    }
}