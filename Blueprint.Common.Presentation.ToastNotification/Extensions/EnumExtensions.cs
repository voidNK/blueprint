using System;
using System.ComponentModel;

namespace Blueprint.ToastNotification.Extensions
{
  public static class EnumExtensions
  {
    public static string ToDescriptionString<T>(this T source) where T : Enum
    {
      DescriptionAttribute[] customAttributes = (DescriptionAttribute[]) source.GetType().GetField(source.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), false);
      return customAttributes != null && customAttributes.Length != 0 ? customAttributes[0].Description : source.ToString();
    }
  }
}
