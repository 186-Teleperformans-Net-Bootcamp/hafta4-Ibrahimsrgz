using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMap.Data
{
    public class Group
    {
        public int Id { get; set; }

        [ForeignKey("Id")]
        public User? CreatedBy { get; set; }

       // [ForeignKey("Id")]
      //  public User? UpdatedBy { get; set; }

        public string? Title { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
