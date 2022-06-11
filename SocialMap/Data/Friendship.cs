using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMap.Data
{
    public class Friendship
    {
        public int Id { get; set; }

        public string? Status { get; set; }

        public User? SourceId { get; set; }

        [ForeignKey("Id")]
        public User TargetId { get; set; }




    }
}
