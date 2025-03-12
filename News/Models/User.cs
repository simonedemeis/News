using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //proprietà di navigazione: un utente può appartenere a molti blog
        public ICollection<Blog> Blogs { get; set; }
    }
}
