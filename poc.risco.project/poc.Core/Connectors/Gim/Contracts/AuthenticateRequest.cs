using System;
using System.Collections.Generic;
using System.Text;

namespace poc.Core.Connectors.Gim.Contracts {

    public sealed class AuthenticateRequest {

        public string Email { get; set; }
        public string Password { get; set; }
        public Guid ApplicationKey { get; set; }
        public int TokenExpirationInMinutes { get; set; }
    }
}
