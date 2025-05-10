using System;
using System.Collections.Generic;

namespace MailsApp.Models;

public partial class Status
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Letter> Letters { get; set; } = new List<Letter>();
}
