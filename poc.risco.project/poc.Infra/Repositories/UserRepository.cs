using System;
using poc.Core.Entities;
using poc.Core.Interfaces.Repositories;

namespace poc.Infra.Repositories {

    public sealed class UserRepository : RepositoryBase<UserEntity>, IUserRepository {

        public bool Add(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
