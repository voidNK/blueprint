using Blueprint.ToastNotification.Extensions;
using System;

namespace Blueprint.ToastNotification.Toastify.Models
{
  public class ToastifyEntity
  {
    public ToastifyEntity(int durationInSeconds, Gravity gravity = Gravity.Bottom, Position position = Position.Right)
    {
      this.duration = new int?(durationInSeconds * 1000);
      this.gravity = gravity.ToDescriptionString<Gravity>();
      this.position = position.ToDescriptionString<Position>();
    }

    public string text { get; set; }

    public int? duration { get; set; }

    public Uri destination { get; set; }

    public bool newWindow { get; set; } = true;

    public bool close { get; set; }

    public string gravity { get; set; } = "bottom";

    public string backgroundColor { get; set; }

    public bool stopOnFocus { get; set; } = true;

    public string position { get; set; } = "right";

    public Uri avatar { get; set; }

    public string className { get; set; }
  }
}
