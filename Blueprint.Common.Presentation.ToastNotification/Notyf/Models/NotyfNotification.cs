﻿using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Enums;

namespace Blueprint.ToastNotification.Notyf.Models
{
  public class NotyfNotification : Notification
  {
    public NotyfNotification(ToastNotificationType type, string message, int? durationInSeconds)
      : base(type, message, durationInSeconds)
    {
    }

    public string Icon { get; set; }
  }
}
