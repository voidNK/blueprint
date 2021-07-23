using Blueprint.ToastNotification.Abstractions;
using Blueprint.ToastNotification.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Blueprint.ToastNotification.Services
{
  public class TempDataService : ITempDataService
  {
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly JsonSerializerSettings _serializerSettings;
    private readonly ITempDataDictionaryFactory _tempDataDictionaryFactory;

    public TempDataService(
      ITempDataDictionaryFactory tempDataDictionaryFactory,
      IHttpContextAccessor httpContextAccessor)
    {
      this._tempDataDictionaryFactory = tempDataDictionaryFactory;
      this._httpContextAccessor = httpContextAccessor;
      this._serializerSettings = this.GetSerializerSettings();
    }

    private JsonSerializerSettings GetSerializerSettings() => new JsonSerializerSettings()
    {
      TypeNameHandling = (TypeNameHandling) 4
    };

    private ITempDataDictionary TempData => this._tempDataDictionaryFactory.GetTempData(this._httpContextAccessor.HttpContext);

    public T Get<T>(string key) where T : class => this.TempData.ContainsKey(key) && this.TempData[key] is string str ? JsonConvert.DeserializeObject<T>(str) : default (T);

    public T Peek<T>(string key) where T : class => this.TempData.ContainsKey(key) && this.TempData.Peek(key) is string str ? JsonConvert.DeserializeObject<T>(str) : default (T);

    public void Add(string key, object value) => this.TempData[key] = (object) value.ToJson();

    public bool Remove(string key) => this.TempData.ContainsKey(key) && ((IDictionary<string, object>) this.TempData).Remove(key);
  }
}
