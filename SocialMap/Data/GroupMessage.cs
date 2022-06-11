namespace SocialMap.Data
{
    public class GroupMessage
    {
        public int Id { get; set; }
        public Group GroupId { get; set; }
        public User UserId { get; set; }

        public String Message { get; set; }

        public String Type { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
