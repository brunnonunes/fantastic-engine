using System;

namespace poc.Core.Connectors.Gim.DataContracts {

    public sealed class GimAuthenticateResponse : GimResponseBase{

        public string AuthenticationToken { get; set; }

        public int TokenExpirationInMinutes { get; set; }

        public Guid UserKey { get; set; }

        public string Name { get; set; }
    }
}
