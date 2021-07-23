using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Containers;
using Blueprint.ToastNotification.Middlewares;
using Blueprint.ToastNotification.Notyf;
using Blueprint.ToastNotification.Notyf.Models;
using Blueprint.ToastNotification.Services;
using Blueprint.ToastNotification.Toastify;
using Blueprint.ToastNotification.Toastify.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Blueprint.ToastNotification
{
  public static class ServiceCollectionExtensions
  {
    public static void AddToastify(
      this IServiceCollection services,
      Action<ToastifyConfig> toastifyConfiguration)
    {
      ToastifyConfig toastifyConfig = new ToastifyConfig();
      toastifyConfiguration(toastifyConfig);
      ToastifyEntity implementationInstance = new ToastifyEntity(toastifyConfig.DurationInSeconds, toastifyConfig.Gravity, toastifyConfig.Position);
      if (services == null)
        throw new ArgumentNullException(nameof (services));
      services.AddFrameworkServices();
      services.AddSingleton<ITempDataService, TempDataService>();
      services.AddSingleton<IToastNotificationContainer<ToastifyNotification>, TempDataToastNotificationContainer<ToastifyNotification>>();
      services.AddScoped<IToastifyService, ToastifyService>();
      services.AddSingleton<ToastifyEntity>(implementationInstance);
    }

    private static void AddFrameworkServices(this IServiceCollection services)
    {
      if (services.FirstOrDefault<ServiceDescriptor>((Func<ServiceDescriptor, bool>) (d => d.ServiceType == typeof (ITempDataProvider))) == null)
        services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
      if (services.FirstOrDefault<ServiceDescriptor>((Func<ServiceDescriptor, bool>) (d => d.ServiceType == typeof (IHttpContextAccessor))) != null)
        return;
      services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    }

    public static void AddNotyf(this IServiceCollection services, Action<NotyfConfig> configure)
    {
      NotyfConfig notyfConfig = new NotyfConfig();
      configure(notyfConfig);
      NotyfEntity implementationInstance = new NotyfEntity(notyfConfig.DurationInSeconds, notyfConfig.Position, notyfConfig.IsDismissable);
      if (services == null)
        throw new ArgumentNullException(nameof (services));
      services.AddFrameworkServices();
      services.AddSingleton<ITempDataService, TempDataService>();
      services.AddSingleton<IMessageContainerFactory, MessageContainerFactory>();
      services.AddScoped<INotyfService, NotyfService>();
      services.AddScoped<NotyfMiddleware>();
      services.AddSingleton<NotyfEntity>(implementationInstance);
    }
  }
}
