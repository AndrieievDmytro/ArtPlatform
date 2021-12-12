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
        [Required]
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BioDesc { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime RegDate { get; set; }

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

        public void LogOut()
        {

        }

        public void CreateArtistProfile()
        {

        }

        public void Report(string comment)
        {

        }

        public void EditProfile(string usernmae, string email, string pasword, string passwordVerficiation)
        {

        }

        public void DeleteProfile()
        {

        }

        public void Ban(string reasonDesc)
        {

        }

        public void ChangePassowrd()
        {

        }

        public void IssueWarning(int idPost, string warningType, string description)
        {

        }

        public User SearchByUsername(string username)
        {
            return null;
        }
    }
}
