using System;

namespace poc.Core.Connectors.Gim.DataContracts {

    public sealed class GimAuthenticateRequest {

        public string Email { get; set; }
        public string Password { get; set; }
        public Guid ApplicationKey { get; set; }
        public int TokenExpirationInMinutes { get; set; }
    }
}
