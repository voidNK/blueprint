using Blueprint.ToastNotification.Abstractions;
using System.Collections.Generic;

namespace Blueprint.ToastNotification.Containers
{
  public class InMemoryNotificationContainer<TMessage> : IToastNotificationContainer<TMessage>
    where TMessage : class
  {
    private IList<TMessage> Messages { get; }

    public InMemoryNotificationContainer() => this.Messages = (IList<TMessage>) new List<TMessage>();

    public void Add(TMessage message) => this.Messages.Add(message);

    public void RemoveAll() => this.Messages.Clear();

    public IList<TMessage> GetAll() => this.Messages;

    public IList<TMessage> ReadAll()
    {
      List<TMessage> messageList = new List<TMessage>((IEnumerable<TMessage>) this.Messages);
      this.Messages.Clear();
      return (IList<TMessage>) messageList;
    }
  }
}
