using poc.Core.Interfaces.Services;

namespace poc.Core.Services {

    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class { }
}
