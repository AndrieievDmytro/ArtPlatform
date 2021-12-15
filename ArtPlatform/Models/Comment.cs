using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class Comment
    {
        [Required]
        [Key]
        public int IdComment { get; set; }
        [Required]
        public string CommentText { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }
        public List<Comment> SubComments{ get; set; }
        public Comment FatherComment { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Post Post { get; set; }

        public Comment(int IdComment)
        {

        }

        public Comment(int idComment, string commentText, DateTime creationDate, Comment fatherComment, User user, Post post) : this(idComment)
        {
            CommentText = commentText;
            CreationDate = creationDate;
            FatherComment = fatherComment;
            User = user;
            Post = post;
        }

        public void EditComment(string text)
        {

        }
        
        public void EditComment(Comment comment)
        {

        }

        public static void DeleteComment(Post post, Comment comment)
        {

        }
    }
}
