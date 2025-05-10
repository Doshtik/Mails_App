using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MailsApp.Models;

public partial class AppContext : DbContext
{
    public AppContext() { }

    public AppContext(DbContextOptions<AppContext> options) : base(options) { }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<Letter> Letters { get; set; }

    public virtual DbSet<Mailbox> Mailboxes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mails_app;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("included_files_pkey");

            entity.ToTable("attachments");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('attached_files_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.FileName).HasColumnName("file_name");
            entity.Property(e => e.IdLetter).HasColumnName("id_letter");

            entity.HasOne(d => d.IdLetterNavigation).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.IdLetter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_files_letters");
        });

        modelBuilder.Entity<Letter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mails_pkey");

            entity.ToTable("letters");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('mails_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdLetter).HasColumnName("id_letter");
            entity.Property(e => e.IdMailboxRecipient).HasColumnName("id_mailbox_recipient");
            entity.Property(e => e.IdMailboxSender).HasColumnName("id_mailbox_sender");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IsFavorite)
                .HasDefaultValue(false)
                .HasColumnName("is_favorite");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Theme).HasColumnName("theme");

            entity.HasOne(d => d.IdLetterNavigation).WithMany(p => p.InverseIdLetterNavigation)
                .HasForeignKey(d => d.IdLetter)
                .HasConstraintName("fk_letters_letters");

            entity.HasOne(d => d.IdMailboxRecipientNavigation).WithMany(p => p.LetterIdMailboxRecipientNavigations)
                .HasForeignKey(d => d.IdMailboxRecipient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mailbox_recipient_users");

            entity.HasOne(d => d.IdMailboxSenderNavigation).WithMany(p => p.LetterIdMailboxSenderNavigations)
                .HasForeignKey(d => d.IdMailboxSender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mailbox_sender_users");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Letters)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_letters_statuses");
        });

        modelBuilder.Entity<Mailbox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_boxes_pkey");

            entity.ToTable("mailboxes");

            entity.HasIndex(e => e.MailName, "mail_boxes_mail_name_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('mail_boxes_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.MailName).HasColumnName("mail_name");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Mailboxes)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mail_boxes_users");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firstname).HasColumnName("firstname");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Lastname).HasColumnName("lastname");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
