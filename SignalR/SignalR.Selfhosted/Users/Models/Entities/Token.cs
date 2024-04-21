﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace SignalR.SelfHosted.Users.Models.Entities;

public class Token
{
    public string RefreshToken { get; set; }

    public int TokenUserId { get; set; }

    public DateTime ExpireAt { get; private set; }

    public bool IsExpired => ExpireAt <= DateTime.UtcNow;

    public void SetDefaultExpiryDate() => ExpireAt = DateTime.UtcNow.AddDays(10);
}

public class TokenConfiguration : IEntityTypeConfiguration<Token>
{
    public void Configure(EntityTypeBuilder<Token> builder)
    {
        builder.HasKey(x => x.RefreshToken);
    }
}