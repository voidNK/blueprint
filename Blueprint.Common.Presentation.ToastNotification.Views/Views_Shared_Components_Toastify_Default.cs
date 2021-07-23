using Blueprint.ToastNotification.Enums;
using Blueprint.ToastNotification.Helpers;
using Blueprint.ToastNotification.Toastify;
using Blueprint.ToastNotification.Toastify.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AspNetCore
{
  [RazorSourceChecksum("SHA1", "cf5e7ed449c5fc5788381c9d94a27537cbc0fa36", "/Views/Shared/Components/Toastify/Default.cshtml")]
  public class Views_Shared_Components_Toastify_Default : RazorPage<ToastifyViewModel>
  {
    private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("rel", (object) new HtmlString("stylesheet"), HtmlAttributeValueStyle.DoubleQuotes);
    private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("href", (object) new HtmlString("~/_content/Blueprint.ToastNotification/toastify.css"), HtmlAttributeValueStyle.DoubleQuotes);
    private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("src", (object) new HtmlString("~/_content/Blueprint.ToastNotification/toastify.js"), HtmlAttributeValueStyle.DoubleQuotes);
    private TagHelperExecutionContext __tagHelperExecutionContext;
    private TagHelperRunner __tagHelperRunner = new TagHelperRunner();
    private string __tagHelperStringValueBuffer;
    private TagHelperScopeManager __backed__tagHelperScopeManager;
    private UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;

    private TagHelperScopeManager __tagHelperScopeManager
    {
      get
      {
        if (this.__backed__tagHelperScopeManager == null)
          this.__backed__tagHelperScopeManager = new TagHelperScopeManager(new Action<HtmlEncoder>(((RazorPageBase) this).StartTagHelperWritingScope), new Func<TagHelperContent>(((RazorPageBase) this).EndTagHelperWritingScope));
        return this.__backed__tagHelperScopeManager;
      }
    }

    public override async Task ExecuteAsync()
    {
      Views_Shared_Components_Toastify_Default componentsToastifyDefault = this;
      componentsToastifyDefault.__tagHelperExecutionContext = componentsToastifyDefault.__tagHelperScopeManager.Begin("link", TagMode.StartTagOnly, "cf5e7ed449c5fc5788381c9d94a27537cbc0fa364411", (Func<Task>) (async () => { }));
      componentsToastifyDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = componentsToastifyDefault.CreateTagHelper<UrlResolutionTagHelper>();
      componentsToastifyDefault.__tagHelperExecutionContext.Add((ITagHelper) componentsToastifyDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
      componentsToastifyDefault.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared_Components_Toastify_Default.__tagHelperAttribute_0);
      componentsToastifyDefault.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared_Components_Toastify_Default.__tagHelperAttribute_1);
      await componentsToastifyDefault.__tagHelperRunner.RunAsync(componentsToastifyDefault.__tagHelperExecutionContext);
      if (!componentsToastifyDefault.__tagHelperExecutionContext.Output.IsContentModified)
        await componentsToastifyDefault.__tagHelperExecutionContext.SetOutputContentAsync();
      componentsToastifyDefault.Write((object) componentsToastifyDefault.__tagHelperExecutionContext.Output);
      componentsToastifyDefault.__tagHelperExecutionContext = componentsToastifyDefault.__tagHelperScopeManager.End();
      componentsToastifyDefault.WriteLiteral("\r\n");
      componentsToastifyDefault.__tagHelperExecutionContext = componentsToastifyDefault.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "cf5e7ed449c5fc5788381c9d94a27537cbc0fa365526", (Func<Task>) (async () => { }));
      componentsToastifyDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = componentsToastifyDefault.CreateTagHelper<UrlResolutionTagHelper>();
      componentsToastifyDefault.__tagHelperExecutionContext.Add((ITagHelper) componentsToastifyDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
      componentsToastifyDefault.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared_Components_Toastify_Default.__tagHelperAttribute_2);
      await componentsToastifyDefault.__tagHelperRunner.RunAsync(componentsToastifyDefault.__tagHelperExecutionContext);
      if (!componentsToastifyDefault.__tagHelperExecutionContext.Output.IsContentModified)
        await componentsToastifyDefault.__tagHelperExecutionContext.SetOutputContentAsync();
      componentsToastifyDefault.Write((object) componentsToastifyDefault.__tagHelperExecutionContext.Output);
      componentsToastifyDefault.__tagHelperExecutionContext = componentsToastifyDefault.__tagHelperScopeManager.End();
      componentsToastifyDefault.WriteLiteral("\r\n");
      if (componentsToastifyDefault.Model.Notifications == null)
        return;
      foreach (ToastifyNotification notification in componentsToastifyDefault.Model.Notifications)
      {
        ToastifyEntity configuration = componentsToastifyDefault.Model.Configuration;
        configuration.text = notification.Message;
        configuration.duration = notification.Duration ?? configuration.duration;
        switch (notification.Type)
        {
          case ToastNotificationType.Success:
            configuration.backgroundColor = "#388e3c";
            componentsToastifyDefault.WriteLiteral("                    <script>\r\n                            $(document).ready(function () { Toastify(");
            componentsToastifyDefault.Write((object) componentsToastifyDefault.Html.Raw(configuration.ToJson()));
            componentsToastifyDefault.WriteLiteral(").showToast(); });\r\n                    </script>\r\n");
            continue;
          case ToastNotificationType.Error:
            configuration.backgroundColor = "#d32f2f";
            componentsToastifyDefault.WriteLiteral("                    <script>\r\n                            $(document).ready(function () { Toastify(");
            componentsToastifyDefault.Write((object) componentsToastifyDefault.Html.Raw(configuration.ToJson()));
            componentsToastifyDefault.WriteLiteral(").showToast(); });\r\n                    </script>\r\n");
            continue;
          case ToastNotificationType.Warning:
            configuration.backgroundColor = "#f57c00";
            componentsToastifyDefault.WriteLiteral("                    <script>\r\n                            $(document).ready(function () { Toastify(");
            componentsToastifyDefault.Write((object) componentsToastifyDefault.Html.Raw(configuration.ToJson()));
            componentsToastifyDefault.WriteLiteral(").showToast(); });\r\n                    </script>\r\n");
            continue;
          case ToastNotificationType.Information:
            configuration.backgroundColor = "#651fff";
            componentsToastifyDefault.WriteLiteral("                    <script>\r\n                            $(document).ready(function () { Toastify(");
            componentsToastifyDefault.Write((object) componentsToastifyDefault.Html.Raw(configuration.ToJson()));
            componentsToastifyDefault.WriteLiteral(").showToast(); });\r\n                    </script>\r\n");
            continue;
          case ToastNotificationType.Custom:
            configuration.backgroundColor = notification.BackgroundColor;
            componentsToastifyDefault.WriteLiteral("                    <script>\r\n                            $(document).ready(function () { Toastify(");
            componentsToastifyDefault.Write((object) componentsToastifyDefault.Html.Raw(configuration.ToJson()));
            componentsToastifyDefault.WriteLiteral(").showToast(); });\r\n                    </script>\r\n");
            continue;
          default:
            continue;
        }
      }
    }

    [RazorInject]
    public IModelExpressionProvider ModelExpressionProvider { get; private set; }

    [RazorInject]
    public IUrlHelper Url { get; private set; }

    [RazorInject]
    public IViewComponentHelper Component { get; private set; }

    [RazorInject]
    public IJsonHelper Json { get; private set; }

    [RazorInject]
    public IHtmlHelper<ToastifyViewModel> Html { get; private set; }
  }
}
