#pragma checksum "C:\WorkSpace\DMC\WebApp\Views\Account\OpenNewIB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfec8772fc558c0dae6c4ba3bfa5d3bd6866f058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_OpenNewIB), @"mvc.1.0.view", @"/Views/Account/OpenNewIB.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfec8772fc558c0dae6c4ba3bfa5d3bd6866f058", @"/Views/Account/OpenNewIB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168f1340921e84f777b89e37f16f69dab2477aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_OpenNewIB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/open-new-ib"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\WorkSpace\DMC\WebApp\Views\Account\OpenNewIB.cshtml"
  
    ViewData["Title"] = "NpneNewMom";
    Layout = "~/Views/Shared/_AccountLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""account-section"">
    <div class=""account-section-box"">
        <div class=""account-text-box"">
            <div class=""account-text-contatiner"">
                <h1>
                    IB HESAP AÇ
                </h1>
                <div class=""red-line-seprator"">
                    <span></span>
                </div>
                <p>
                    Eğer kendinize ait bir müşteri portföyünüz var ise ve DMC Markets
                    Limited’in siz IB’ler için hazırlamış olduğu avantajlardan faydalanmak
                    istiyorsanız bizimle iletişime geçebilirsiniz.
                </p>
                <p>
                    DCM Markets Limited’in emir iletimi, düşük spread ve yüksek lot iadesi
                    gibi avantajlarından hem siz hem de müşterilerinizin yararlanmaya
                    başlaması için öncelikle yandaki formu doldurun.
                </p>
                <p>
                    Alanında uzman müşteri temsilcilerimiz ile yapac");
            WriteLiteral("ağınız görüşmeler\r\n                    sonrası sizin için en uygun seçenekleri beraber yaratalım.\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\WorkSpace\DMC\WebApp\Views\Account\OpenNewIB.cshtml"
              
                if (ViewBag.Status != null)
                    if ((bool)ViewBag.Status)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"message message-success\">\r\n                            Bilgileriniz tarafımıza başarıyla iletilmiştir.<br /> Teşekkürler.\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\WorkSpace\DMC\WebApp\Views\Account\OpenNewIB.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"message message-danger\">\r\n                            Bilgileriniz iletilmemiştir. <br />Lütfen tekrar formu doldurun.\r\n                        </div>\r\n");
#nullable restore
#line 45 "C:\WorkSpace\DMC\WebApp\Views\Account\OpenNewIB.cshtml"
                    }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"account-form-box\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfec8772fc558c0dae6c4ba3bfa5d3bd6866f0586626", async() => {
                WriteLiteral(@"
                <section class=""register-section"">
                    <div class=""login-logo"">
                        <img src=""/img/DMC_Logo.svg"" />
                    </div>
                    <h1>
                        Kolayca Üye Olun!
                    </h1>
                    ");
#nullable restore
#line 57 "C:\WorkSpace\DMC\WebApp\Views\Account\OpenNewIB.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <input type=""text"" name=""Country"" class=""login-input"" placeholder=""İkamet edilen ülke *"" />
                    <input type=""text"" name=""FirstName"" class=""login-input"" placeholder=""Adınız *"" />
                    <input type=""text"" name=""LastName"" class=""login-input"" placeholder=""Soy Adınız *"" />
                    <input type=""text"" name=""Email"" class=""login-input"" placeholder=""E-Posta *"" />
                    <input type=""text"" name=""Password"" class=""login-input"" placeholder=""Telefon *"" />
");
                WriteLiteral("                    <button type=\"submit\" class=\"login-form-btn\">Hesap Oluştur</button>\r\n                </section>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"register-footer text-center\">\r\n                <span>ya da</span>\r\n                <a href=\"/login\">Üye Ol</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
