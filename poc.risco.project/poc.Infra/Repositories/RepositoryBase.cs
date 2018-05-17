using System;
using System.Collections.Generic;
using System.Text;
using poc.Core.Interfaces.Repositories;

namespace poc.Infra.Repositories {

    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class { }
}
