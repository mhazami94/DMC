#pragma checksum "C:\Users\HP\Source\Repos\DMC\WebApp\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46ffe848150eb0d7f3e51c33ba55e31964fca980"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\HP\Source\Repos\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Source\Repos\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Source\Repos\DMC\WebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ffe848150eb0d7f3e51c33ba55e31964fca980", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168f1340921e84f777b89e37f16f69dab2477aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Source\Repos\DMC\WebApp\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""sub-header"">
    <div class=""sub-img"">
        <img src=""/img/sub/Contact.jpg"" />
        <h1>İLETİŞİM</h1>
    </div>
</section>
<section class=""sub-content"">
    <div class=""sub-seprator"">
        <span></span>
    </div>
    <div class=""contact-row"">
        <span>
            <i class=""fas fa-map-marker-alt""></i>
        </span>
        <span>No.5 New Road, Belize Central America</span>
    </div>
    <div class=""contact-row"">
        <span>
            <i class=""fas fa-envelope""></i>
        </span>
        <span>
            info@dmcmarketslimited.com
        </span>
    </div>
    <div class=""contact-row mr-b-100"">
        <span>
            <i class=""fas fa-phone-alt""></i>
        </span>
        <span>
            +501 223 5 803
        </span>
    </div>
    <p class=""mr-b-100"">
        İletişim formunu doldurarak bizimle iletişime geçebilir, tüm soru ve önerilerinizi bizimle paylaşabilirsiniz. Müşteri Deneyimi Departmanımız en kısa
        süre iç");
            WriteLiteral(@"erisinde sizinle iletişime geçecektir.
    </p>

    <div class=""company-box"">
        <div class=""contact-text"">

        </div>
        <div class=""company-form"">
            <input placeholder=""Adınız Soyadınız *"" class=""input-style"" />
            <input placeholder=""Telefon Numaranız *"" class=""input-style"" />
            <input placeholder=""E-Posta Adresiniz *"" class=""input-style"" />

            <textarea class=""input-styl-area"" placeholder=""Mesajınız *"" rows=""10""></textarea>
            <div class=""company-btn-box"">
                <button type=""submit"" class=""btn-full-red"">Kampanyaya Katıl</button>
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
