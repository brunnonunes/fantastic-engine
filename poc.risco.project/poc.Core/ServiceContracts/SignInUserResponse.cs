using System;

namespace poc.Core.ServiceContracts {

    public sealed class SignInUserResponse : ResponseBase {

        public string AuthenticationToken { get; set; }

        public int TokenExpirationInMinutes { get; set; }

        public Guid UserKey { get; set; }

        public string Name { get; set; }
    }
}
