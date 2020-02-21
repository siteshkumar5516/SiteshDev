using GraphApi;
using Models.GraphModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Managers
{
    public class B2CUserManager
    {
        private B2CGraphClient _graphClient;
        public B2CUserManager(B2CGraphClient graphClient)
        {
            this._graphClient = graphClient;
        }
        public async Task<bool> Create(B2CUserModel user)
        {

            var uc = new B2CUserModel
            {
                accountEnabled = true
            };
            List<SignInNames> names = new List<SignInNames>();
            SignInNames name=new SignInNames
            {
                type="emailAddress",
                value="sargam.srivastava88@gmail.com"
            };
            names.Add(name);
            uc.signInNames = names;
            uc.creationType = "LocalAccount";
            uc.displayName = user.displayName;
            uc.passwordProfile = new PasswordProfile
            {
                password = user.passwordProfile.password,
                forceChangePasswordNextLogin=false
            };
            uc.passwordPolicies = "DisablePasswordExpiration";

            var userString = JsonConvert.SerializeObject(uc);
            await this._graphClient.CreateUser(userString);
            return true;
        }
    }
}
