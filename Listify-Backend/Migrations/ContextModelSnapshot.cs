﻿// <auto-generated />
using System;
using Listify_Backend.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Listify_Backend.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Listify_Backend.DataModels.Playlist", b =>
                {
                    b.Property<int>("PlaylistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlayListIconString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaylistCode")
                        .HasColumnType("int");

                    b.Property<string>("PlaylistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaylistTagsString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlaylistID");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Listify_Backend.DataModels.Songs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlaylistID")
                        .HasColumnType("int");

                    b.Property<string>("SongArtist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SongGenre")
                        .HasColumnType("int");

                    b.Property<int>("SongLocationInPlaylist")
                        .HasColumnType("int");

                    b.Property<string>("SongTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PlaylistID");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("Listify_Backend.DataModels.Songs", b =>
                {
                    b.HasOne("Listify_Backend.DataModels.Playlist", null)
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("PlaylistID");
                });

            modelBuilder.Entity("Listify_Backend.DataModels.Playlist", b =>
                {
                    b.Navigation("PlaylistSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
