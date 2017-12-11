using System.Collections.Generic;

namespace MyChat.Models.ViewModels
{
    public class MessageViewModel
    {
        public IEnumerable<Message> ChatMessage { get; set; }
        public string Sign { get; set; }
    }
}