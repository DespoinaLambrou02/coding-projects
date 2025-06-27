using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PostTracker.models;

public partial class DbPostsContext : DbContext
{
    public DbPostsContext()
    {
    }

    public DbPostsContext(DbContextOptions<DbPostsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<SocialNetwork> SocialNetworks { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TagsPost> TagsPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=db_posts;user=root;password=;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.IdPost).HasName("PRIMARY");

            entity.ToTable("posts");

            entity.HasIndex(e => e.IdSocialNetwork, "ID_SOCIAL_NETWORK");

            entity.Property(e => e.IdPost)
                .HasColumnType("int(11)")
                .HasColumnName("ID_POST");
            entity.Property(e => e.Clicks)
                .HasColumnType("int(11)")
                .HasColumnName("CLICKS");
            entity.Property(e => e.Comments)
                .HasColumnType("int(11)")
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("DATE");
            entity.Property(e => e.Delivered)
                .HasColumnType("int(11)")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.IdSocialNetwork)
                .HasColumnType("int(11)")
                .HasColumnName("ID_SOCIAL_NETWORK");
            entity.Property(e => e.LastUpdated)
                .HasColumnType("date")
                .HasColumnName("LAST_UPDATED");
            entity.Property(e => e.Likes)
                .HasColumnType("int(11)")
                .HasColumnName("LIKES");
            entity.Property(e => e.Opened)
                .HasColumnType("int(11)")
                .HasColumnName("OPENED");
            entity.Property(e => e.Published)
                .HasColumnType("date")
                .HasColumnName("PUBLISHED");
            entity.Property(e => e.Reach)
                .HasColumnType("int(11)")
                .HasColumnName("REACH");
            entity.Property(e => e.Reactions)
                .HasColumnType("int(11)")
                .HasColumnName("REACTIONS");
            entity.Property(e => e.Saves)
                .HasColumnType("int(11)")
                .HasColumnName("SAVES");
            entity.Property(e => e.Scheduled)
                .HasColumnType("date")
                .HasColumnName("SCHEDULED");
            entity.Property(e => e.Shares)
                .HasColumnType("int(11)")
                .HasColumnName("SHARES");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("TITLE");
            entity.Property(e => e.Unsubscribes)
                .HasColumnType("int(11)")
                .HasColumnName("UNSUBSCRIBES");
            entity.Property(e => e.Views).HasColumnType("int(11)");

            entity.HasOne(d => d.IdSocialNetworkNavigation).WithMany(p => p.Posts)
                .HasForeignKey(d => d.IdSocialNetwork)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("posts_ibfk_1");
        });

        modelBuilder.Entity<SocialNetwork>(entity =>
        {
            entity.HasKey(e => e.IdSocialNtewok).HasName("PRIMARY");

            entity.ToTable("social_networks");

            entity.Property(e => e.IdSocialNtewok)
                .HasColumnType("int(11)")
                .HasColumnName("ID_SOCIAL_NTEWOK");
            entity.Property(e => e.NameSocialNetwork)
                .HasMaxLength(255)
                .HasColumnName("NAME_SOCIAL_NETWORK");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.IdTag).HasName("PRIMARY");

            entity.ToTable("tags");

            entity.Property(e => e.IdTag)
                .HasColumnType("int(11)")
                .HasColumnName("ID_TAG");
            entity.Property(e => e.TitleTag)
                .HasMaxLength(255)
                .HasColumnName("TITLE_TAG");
        });

        modelBuilder.Entity<TagsPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tags_posts");

            entity.HasIndex(e => e.IdPost, "ID_POST");

            entity.HasIndex(e => e.IdTag, "ID_TAG");

            entity.Property(e => e.IdPost)
                .HasColumnType("int(11)")
                .HasColumnName("ID_POST");
            entity.Property(e => e.IdTag)
                .HasColumnType("int(11)")
                .HasColumnName("ID_TAG");

            entity.HasOne(d => d.IdPostNavigation).WithMany()
                .HasForeignKey(d => d.IdPost)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("tags_posts_ibfk_1");

            entity.HasOne(d => d.IdTagNavigation).WithMany()
                .HasForeignKey(d => d.IdTag)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("tags_posts_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
