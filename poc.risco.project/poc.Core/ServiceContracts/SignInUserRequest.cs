namespace poc.Core.ServiceContracts {

    public sealed class SignInUserRequest {

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
