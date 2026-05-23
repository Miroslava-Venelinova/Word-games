using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp.Models;

public partial class DbwordGamesContext : DbContext
{
    public DbwordGamesContext()
    {
    }

    public DbwordGamesContext(DbContextOptions<DbwordGamesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<WordsHangman> WordsHangmen { get; set; }

    public virtual DbSet<WordsWordl> WordsWordls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DBWordGames; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admins__43AA4141F4444E82");

            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.AdminPassword)
                .HasMaxLength(20)
                .HasColumnName("admin_password");
            entity.Property(e => e.AdminUsername)
                .HasMaxLength(20)
                .HasColumnName("admin_username");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__Players__44DA120C0F50BAD7");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.PlayerHangmanWins).HasColumnName("player_hangman_wins");
            entity.Property(e => e.PlayerPassword)
                .HasMaxLength(20)
                .HasColumnName("player_password");
            entity.Property(e => e.PlayerTotalGames).HasColumnName("player_totalGames");
            entity.Property(e => e.PlayerUsername)
                .HasMaxLength(20)
                .HasColumnName("player_username");
            entity.Property(e => e.PlayerWordlWins).HasColumnName("player_wordl_wins");
        });

        modelBuilder.Entity<WordsHangman>(entity =>
        {
            entity.HasKey(e => e.WordId).HasName("PK__WordsHan__7FFA1D4019A55221");

            entity.ToTable("WordsHangman");

            entity.Property(e => e.WordId).HasColumnName("word_id");
            entity.Property(e => e.Word)
                .HasMaxLength(100)
                .HasColumnName("word");
            entity.Property(e => e.WordLevel)
                .HasMaxLength(10)
                .HasColumnName("word_level");
        });

        modelBuilder.Entity<WordsWordl>(entity =>
        {
            entity.HasKey(e => e.WordId).HasName("PK__WordsWor__7FFA1D408AE6B2EF");

            entity.ToTable("WordsWordl");

            entity.Property(e => e.WordId).HasColumnName("word_id");
            entity.Property(e => e.Word)
                .HasMaxLength(10)
                .HasColumnName("word");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
