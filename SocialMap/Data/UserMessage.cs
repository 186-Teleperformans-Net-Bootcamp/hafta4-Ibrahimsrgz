using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMap.Data
{
    public class UserMessage
    {
        public int Id { get; set; }

      //  [ForeignKey("Id")]
        public User SourceId { get; set; }

        [ForeignKey("Id")]
        public User TargetId { get; set; }

        public String? Message { get; set; }
        public String? Type { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
