﻿// <auto-generated />
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    partial class MessageBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("Date");

                    b.Property<string>("Subject");

                    b.Property<string>("User");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Body = "egg",
                            Date = "01/01/01",
                            Subject = "Music",
                            User = "eggLover69"
                        },
                        new
                        {
                            MessageId = 2,
                            Body = "egg",
                            Date = "10/23/97",
                            Subject = "Memes",
                            User = "doug"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
