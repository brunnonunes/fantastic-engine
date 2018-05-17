using System;
using System.Collections.Generic;
using System.Text;
using poc.Core.Entities;
using poc.Core.Interfaces.Repositories;

namespace poc.Infra.Repositories {

    public sealed class UserRepository : RepositoryBase<UserEntity>, IUserRepository {


    }
}
