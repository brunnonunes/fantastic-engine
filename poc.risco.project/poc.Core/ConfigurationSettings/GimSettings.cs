using System;

namespace poc.Core.ConfigurationSettings {

    public sealed class GimSettings {

        public string ProductionDomain { get; set; }

        public string AuthenticateEndpoint { get; set; }

        public Guid ApplicationKey { get; set; }

        public int TokenExpirationInMinutes { get; set; }
    }
}
