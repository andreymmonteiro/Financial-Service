using Financial.CrossCutting.Solvers.DataBase;
using Financial.Domain.Models.DataBase;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Financial.CrossCutting.Solvers
{
    public static class ConfigureDataBase
    {
        public static void IncludeDataBase(this IServiceCollection _services, DataBaseType type, string connetionString)
        {
            Dictionary<DataBaseType, BaseDataBase> _db = new ()
            {
                { DataBaseType.mySql, new MySqlDataBase(connetionString) }
            };

            _db[type].IncludeDataBase(_services);
        }
    }
}
