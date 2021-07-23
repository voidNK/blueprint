using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Blueprint.ToastNotification.Helpers
{
  public static class JsonSerialization
  {
    public static JsonSerializerSettings JsonSerializerSettings => new JsonSerializerSettings()
    {
      ContractResolver = (IContractResolver) new CamelCasePropertyNamesContractResolver(),
      NullValueHandling = (NullValueHandling) 1
    };

    public static string ToJson(this object obj) => JsonConvert.SerializeObject(obj, JsonSerialization.JsonSerializerSettings);
  }
}
