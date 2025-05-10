using System;
using System.Collections.Generic;

namespace MailsApp.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<Mailbox> Mailboxes { get; set; } = new List<Mailbox>();
}
