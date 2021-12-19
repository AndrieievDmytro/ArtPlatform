using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public abstract class IncognitoUser
    {
        public void Login(string username, string password)
        {

        }

        public User CreateUserProfile(string username, string email, string password, string passwordVerification)
        {
            return new User();
        }
    }
}
