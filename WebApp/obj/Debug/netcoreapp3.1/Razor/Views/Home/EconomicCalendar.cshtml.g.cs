#pragma checksum "C:\WorkSpace\DMC\WebApp\Views\Home\EconomicCalendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe18373732de4f337246f303c2b9377646da7cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EconomicCalendar), @"mvc.1.0.view", @"/Views/Home/EconomicCalendar.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\WorkSpace\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WorkSpace\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WorkSpace\DMC\WebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe18373732de4f337246f303c2b9377646da7cf9", @"/Views/Home/EconomicCalendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168f1340921e84f777b89e37f16f69dab2477aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EconomicCalendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\WorkSpace\DMC\WebApp\Views\Home\EconomicCalendar.cshtml"
  
    ViewData["Title"] = "EconomicCalendar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""sub-header"">
    <div class=""sub-img"">
        <img src=""/img/sub/EconomicCalendar.jpg"" />
        <h1>EKONOMİK TAKVİM</h1>
    </div>
</section>
<section class=""sub-content"">
    <div class=""sub-seprator"">
        <span></span>
    </div>

    <div class=""economic-box"">
        <div class=""economic-text"">
            <p>
                DMC Markets Limited Ekonomik Takvim
            </p>
            <p>
                Anlık finansal gelişmeleri not almanız, kontrol etmeniz ve incelemeniz
                için Ekonomik Takvim büyük önem arz etmektedir.
            </p>
            <p>
                Forex piyasasında yatırımlarınızı bir üst seviyeye taşımak, değişen
                dünyamızda varlıklarınızı profesyonel olarak yönetmeniz için
                DMC Markets Limited büyük özveri ile çalışmaktadır.
            </p>
            <p>
                Sosyal medya hesaplarımızı beğenerek ekonomik gelişmeleri ayrıca
                takip edebilirsiniz.
       ");
            WriteLiteral(@"     </p>
            <p>
                <a href=""https://www.instagram.com/dmcforexglobal/"">
                    <img src=""/img/instagram.png"" />
                </a>
                <a href=""#"">
                    <img src=""/img/facebook.png"" />
                </a>
                <a href=""https://www.twitter.com/dmcforexglobal/"">
                    <img src=""/img/twitter.png"" />
                </a>
                <a href=""#"">
                    <img src=""/img/whatsapp.png"" />
                </a>
            </p>
        </div>
        <div class=""economic-chart"">
            <div class=""tradingview-widget-container"">
                <div class=""tradingview-widget-container__widget""></div>
                <script type=""text/javascript"" src=""https://s3.tradingview.com/external-embedding/embed-widget-events.js"" async>
                    {
                        ""colorTheme"": ""light"",
                            ""isTransparent"": false,
                                ""width"": """);
            WriteLiteral(@"510"",
                                    ""height"": ""600"",
                                        ""locale"": ""tr"",
                                            ""importanceFilter"": ""-1,0,1"",
                                                ""currencyFilter"": ""TRL""
                    }
                </script>
            </div>
        </div>
    </div>




</section>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
