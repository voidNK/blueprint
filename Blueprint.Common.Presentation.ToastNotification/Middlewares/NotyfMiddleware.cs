using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Helpers;
using Blueprint.ToastNotification.Notyf;
using Blueprint.ToastNotification.Notyf.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Blueprint.ToastNotification.Middlewares
{
  internal class NotyfMiddleware : IMiddleware
  {
    private readonly INotyfService _toastNotification;
    private readonly ILogger<NotyfMiddleware> _logger;
    private const string AccessControlExposeHeadersKey = "Access-Control-Expose-Headers";

    public NotyfEntity _options { get; }

    public NotyfMiddleware(
      INotyfService toastNotification,
      ILogger<NotyfMiddleware> logger,
      NotyfEntity options)
    {
      this._toastNotification = toastNotification;
      this._logger = logger;
      this._options = options;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
      NotyfMiddleware notyfMiddleware = this;
      context.Response.OnStarting(new Func<object, Task>(notyfMiddleware.Callback), (object) context);
      await next(context);
    }

    private Task Callback(object context)
    {
      HttpContext httpContext = (HttpContext) context;
      if (httpContext.Request.IsNotyfAjaxRequest())
      {
        NotyfViewModel notyfViewModel = new NotyfViewModel()
        {
          Configuration = this._options.ToJson(),
          Notifications = this._toastNotification.ReadAllNotifications()
        };
        if (notyfViewModel.Notifications != null && notyfViewModel.Notifications.Any<NotyfNotification>())
        {
          string str = string.Format("{0}", this.GetControlExposeHeaders(httpContext.Response.Headers));
          httpContext.Response.Headers.Add("Access-Control-Expose-Headers", (StringValues) str);
          string json = notyfViewModel.Notifications.ToJson();
          httpContext.Response.Headers.Add(Constants.NotyfResponseHeaderKey, (StringValues) WebUtility.UrlEncode(json));
        }
      }
      return (Task) Task.FromResult<int>(0);
    }

    private object GetControlExposeHeaders(IHeaderDictionary headers)
    {
      StringValues header = headers["Access-Control-Expose-Headers"];
      return string.IsNullOrEmpty((string) header) ? (object) Constants.NotyfResponseHeaderKey : (object) string.Format("{0}, {1}", (object) header, (object) Constants.NotyfResponseHeaderKey);
    }
  }
}
