#pragma checksum "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\Account\OpenNewMam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93441a3e6e9bbe7350ba7d38d3e59fa8cde61c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_OpenNewMam), @"mvc.1.0.view", @"/Views/Account/OpenNewMam.cshtml")]
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
#line 1 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93441a3e6e9bbe7350ba7d38d3e59fa8cde61c6f", @"/Views/Account/OpenNewMam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7ddbc2edf40d779056eff7f19e735f5176330e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_OpenNewMam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/open-new-mam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\Account\OpenNewMam.cshtml"
  
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
                    MAM HESAP AÇ
                </h1>
                <div class=""red-line-seprator"">
                    <span></span>
                </div>
                <p>
                    MAM platformu, DMC Markets Limited’in hesap yönetimi yapan
                    portföy yöneticileri ve IB’ler için sunmuş olduğu ücretsiz bir platformdur.
                </p>
                <p>
                    Birden fazla hesapta işlem yapan ve hesaplar arası geçiş sebebiyle
                    piyasadaki fırsatları kaçıran müşterilerimiz, MAM platformu ile
                    ana hesaptan açmış oldukları işlemleri bakiye durumuna göre
                    alt hesaplara hızlı bir şekilde aktararak fon yönetimini daha kolay
                    bir şekilde gerçekleştirebilmektedir.
                </p>
     ");
            WriteLiteral("           <p>\r\n                    Ücretsiz MAM platformu ve DMC Markets Limited’in size özel\r\n                    kampanyalarından yararlanmak için hemen aşağıdaki formu doldurun.\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\Account\OpenNewMam.cshtml"
              
                if (ViewBag.Status != null)
                    if ((bool)ViewBag.Status)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"message message-success\">\r\n                            Bilgileriniz tarafımıza başarıyla iletilmiştir.<br /> Teşekkürler.\r\n                        </div>\r\n");
#nullable restore
#line 40 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\Account\OpenNewMam.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"message message-danger\">\r\n                            Bilgileriniz iletilmemiştir. <br />Lütfen tekrar formu doldurun.\r\n                        </div>\r\n");
#nullable restore
#line 46 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\Account\OpenNewMam.cshtml"
                    }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"account-form-box\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93441a3e6e9bbe7350ba7d38d3e59fa8cde61c6f6898", async() => {
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
#line 58 "C:\Users\pc\Source\Repos\mhazami94\DMC\WebApp\Views\Account\OpenNewMam.cshtml"
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
