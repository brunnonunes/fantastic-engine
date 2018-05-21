using System;
using System.Collections.Generic;
using System.Text;
using poc.Core.Entities;
using poc.Core.ServiceContracts;

namespace poc.Core.Interfaces.Services {

    public interface IUserService : IServiceBase<UserEntity> {

        SignInUserResponse SignInUser(SignInUserRequest request);
    }
}
