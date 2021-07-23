using System.Collections.Generic;
using System.ComponentModel;

namespace Blueprint.ToastNotification.Notyf.Models
{
  public class NotyfEntity
  {
    public NotyfEntity(int durationInSeconds = 5, NotyfPosition toastPosition = NotyfPosition.BottomRight, bool isDismissible = true)
    {
      this.duration = durationInSeconds > 0 ? durationInSeconds * 1000 : 5000;
      this.dismissible = isDismissible;
      this.ripple = true;
      try
      {
        string[] strArray = NotyfEntity.ToDescriptionString(toastPosition).Split('-');
        this.position = new Position()
        {
          x = strArray == null ? "right" : strArray[0],
          y = strArray == null ? "bottom" : strArray[1]
        };
      }
      catch
      {
        this.position = new Position()
        {
          x = "right",
          y = "bottom"
        };
      }
      this.types = new List<Config>()
      {
        new Config() { type = "success", background = "#28a745" },
        new Config() { type = "error", background = "#dc3545" },
        new Config()
        {
          type = "warning",
          background = "orange",
          className = "text-dark",
          icon = new Icon()
          {
            className = "fa fa-warning text-dark",
            tagName = "i"
          }
        },
        new Config()
        {
          type = "info",
          background = "#17a2b8",
          icon = new Icon()
          {
            className = "fa fa-info text-white",
            tagName = "i"
          }
        },
        new Config() { type = "custom", background = "black" }
      };
    }

    public int duration { get; set; }

    public Position position { get; set; }

    public bool dismissible { get; set; } = true;

    public bool ripple { get; set; } = true;

    public List<Config> types { get; set; }

    private static string ToDescriptionString(NotyfPosition val)
    {
      DescriptionAttribute[] customAttributes = (DescriptionAttribute[]) val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), false);
      return customAttributes.Length == 0 ? "right-bottom" : customAttributes[0].Description;
    }
  }
}
