using System;
using System.Collections.Generic;

namespace MailsApp.Models;

/// <summary>
/// id_copy_recipient - нужно для того, чтобы у пользователя была независимая копия письма, которую тот может добавлять в избранное или удалять.
/// </summary>
public partial class Letter
{
    #region Поля
    public int Id { get; set; }

    public int IdStatus { get; set; }

    public int IdMailboxSender { get; set; }

    public int IdMailboxRecipient { get; set; }

    public string? Theme { get; set; }

    public string Message { get; set; } = null!;

    public DateTime Date { get; set; }

    public bool IsFavorite { get; set; }

    public int? IdLetter { get; set; }

    public int? IdLabel { get; set; }

    public int IdCopyRecipient { get; set; }

    public bool IsRead { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
    #endregion

    #region Связи
    public virtual MailLabel? IdLabelNavigation { get; set; }

    public virtual Letter? IdLetterNavigation { get; set; }

    public virtual Mailbox IdMailboxRecipientNavigation { get; set; } = null!;

    public virtual Mailbox IdMailboxSenderNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<Letter> InverseIdLetterNavigation { get; set; } = new List<Letter>();
    #endregion

    #region Конструкторы
    public Letter() { }
    public Letter(int idStatus, int idSender, int idRecipient, 
        int idRecipientCopy, string message, DateTime dateTime, string? theme = null, 
        int? idLetterResponce = null, int? idLabel = null, 
        bool isFavorite = false, bool isRead = false)
    {
        IdStatus = idStatus;
        IdMailboxSender = idSender;
        IdMailboxRecipient = idRecipient;
        IdCopyRecipient = idRecipientCopy;
        Theme = theme;
        Message = message;
        Date = dateTime;
        IdLetter = idLetterResponce;
        IsFavorite = isFavorite;
        IsRead = isRead;
        IdLabel = idLabel;
    }
    #endregion
}
