// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Extensions.OpenAI.Models;

namespace Microsoft.Azure.WebJobs.Extensions.OpenAI.Agents;

[Binding]
[AttributeUsage(AttributeTargets.Parameter)]
public class ChatBotQueryAttribute : Attribute
{
    public ChatBotQueryAttribute(string id)
    {
        this.Id = id;
    }

    /// <summary>
    /// Gets the ID of the chat bot to query.
    /// </summary>
    [AutoResolve]
    public string Id { get; }

    /// <summary>
    /// Gets or sets the timestamp of the earliest message in the chat history to fetch.
    /// The timestamp should be in ISO 8601 format - for example, 2023-08-01T00:00:00Z.
    /// </summary>
    [AutoResolve]
    public string TimestampUtc { get; set; } = string.Empty;
}

public record ChatBotState(
    string Id,
    bool Exists,
    ChatBotStatus Status,
    DateTime CreatedAt,
    DateTime LastUpdatedAt,
    int TotalMessages,
    int Usage,
    IReadOnlyList<ChatMessageEntity> RecentMessages);