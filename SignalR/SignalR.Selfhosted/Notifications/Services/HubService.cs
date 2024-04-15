﻿using Microsoft.AspNetCore.SignalR;
using SignalR.SelfHosted.Notifications.Services;
using System.Threading.Tasks;

namespace SignalR.SelfHosted.Notification.Services;

public class HubService : IHubService
{
    private readonly IHubContext<ApplicationHub> _hubContext;

    public HubService(IHubContext<ApplicationHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public Task SendToAllAsync<T>(HubEventName eventName, T payload)
    {
        return _hubContext.Clients.All.SendAsync(eventName.Value, payload);
    }

    public Task SendToGroupsAsync<T>(string[] groups, HubEventName eventName, T payload)
    {
        return _hubContext.Clients.Groups(groups).SendAsync(eventName.Value, payload);
    }
}
