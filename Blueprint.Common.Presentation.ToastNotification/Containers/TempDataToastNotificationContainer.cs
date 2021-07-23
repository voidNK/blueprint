using Blueprint.ToastNotification.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Blueprint.ToastNotification.Containers
{
  public class TempDataToastNotificationContainer<TMessage> : IToastNotificationContainer<TMessage>
    where TMessage : class
  {
    private readonly ITempDataService _tempDataWrapper;
    private const string Key = "Blueprint.ToastNotification";

    public TempDataToastNotificationContainer(ITempDataService tempDataWrapper) => this._tempDataWrapper = tempDataWrapper;

    public void Add(TMessage message)
    {
      List<TMessage> list = (this._tempDataWrapper.Get<IEnumerable<TMessage>>("Blueprint.ToastNotification") ?? (IEnumerable<TMessage>) new List<TMessage>()).ToList<TMessage>();
      list.Add(message);
      this._tempDataWrapper.Add("Blueprint.ToastNotification", (object) list);
    }

    public void RemoveAll() => this._tempDataWrapper.Remove("Blueprint.ToastNotification");

    public IList<TMessage> GetAll() => (IList<TMessage>) this._tempDataWrapper.Peek<List<TMessage>>("Blueprint.ToastNotification") ?? (IList<TMessage>) new List<TMessage>();

    public IList<TMessage> ReadAll()
    {
      IList<TMessage> all = this.GetAll();
      this.RemoveAll();
      return all;
    }
  }
}
