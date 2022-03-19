using Financial.CrossCutting.Solvers.DataBase;
using Financial.Domain.Models.DataBase;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Financial.CrossCutting.Solvers
{
    public abstract class ConfigureDataBase
    {
        
        protected ConfigureDataBase(IMySqlDataBase _dataBase, DataBaseType type, IServiceCollection services)
        {
            Dictionary<DataBaseType, IBaseDataBase> _db = new Dictionary<DataBaseType, IBaseDataBase>() 
            {
                { DataBaseType.mySql, _dataBase }
            };
            _db[type].IncludeDataBase(services);
        }
    }
}
