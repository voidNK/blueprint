using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Toastify;
using Blueprint.ToastNotification.Toastify.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blueprint.ToastNotification.Views.Shared.Components.Toastify
{
  [ViewComponent(Name = "Toastify")]
  public class ToastifyViewComponent : ViewComponent
  {
    private readonly IToastifyService _service;

    public ToastifyViewComponent(IToastifyService service, ToastifyEntity options)
    {
      this._service = service;
      this._options = options;
    }

    public ToastifyEntity _options { get; }

    public IViewComponentResult Invoke() => (IViewComponentResult) this.View<ToastifyViewModel>("Default", new ToastifyViewModel()
    {
      Configuration = this._options,
      Notifications = this._service.ReadAllNotifications()
    });
  }
}
