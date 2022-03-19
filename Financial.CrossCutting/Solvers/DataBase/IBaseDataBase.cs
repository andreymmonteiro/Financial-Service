using Microsoft.Extensions.DependencyInjection;

namespace Financial.CrossCutting.Solvers.DataBase
{
    public interface IBaseDataBase
    {
        void IncludeDataBase(IServiceCollection service);
    }
}
