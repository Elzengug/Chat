namespace MyChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
       
    }
}