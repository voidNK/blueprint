using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Containers;
using Blueprint.ToastNotification.Enums;
using Blueprint.ToastNotification.Notyf.Models;
using System.Collections.Generic;

namespace Blueprint.ToastNotification.Notyf
{
  public class NotyfService : INotyfService
  {
    protected IToastNotificationContainer<NotyfNotification> MessageContainer;

    public NotyfService(IMessageContainerFactory messageContainerFactory) => this.MessageContainer = messageContainerFactory.Create<NotyfNotification>();

    public void Custom(
      string message,
      int? durationInSeconds = null,
      string backgroundColor = "black",
      string iconClassName = "home")
    {
      NotyfNotification notification = new NotyfNotification(ToastNotificationType.Custom, message, durationInSeconds);
      notification.Icon = iconClassName;
      notification.BackgroundColor = backgroundColor;
      this.MessageContainer.Add(notification);
    }

    public void Error(string message, int? durationInSeconds = null) => this.MessageContainer.Add(new NotyfNotification(ToastNotificationType.Error, message, durationInSeconds));

    public IEnumerable<NotyfNotification> GetNotifications() => (IEnumerable<NotyfNotification>) this.MessageContainer.GetAll();

    public void Information(string message, int? durationInSeconds = null) => this.MessageContainer.Add(new NotyfNotification(ToastNotificationType.Information, message, durationInSeconds));

    public IEnumerable<NotyfNotification> ReadAllNotifications() => (IEnumerable<NotyfNotification>) this.MessageContainer.ReadAll();

    public void RemoveAll() => this.MessageContainer.RemoveAll();

    public void Success(string message, int? durationInSeconds = null) => this.MessageContainer.Add(new NotyfNotification(ToastNotificationType.Success, message, durationInSeconds));

    public void Warning(string message, int? durationInSeconds = null) => this.MessageContainer.Add(new NotyfNotification(ToastNotificationType.Warning, message, durationInSeconds));
  }
}
