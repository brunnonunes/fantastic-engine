using System.ComponentModel.DataAnnotations;

namespace poc.Api.Models {

    public class SignInModel {

        [MinLength(3)]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
