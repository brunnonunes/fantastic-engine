using System;

namespace poc.Api.DataContracts {

    public sealed class SignInUserApiResponse : ApiResponseBase
    {
        public string AuthenticationToken { get; set; }

        public int TokenExpirationInMinutes { get; set; }

        public Guid UserKey { get; set; }

        public string Name { get; set; }
    }
}
