using System;
using poc.Core.Connectors.Gim;
using poc.Core.Connectors.Gim.DataContracts;
using poc.Core.Entities;
using poc.Core.Interfaces.Repositories;
using poc.Core.Interfaces.Services;
using poc.Core.ServiceContracts;

namespace poc.Core.Services {

    public sealed class UserService : ServiceBase<UserEntity>, IUserService {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository) {

            this._userRepository = userRepository;
        }

        public SignInUserResponse SignInUser(SignInUserRequest request) {

            SignInUserResponse response = new SignInUserResponse();

            GimAuthenticateRequest gimAuthenticateRequest = new GimAuthenticateRequest {
                Email = request.Login,
                Password = request.Password,
                ApplicationKey = new Guid("e632c04b-a1d7-4faa-bf34-1764bec84607"), // TODO: Passar para appsettings.
                TokenExpirationInMinutes = 720 // TODO: Passar para appsettings.
            };

            // Autenticação realizada pelo GIM.

            GimAuthenticateResponse gimAuthenticateResponse = new GimConnector().Authenticate(gimAuthenticateRequest);

            if (gimAuthenticateResponse.Success == false) {

                foreach (GimReport report in gimAuthenticateResponse.OperationReport) {
                    response.OperationReport.Add(new Report { Field = report.Field, Message = report.Message });
                }

                response.StatusCode = gimAuthenticateResponse.StatusCode;
                return response;
            }

            response.AuthenticationToken = gimAuthenticateResponse.AuthenticationToken;
            response.TokenExpirationInMinutes = gimAuthenticateResponse.TokenExpirationInMinutes;
            response.UserKey = gimAuthenticateResponse.UserKey;
            response.Name = gimAuthenticateResponse.Name;
            response.Success = gimAuthenticateResponse.Success;
            response.StatusCode = gimAuthenticateResponse.StatusCode;
            return response;
        }
    }
}
