using System;
using System.Collections.Generic;
using System.Text;
using poc.Core.Entities;
using poc.Core.Interfaces.Repositories;
using poc.Core.Interfaces.Services;

namespace poc.Core.Services {

    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class {

        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository) {
             
            this._repository = repository;
        }

        //public bool Add(UserEntity entity) {
        //    throw new NotImplementedException();
        //}

        //public UserEntity GetById(int id) {
        //    throw new NotImplementedException();
        //}

        //public List<UserEntity> GetAll() {
        //    throw new NotImplementedException();
        //}

        //public bool Update(UserEntity entity) {
        //    throw new NotImplementedException();
        //}

        //public bool Remove(int id) {
        //    throw new NotImplementedException();
        //}
    }
}
