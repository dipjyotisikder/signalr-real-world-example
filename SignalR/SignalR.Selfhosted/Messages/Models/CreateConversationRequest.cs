﻿namespace SignalR.SelfHosted.Messages.Models
{
    public class CreateConversationRequest
    {
        public string Title { get; set; }

        public int CreatorUserId { get; set; }
    }
}
