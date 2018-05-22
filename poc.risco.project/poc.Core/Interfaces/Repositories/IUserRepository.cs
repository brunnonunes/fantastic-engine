using poc.Core.Entities;

namespace poc.Core.Interfaces.Repositories {

    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        bool Add(UserEntity entity);
    }
}
