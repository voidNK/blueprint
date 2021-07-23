using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Enums;

namespace Blueprint.ToastNotification.Toastify.Models
{
  public class ToastifyNotification : Notification
  {
    public ToastifyNotification(ToastNotificationType type, string message, int? durationInSeconds)
      : base(type, message, durationInSeconds)
    {
    }
  }
}
