namespace Woods.Models{
    public class Message : BaseEntity {

        public long Id { get; set; }
        public string Content { get; set; }
        //public Player player { get; set; }

        public string PlayerName { get; set; }
    }
}