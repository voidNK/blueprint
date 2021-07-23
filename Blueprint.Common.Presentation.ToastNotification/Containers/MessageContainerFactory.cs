using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Helpers;
using Microsoft.AspNetCore.Http;

namespace Blueprint.ToastNotification.Containers
{
  internal class MessageContainerFactory : IMessageContainerFactory
  {
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ITempDataService _tempDataWrapper;

    public MessageContainerFactory(
      IHttpContextAccessor httpContextAccessor,
      ITempDataService tempDataWrapper)
    {
      this._httpContextAccessor = httpContextAccessor;
      this._tempDataWrapper = tempDataWrapper;
    }

    public IToastNotificationContainer<TMessage> Create<TMessage>() where TMessage : class => this._httpContextAccessor.HttpContext.Request.IsNotyfAjaxRequest() ? (IToastNotificationContainer<TMessage>) new InMemoryNotificationContainer<TMessage>() : (IToastNotificationContainer<TMessage>) new TempDataToastNotificationContainer<TMessage>(this._tempDataWrapper);
  }
}
