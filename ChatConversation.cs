using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20260129
{
    [Table("Chat_Conversation")]
    public class ChatConversation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConversationID { get; set; }
    }
}