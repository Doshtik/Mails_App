using System;
using System.Collections.Generic;

namespace MailsApp.Models;

public partial class Mailbox
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public string MailName { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<Letter> LetterIdMailboxRecipientNavigations { get; set; } = new List<Letter>();

    public virtual ICollection<Letter> LetterIdMailboxSenderNavigations { get; set; } = new List<Letter>();
}
