using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20260129
{
    [Table("Chat_Message")]
    public class ChatMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MessageID { get; set; }

        [Required]
        public int ConversationID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Role { get; set; } = string.Empty;

        [Required]
        public string MessageText { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Intent { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

