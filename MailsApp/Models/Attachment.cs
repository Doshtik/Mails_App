using System;
using System.Collections.Generic;

namespace MailsApp.Models;

public partial class Attachment
{
    public int Id { get; set; }

    public int IdLetter { get; set; }

    public string FileName { get; set; } = null!;

    public virtual Letter IdLetterNavigation { get; set; } = null!;
}
