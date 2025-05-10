using System;
using System.Collections.Generic;

namespace MailsApp.Models;

public partial class Letter
{
    public int Id { get; set; }

    public int IdStatus { get; set; }

    public int IdMailboxSender { get; set; }

    public int IdMailboxRecipient { get; set; }

    public string? Theme { get; set; }

    public string Message { get; set; } = null!;

    public DateTime Date { get; set; }

    public bool IsFavorite { get; set; }

    public int? IdLetter { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual Letter? IdLetterNavigation { get; set; }

    public virtual Mailbox IdMailboxRecipientNavigation { get; set; } = null!;

    public virtual Mailbox IdMailboxSenderNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<Letter> InverseIdLetterNavigation { get; set; } = new List<Letter>();
}
