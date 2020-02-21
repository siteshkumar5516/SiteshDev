using System;
using System.Collections.Generic;
using System.Text;

namespace Models.GraphModels
{
    public class B2CUserModel
    {
       
        public string displayName { get; set; }
       // public string mailNickName { get; set; }
        public bool accountEnabled { get; set; }
        public string creationType { get; set; }
       public List<SignInNames> signInNames { get; set; }
        public PasswordProfile passwordProfile { get; set; }
        public string passwordPolicies { get; set; }

    }
    public class SignInNames
    {
        public string type { get; set; }
        public string value { get; set; }
    }
    public class PasswordProfile
    {
        public string password { get; set; }
        public bool forceChangePasswordNextLogin { get; set; }
    }
}
