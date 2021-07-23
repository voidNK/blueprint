using Blueprint.ToastNotification.Abstractions;

namespace Blueprint.ToastNotification.Containers
{
  public interface IMessageContainerFactory
  {
    IToastNotificationContainer<TMessage> Create<TMessage>() where TMessage : class;
  }
}
