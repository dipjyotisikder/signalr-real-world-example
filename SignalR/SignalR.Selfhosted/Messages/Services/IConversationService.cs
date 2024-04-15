﻿using SignalR.SelfHosted.Messages.Models;
using System.Collections.Generic;

namespace SignalR.SelfHosted.Messages.Services;

public interface IConversationService
{
    IEnumerable<ConversationModel> GetAll();

    IEnumerable<MessageModel> GetMessages(int conversationId);

    IEnumerable<ConversationAudienceModel> GetAudiences(int conversationId);

    Conversation Create(CreateConversationRequest request);
}
