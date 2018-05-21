using System.ComponentModel.DataAnnotations;

namespace poc.Api.Models {

    public class SignInModel {

        [Required]
        [EmailAddress]
        public string Login { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
