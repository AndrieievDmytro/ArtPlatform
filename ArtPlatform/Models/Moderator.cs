using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class Moderator : User
    {
        public Moderator(int idUser, string nickname, string firstName, string lastName, string bioDesc, string email, string password, DateTime regDate)
        {
            IdUser = idUser;
            Nickname = nickname;
            FirstName = firstName;
            LastName = lastName;
            BioDesc = bioDesc;
            Email = email;
            Password = password;
            RegDate = regDate;
        }

        public override void LogOut()
        {

        }

        public void CreateArtistProfile()
        {

        }

        public void Report(string comment)
        {

        }

        public override void EditProfile(string usernmae, string email, string pasword, string passwordVerficiation)
        {

        }

        public override void DeleteProfile()
        {

        }

        public override void Ban(string reasonDesc)
        {

        }

        public void ChangePassowrd()
        {

        }

        public override void IssueWarning(int idPost, string warningType, string description)
        {

        }

        public User SearchByUsername(string username)
        {
            return null;
        }
    }
}
