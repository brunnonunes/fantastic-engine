using System;
using System.Collections.Generic;
using System.Text;

namespace poc.Core.Entities {
    public sealed class UserEntity {

        public UserEntity() { }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}
