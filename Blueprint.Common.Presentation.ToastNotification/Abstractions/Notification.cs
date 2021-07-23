using Blueprint.ToastNotification.Enums;

namespace Blueprint.ToastNotification.Abstractions
{
  public class Notification
  {
    public Notification(ToastNotificationType type, string message, int? durationInSeconds)
    {
      this.Message = message;
      this.Type = type;
      int? nullable1;
      int? nullable2;
      if (durationInSeconds.HasValue)
      {
        nullable1 = durationInSeconds;
        int num = 0;
        if (!(nullable1.GetValueOrDefault() == num & nullable1.HasValue))
        {
          nullable1 = durationInSeconds;
          nullable2 = nullable1.HasValue ? new int?(nullable1.GetValueOrDefault() * 1000) : new int?();
          goto label_4;
        }
      }
      nullable1 = new int?();
      nullable2 = nullable1;
label_4:
      this.Duration = nullable2;
    }

    public string Message { get; set; }

    public string BackgroundColor { get; set; }

    public ToastNotificationType Type { get; set; }

    public int? Duration { get; set; }
  }
}
