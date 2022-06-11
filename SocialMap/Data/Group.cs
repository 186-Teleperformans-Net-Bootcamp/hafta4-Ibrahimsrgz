namespace SocialMap.Data
{
    public class Group
    {
        public int Id { get; set; }
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }

        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
