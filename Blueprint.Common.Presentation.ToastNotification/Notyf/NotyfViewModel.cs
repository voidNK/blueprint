using Blueprint.ToastNotification.Notyf.Models;
using System.Collections.Generic;

namespace Blueprint.ToastNotification.Notyf
{
  public class NotyfViewModel
  {
    public string Configuration { get; set; }

    public IEnumerable<NotyfNotification> Notifications { get; set; }
  }
}
