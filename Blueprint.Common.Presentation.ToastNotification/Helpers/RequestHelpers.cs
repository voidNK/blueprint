using Microsoft.AspNetCore.Http;
using System;

namespace Blueprint.ToastNotification.Helpers
{
  public static class RequestHelpers
  {
    public static bool IsNotyfAjaxRequest(this HttpRequest request)
    {
      if (request == null)
        throw new ArgumentNullException(nameof (request));
      return !string.IsNullOrWhiteSpace((string) request.Headers[Constants.RequestHeaderKey]) || !string.IsNullOrWhiteSpace((string) request.Headers[Constants.RequestHeaderKey.ToLower()]);
    }
  }
}
