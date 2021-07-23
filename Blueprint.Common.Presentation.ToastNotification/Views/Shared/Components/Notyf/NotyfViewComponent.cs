using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Helpers;
using Blueprint.ToastNotification.Notyf;
using Blueprint.ToastNotification.Notyf.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blueprint.ToastNotification.Views.Shared.Components.Notyf
{
  [ViewComponent(Name = "Notyf")]
  public class NotyfViewComponent : ViewComponent
  {
    private readonly INotyfService _service;

    public NotyfViewComponent(INotyfService service, NotyfEntity options)
    {
      this._service = service;
      this._options = options;
    }

    public NotyfEntity _options { get; }

    public IViewComponentResult Invoke() => (IViewComponentResult) this.View<NotyfViewModel>("Default", new NotyfViewModel()
    {
      Configuration = this._options.ToJson(),
      Notifications = this._service.ReadAllNotifications()
    });
  }
}
