using Microsoft.Extensions.Options;
using poc.Core.ConfigurationSettings;
using poc.Core.Connectors.Gim;
using poc.Core.Connectors.Gim.DataContracts;
using poc.Core.Entities;
using poc.Core.Interfaces.Repositories;
using poc.Core.Interfaces.Services;
using poc.Core.ServiceContracts;

namespace poc.Core.Services {

    public sealed class UserService : ServiceBase<UserEntity>, IUserService {

        private readonly IUserRepository _userRepository;

        private readonly IOptions<GimSettings> _gimSettings;

        public UserService(IUserRepository userRepository, IOptions<GimSettings> gimSettings) : base(userRepository) {
            this._userRepository = userRepository;
            this._gimSettings = gimSettings;
        }

        public SignInUserResponse SignInUser(SignInUserRequest request) {

            //var x = this._userRepository;

            //var y = this._repository;

            SignInUserResponse response = new SignInUserResponse();

            GimAuthenticateRequest gimAuthenticateRequest = new GimAuthenticateRequest {
                Email = request.Login,
                Password = request.Password,
                ApplicationKey = this._gimSettings.Value.ApplicationKey,
                TokenExpirationInMinutes = this._gimSettings.Value.TokenExpirationInMinutes
            };

            // Autenticação realizada pelo GIM.
            GimAuthenticateResponse gimAuthenticateResponse = new GimConnector(this._gimSettings).Authenticate(gimAuthenticateRequest);

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
