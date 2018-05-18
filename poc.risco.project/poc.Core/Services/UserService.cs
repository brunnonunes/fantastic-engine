using poc.Core.Entities;
using poc.Core.Interfaces.Repositories;
using poc.Core.Interfaces.Services;

namespace poc.Core.Services {

    public sealed class UserService : ServiceBase<UserEntity>, IUserService {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository) {
            this._userRepository = userRepository;
        }
    }
}
