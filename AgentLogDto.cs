namespace _20260129
{
    public class AgentLogDto
    {
        public int ConversationID { get; set; } = 1;
        public string UserText { get; set; } = "";
        public string AssistantText { get; set; } = "";
        public string? Intent { get; set; }
    }
}
