using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        //proprietà di navigazione: un post può essere relativo ad uno ed un solo blog
        public Blog Blog { get; set; }
    }
}
