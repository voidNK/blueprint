
using Blueprint.ToastNotification.Enums;
using Blueprint.ToastNotification.Notyf;
using Blueprint.ToastNotification.Notyf.Models;
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
  [RazorSourceChecksum("SHA1", "88084ce6b59735c080e1ca4e3c3a87b9e4a7b7fb", "/Views/Shared/Components/Notyf/Default.cshtml")]
  public class Views_Shared_Components_Notyf_Default : RazorPage<NotyfViewModel>
  {
    private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("rel", (object) new HtmlString("stylesheet"), HtmlAttributeValueStyle.DoubleQuotes);
    private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("href", (object) new HtmlString("~/_content/Blueprint.ToastNotification/notyf.min.css"), HtmlAttributeValueStyle.DoubleQuotes);
    private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("src", (object) new HtmlString("~/_content/Blueprint.ToastNotification/notyf.min.js"), HtmlAttributeValueStyle.DoubleQuotes);
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
      Views_Shared_Components_Notyf_Default componentsNotyfDefault = this;
      componentsNotyfDefault.WriteLiteral("<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" integrity=\"sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN\" crossorigin=\"anonymous\">\r\n");
      componentsNotyfDefault.__tagHelperExecutionContext = componentsNotyfDefault.__tagHelperScopeManager.Begin("link", TagMode.StartTagOnly, "88084ce6b59735c080e1ca4e3c3a87b9e4a7b7fb4378", (Func<Task>) (async () => { }));
      componentsNotyfDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = componentsNotyfDefault.CreateTagHelper<UrlResolutionTagHelper>();
      componentsNotyfDefault.__tagHelperExecutionContext.Add((ITagHelper) componentsNotyfDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
      componentsNotyfDefault.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared_Components_Notyf_Default.__tagHelperAttribute_0);
      componentsNotyfDefault.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared_Components_Notyf_Default.__tagHelperAttribute_1);
      await componentsNotyfDefault.__tagHelperRunner.RunAsync(componentsNotyfDefault.__tagHelperExecutionContext);
      if (!componentsNotyfDefault.__tagHelperExecutionContext.Output.IsContentModified)
        await componentsNotyfDefault.__tagHelperExecutionContext.SetOutputContentAsync();
      componentsNotyfDefault.Write((object) componentsNotyfDefault.__tagHelperExecutionContext.Output);
      componentsNotyfDefault.__tagHelperExecutionContext = componentsNotyfDefault.__tagHelperScopeManager.End();
      componentsNotyfDefault.WriteLiteral("\r\n");
      componentsNotyfDefault.__tagHelperExecutionContext = componentsNotyfDefault.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "88084ce6b59735c080e1ca4e3c3a87b9e4a7b7fb5493", (Func<Task>) (async () => { }));
      componentsNotyfDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = componentsNotyfDefault.CreateTagHelper<UrlResolutionTagHelper>();
      componentsNotyfDefault.__tagHelperExecutionContext.Add((ITagHelper) componentsNotyfDefault.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
      componentsNotyfDefault.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared_Components_Notyf_Default.__tagHelperAttribute_2);
      await componentsNotyfDefault.__tagHelperRunner.RunAsync(componentsNotyfDefault.__tagHelperExecutionContext);
      if (!componentsNotyfDefault.__tagHelperExecutionContext.Output.IsContentModified)
        await componentsNotyfDefault.__tagHelperExecutionContext.SetOutputContentAsync();
      componentsNotyfDefault.Write((object) componentsNotyfDefault.__tagHelperExecutionContext.Output);
      componentsNotyfDefault.__tagHelperExecutionContext = componentsNotyfDefault.__tagHelperScopeManager.End();
      componentsNotyfDefault.WriteLiteral("\r\n<script>\r\n    const notyf = new Notyf(");
      componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(componentsNotyfDefault.Model.Configuration));
      componentsNotyfDefault.WriteLiteral(");\r\n</script>\r\n");
      if (componentsNotyfDefault.Model.Notifications != null)
      {
        foreach (NotyfNotification notification in componentsNotyfDefault.Model.Notifications)
        {
          switch (notification.Type)
          {
            case ToastNotificationType.Success:
              componentsNotyfDefault.WriteLiteral("                    <script>\r\n                       $(document).ready(function () {toastNotifySuccess('");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(notification.Message));
              componentsNotyfDefault.WriteLiteral("','");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw((object) notification.Duration));
              componentsNotyfDefault.WriteLiteral("');});\r\n                    </script>\r\n");
              continue;
            case ToastNotificationType.Error:
              componentsNotyfDefault.WriteLiteral("                    <script>\r\n                        $(document).ready(function () { toastNotifyError('");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(notification.Message));
              componentsNotyfDefault.WriteLiteral("','");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw((object) notification.Duration));
              componentsNotyfDefault.WriteLiteral("');});\r\n                    </script>\r\n");
              continue;
            case ToastNotificationType.Warning:
              componentsNotyfDefault.WriteLiteral("                    <script>\r\n                        $(document).ready(function () { toastNotifyWarning('");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(notification.Message));
              componentsNotyfDefault.WriteLiteral("','");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw((object) notification.Duration));
              componentsNotyfDefault.WriteLiteral("');});\r\n                    </script>\r\n");
              continue;
            case ToastNotificationType.Information:
              componentsNotyfDefault.WriteLiteral("                    <script>\r\n                        $(document).ready(function () { toastNotifyInformation('");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(notification.Message));
              componentsNotyfDefault.WriteLiteral("','");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw((object) notification.Duration));
              componentsNotyfDefault.WriteLiteral("');});\r\n                    </script>\r\n");
              continue;
            case ToastNotificationType.Custom:
              componentsNotyfDefault.WriteLiteral("                    <script>\r\n                        $(document).ready(function ()\r\n                        {\r\n                            toastNotifyCustom(\r\n                                '");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(notification.Message));
              componentsNotyfDefault.WriteLiteral("',\r\n                                '");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw((object) notification.Duration));
              componentsNotyfDefault.WriteLiteral("',\r\n                                '");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(notification.BackgroundColor));
              componentsNotyfDefault.WriteLiteral("',\r\n                            '");
              componentsNotyfDefault.Write((object) componentsNotyfDefault.Html.Raw(notification.Icon));
              componentsNotyfDefault.WriteLiteral("');\r\n                        });\r\n                    </script>\r\n");
              continue;
            default:
              continue;
          }
        }
      }
      componentsNotyfDefault.WriteLiteral("<script type=\"text/javascript\">\r\n\r\n    function toastNotifySuccess(message, duration) {\r\n        if (duration) { notyf.success({ message: message, duration: duration }); }\r\n        else { notyf.success({ message: message }); }\r\n    }\r\n    function toastNotifyError(message, duration) {\r\n        if (duration) { notyf.error({ message: message, duration: duration }); }\r\n        else { notyf.error({ message: message }); }\r\n    }\r\n    function toastNotifyWarning(message, duration) {\r\n        if (duration) { notyf.open({ type: 'warning', message: message, duration: duration }); }\r\n        else { notyf.open({ type: 'warning', message: message }); }\r\n\r\n    }\r\n    function toastNotifyInformation(message, duration) {\r\n        if (duration) { notyf.open({ type: 'info', message: message, duration: duration }); }\r\n        else { notyf.open({ type: 'info', message: message }); }\r\n\r\n    }\r\n    function toastNotifyCustom(message, duration, color, iconClass) {\r\n\r\n        var lightOrDarkClassName = pickTextColorBasedOnBgColorAd");
      componentsNotyfDefault.WriteLiteral("vanced(color);\r\n        var iconClassName = iconClass.concat(' ').concat(lightOrDarkClassName);\r\n        if (duration) {\r\n            notyf.open({\r\n                type: 'custom',\r\n                message: message,\r\n                duration: duration,\r\n                className: lightOrDarkClassName,\r\n                background: color,\r\n                icon: {\r\n                    className: iconClassName,\r\n                    tagName: 'i'\r\n                }\r\n            });\r\n        }\r\n        else {\r\n            notyf.open({\r\n                type: 'custom',\r\n                message: message,\r\n                className: lightOrDarkClassName,\r\n                background: color,\r\n                icon: {\r\n                    className: iconClassName,\r\n                    tagName: 'i'\r\n                }\r\n            });\r\n        }\r\n\r\n    }\r\n    function colourNameToHex(colour) {\r\n        var colours = {\r\n            \"aliceblue\": \"#f0f8ff\", \"antiquewhite\": \"#faebd7\", \"aqua\": \"#00ffff\", \"aquamarine\": \"#7fffd4\", \"a");
      componentsNotyfDefault.WriteLiteral("zure\": \"#f0ffff\",\r\n            \"beige\": \"#f5f5dc\", \"bisque\": \"#ffe4c4\", \"black\": \"#000000\", \"blanchedalmond\": \"#ffebcd\", \"blue\": \"#0000ff\", \"blueviolet\": \"#8a2be2\", \"brown\": \"#a52a2a\", \"burlywood\": \"#deb887\",\r\n            \"cadetblue\": \"#5f9ea0\", \"chartreuse\": \"#7fff00\", \"chocolate\": \"#d2691e\", \"coral\": \"#ff7f50\", \"cornflowerblue\": \"#6495ed\", \"cornsilk\": \"#fff8dc\", \"crimson\": \"#dc143c\", \"cyan\": \"#00ffff\",\r\n            \"darkblue\": \"#00008b\", \"darkcyan\": \"#008b8b\", \"darkgoldenrod\": \"#b8860b\", \"darkgray\": \"#a9a9a9\", \"darkgreen\": \"#006400\", \"darkkhaki\": \"#bdb76b\", \"darkmagenta\": \"#8b008b\", \"darkolivegreen\": \"#556b2f\",\r\n            \"darkorange\": \"#ff8c00\", \"darkorchid\": \"#9932cc\", \"darkred\": \"#8b0000\", \"darksalmon\": \"#e9967a\", \"darkseagreen\": \"#8fbc8f\", \"darkslateblue\": \"#483d8b\", \"darkslategray\": \"#2f4f4f\", \"darkturquoise\": \"#00ced1\",\r\n            \"darkviolet\": \"#9400d3\", \"deeppink\": \"#ff1493\", \"deepskyblue\": \"#00bfff\", \"dimgray\": \"#696969\", \"dodgerblue\": \"#1e90ff\",\r\n            \"firebrick\": \"#b22222\", \"floralwhit");
      componentsNotyfDefault.WriteLiteral("e\": \"#fffaf0\", \"forestgreen\": \"#228b22\", \"fuchsia\": \"#ff00ff\",\r\n            \"gainsboro\": \"#dcdcdc\", \"ghostwhite\": \"#f8f8ff\", \"gold\": \"#ffd700\", \"goldenrod\": \"#daa520\", \"gray\": \"#808080\", \"green\": \"#008000\", \"greenyellow\": \"#adff2f\",\r\n            \"honeydew\": \"#f0fff0\", \"hotpink\": \"#ff69b4\",\r\n            \"indianred \": \"#cd5c5c\", \"indigo\": \"#4b0082\", \"ivory\": \"#fffff0\", \"khaki\": \"#f0e68c\",\r\n            \"lavender\": \"#e6e6fa\", \"lavenderblush\": \"#fff0f5\", \"lawngreen\": \"#7cfc00\", \"lemonchiffon\": \"#fffacd\", \"lightblue\": \"#add8e6\", \"lightcoral\": \"#f08080\", \"lightcyan\": \"#e0ffff\", \"lightgoldenrodyellow\": \"#fafad2\",\r\n            \"lightgrey\": \"#d3d3d3\", \"lightgreen\": \"#90ee90\", \"lightpink\": \"#ffb6c1\", \"lightsalmon\": \"#ffa07a\", \"lightseagreen\": \"#20b2aa\", \"lightskyblue\": \"#87cefa\", \"lightslategray\": \"#778899\", \"lightsteelblue\": \"#b0c4de\",\r\n            \"lightyellow\": \"#ffffe0\", \"lime\": \"#00ff00\", \"limegreen\": \"#32cd32\", \"linen\": \"#faf0e6\",\r\n            \"magenta\": \"#ff00ff\", \"maroon\": \"#800000\", \"mediumaquamarine\": \"#66cdaa");
      componentsNotyfDefault.WriteLiteral("\", \"mediumblue\": \"#0000cd\", \"mediumorchid\": \"#ba55d3\", \"mediumpurple\": \"#9370d8\", \"mediumseagreen\": \"#3cb371\", \"mediumslateblue\": \"#7b68ee\",\r\n            \"mediumspringgreen\": \"#00fa9a\", \"mediumturquoise\": \"#48d1cc\", \"mediumvioletred\": \"#c71585\", \"midnightblue\": \"#191970\", \"mintcream\": \"#f5fffa\", \"mistyrose\": \"#ffe4e1\", \"moccasin\": \"#ffe4b5\",\r\n            \"navajowhite\": \"#ffdead\", \"navy\": \"#000080\",\r\n            \"oldlace\": \"#fdf5e6\", \"olive\": \"#808000\", \"olivedrab\": \"#6b8e23\", \"orange\": \"#ffa500\", \"orangered\": \"#ff4500\", \"orchid\": \"#da70d6\",\r\n            \"palegoldenrod\": \"#eee8aa\", \"palegreen\": \"#98fb98\", \"paleturquoise\": \"#afeeee\", \"palevioletred\": \"#d87093\", \"papayawhip\": \"#ffefd5\", \"peachpuff\": \"#ffdab9\", \"peru\": \"#cd853f\", \"pink\": \"#ffc0cb\", \"plum\": \"#dda0dd\", \"powderblue\": \"#b0e0e6\", \"purple\": \"#800080\",\r\n            \"rebeccapurple\": \"#663399\", \"red\": \"#ff0000\", \"rosybrown\": \"#bc8f8f\", \"royalblue\": \"#4169e1\",\r\n            \"saddlebrown\": \"#8b4513\", \"salmon\": \"#fa8072\", \"sandybrown\": \"#f4a460\", \"seagreen\": ");
      componentsNotyfDefault.WriteLiteral("\"#2e8b57\", \"seashell\": \"#fff5ee\", \"sienna\": \"#a0522d\", \"silver\": \"#c0c0c0\", \"skyblue\": \"#87ceeb\", \"slateblue\": \"#6a5acd\", \"slategray\": \"#708090\", \"snow\": \"#fffafa\", \"springgreen\": \"#00ff7f\", \"steelblue\": \"#4682b4\",\r\n            \"tan\": \"#d2b48c\", \"teal\": \"#008080\", \"thistle\": \"#d8bfd8\", \"tomato\": \"#ff6347\", \"turquoise\": \"#40e0d0\",\r\n            \"violet\": \"#ee82ee\",\r\n            \"wheat\": \"#f5deb3\", \"white\": \"#ffffff\", \"whitesmoke\": \"#f5f5f5\",\r\n            \"yellow\": \"#ffff00\", \"yellowgreen\": \"#9acd32\"\r\n        };\r\n\r\n        if (typeof colours[colour.toLowerCase()] != 'undefined')\r\n            return colours[colour.toLowerCase()];\r\n\r\n        return false;\r\n    }\r\n    function pickTextColorBasedOnBgColorAdvanced(bgColor) {\r\n\r\n        var hexColor = colourNameToHex(bgColor);\r\n        var color = (bgColor.charAt(0) === '#') ? bgColor.substring(1, 7) : hexColor.substring(1, 7);\r\n        var r = parseInt(color.substring(0, 2), 16); // hexToR\r\n        var g = parseInt(color.substring(2, 4), 16); // hexToG\r\n        var b");
      componentsNotyfDefault.WriteLiteral(" = parseInt(color.substring(4, 6), 16); // hexToB\r\n        var uicolors = [r / 255, g / 255, b / 255];\r\n        var c = uicolors.map((col) => {\r\n            if (col <= 0.03928) {\r\n                return col / 12.92;\r\n            }\r\n            return Math.pow((col + 0.055) / 1.055, 2.4);\r\n        });\r\n        var L = (0.2126 * c[0]) + (0.7152 * c[1]) + (0.0722 * c[2]);\r\n        return (L > 0.179) ? 'text-dark' : 'text-white';\r\n    }\r\n</script>");
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
    public IHtmlHelper<NotyfViewModel> Html { get; private set; }
  }
}
