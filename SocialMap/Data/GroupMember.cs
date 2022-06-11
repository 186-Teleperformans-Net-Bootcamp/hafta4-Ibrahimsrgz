namespace SocialMap.Data
{
    public class GroupMember
    {
        public int Id { get; set; }
        public Group GroupId { get; set; }

        public User UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }


    }
}
