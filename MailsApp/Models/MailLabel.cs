using System;
using System.Collections.Generic;

namespace MailsApp.Models;

public partial class MailLabel
{
    public int Id { get; set; }

    public string LabelName { get; set; } = null!;

    public virtual ICollection<Letter> Letters { get; set; } = new List<Letter>();
}
