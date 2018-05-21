using System;
using System.Collections.Generic;
using System.Text;

namespace poc.Core.ServiceContracts {

    public sealed class SignInUserRequest {

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
