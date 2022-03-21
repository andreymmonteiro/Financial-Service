using Financial.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Financial.CrossCutting.Solvers.DataBase
{
    public abstract class BaseDataBase
    {
        public virtual void IncludeDataBase(IServiceCollection service) 
        {
            service.AddDbContext<MyContext>();
        }
    }
}
