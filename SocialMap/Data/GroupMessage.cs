using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMap.Data
{
    public class GroupMessage
    {
        public int Id { get; set; }

        [ForeignKey("Id")]
        public Group Group { get; set; }

        [ForeignKey("Id")]
        public User User { get; set; }

        public String? Message { get; set; }

        public String? Type { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
