﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalR.Api.Data.SqLite;

#nullable disable

namespace SignalR.SelfHosted.Data.SqLite.Migrations
{
    [DbContext(typeof(SqLiteDataContext))]
    [Migration("20240423160844_RemovedOnlineProperty")]
    partial class RemovedOnlineProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.29");

            modelBuilder.Entity("SignalR.SelfHosted.Messages.Models.Entities.Conversation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("SignalR.SelfHosted.Messages.Models.Entities.ConversationAudience", b =>
                {
                    b.Property<int>("ConversationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AudienceUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConversationId", "AudienceUserId");

                    b.ToTable("ConversationAudiences");
                });

            modelBuilder.Entity("SignalR.SelfHosted.Messages.Models.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConversationId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SignalR.SelfHosted.Messages.Models.Entities.MessageAudience", b =>
                {
                    b.Property<int>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AudienceUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Seen")
                        .HasColumnType("INTEGER");

                    b.HasKey("MessageId", "AudienceUserId");

                    b.ToTable("MessageAudiences");
                });

            modelBuilder.Entity("SignalR.SelfHosted.Users.Models.Entities.Token", b =>
                {
                    b.Property<string>("RefreshToken")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("TokenUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RefreshToken");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("SignalR.SelfHosted.Users.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullNameNormalized")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
