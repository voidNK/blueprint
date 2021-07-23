using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Enums;
using Blueprint.ToastNotification.Toastify.Models;
using System.Collections.Generic;

namespace Blueprint.ToastNotification.Toastify
{
  public class ToastifyService : IToastifyService, IToastNotificationService
  {
    private readonly IToastNotificationContainer<ToastifyNotification> _container;

    public ToastifyService(
      IToastNotificationContainer<ToastifyNotification> container)
    {
      this._container = container;
    }

    public void Custom(string message, int? durationInSeconds = null, string backgroundColor = "linear-gradient(to right, #00b09b, #96c93d)")
    {
      ToastifyNotification notification = new ToastifyNotification(ToastNotificationType.Custom, message, durationInSeconds);
      notification.BackgroundColor = backgroundColor;
      this._container.Add(notification);
    }

    public void Error(string message, int? durationInSeconds = null) => this._container.Add(new ToastifyNotification(ToastNotificationType.Error, message, durationInSeconds));

    public IEnumerable<ToastifyNotification> GetNotifications() => (IEnumerable<ToastifyNotification>) this._container.GetAll();

    public void Information(string message, int? durationInSeconds = null) => this._container.Add(new ToastifyNotification(ToastNotificationType.Information, message, durationInSeconds));

    public IEnumerable<ToastifyNotification> ReadAllNotifications() => (IEnumerable<ToastifyNotification>) this._container.ReadAll();

    public void RemoveAll() => this._container.RemoveAll();

    public void Success(string message, int? durationInSeconds = null) => this._container.Add(new ToastifyNotification(ToastNotificationType.Success, message, durationInSeconds));

    public void Warning(string message, int? durationInSeconds = null) => this._container.Add(new ToastifyNotification(ToastNotificationType.Warning, message, durationInSeconds));
  }
}
