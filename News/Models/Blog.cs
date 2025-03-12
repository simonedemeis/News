using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Uri SiteUri { get; set; }

        //proprietà di navigazione: un blog può avere molti post
        public ICollection<Post> Posts { get; set; }

        //proprietà di navigazione: un blog può avere molti utenti 
        public ICollection<User> Users { get; set; }
    }
}
