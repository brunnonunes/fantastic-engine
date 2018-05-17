using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace poc.Risco.Api.Models
{
    public class SignInModel
    {
        public string Login { get; set; }
        
        public string Password { get; set; }
    }
}
