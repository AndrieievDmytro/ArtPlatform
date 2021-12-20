using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class User : IncognitoUser
    {
        [Required]
        [Key]
        public int IdUser { get; set; }

        [Required]
        [Key]
        public string Nickname { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BioDesc { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime RegDate { 
            get { return _regDate; }
            set
            {
                if (_regDate < DateTime.Now.AddDays(-1))
                    _regDate = value;
            }
        }

        private DateTime _regDate;

        public List<Report> Reports { get; set; }

        public List<Post> FavoritePosts { get; set; }

        public List<Comment> LeftComments { get; set; }

        public List<UserRating> SetRatings { get; set; }

        public List<ArtWork> BoughtArtWorks { get; set; }

        public User()
        {
        }

        public User(int idUser, string nickname, string firstName, string lastName, string bioDesc, string email, string password, DateTime regDate)
        {
            IdUser = idUser;
            Nickname = nickname;
            FirstName = firstName;
            LastName = lastName;
            BioDesc = bioDesc;
            Email = email;
            Password = password;
            RegDate = regDate;

            Reports = new List<Report>();
            FavoritePosts = new List<Post>();
            LeftComments = new List<Comment>();
            SetRatings = new List<UserRating>();
            BoughtArtWorks = new List<ArtWork>();
        }

        public virtual void LogOut()
        {

        }

        public Artist CreateArtist()
        {
            return new Artist();
        }

        public void Report(Comment comment)
        {
            
        }

        public virtual void EditProfile(string username, string email, string password, string passwordVerification)
        {

        }

        public virtual void DeleteProfile()
        {

        }

        public virtual void Ban(string reasonDesc)
        {

        }

        public void ChangePassword(string password)
        {

        }

        public virtual void IssueWarning(int idPost, string warningType, string description)
        {

        }

        public string searchByUsername(string username)
        {
            return "username";
        }


    }
}
