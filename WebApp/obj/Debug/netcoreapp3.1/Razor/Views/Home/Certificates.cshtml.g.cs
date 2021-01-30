#pragma checksum "G:\WorkSpace\DMC\WebApp\Views\Home\Certificates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703862acfe101f8d660a41ba5193a0aa7ec3de34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Certificates), @"mvc.1.0.view", @"/Views/Home/Certificates.cshtml")]
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
#line 1 "G:\WorkSpace\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\WorkSpace\DMC\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\WorkSpace\DMC\WebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703862acfe101f8d660a41ba5193a0aa7ec3de34", @"/Views/Home/Certificates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168f1340921e84f777b89e37f16f69dab2477aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Certificates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\WorkSpace\DMC\WebApp\Views\Home\Certificates.cshtml"
  
    ViewData["Title"] = "Certificates";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""sub-header"">
    <div class=""sub-img"">
        <img src=""/img/sub/Certificates.jpg"" />
        <h1>SERTİFİKALAR</h1>
    </div>
</section>
<section class=""sub-content"">
    <div class=""sub-seprator"">
        <span></span>
    </div>
    <p>
        DMC Markets Limited
    </p>
    <p>
        Genç, dinamik, güçlü organizasyonumuz ile kazandığımız yatırımcı güveni ve ödenmiş güçlü sermayesi ile DMC Markets Limited yoluna emin adımlarla ilerliyor.
    </p>
    <p>
        Bu yolculukta başarılarımızı taçlandıran ödüller, yatırımcı güvenini sağlamlaştıran aracı kurumlar, lisanslarımız ve şirket kurucu belgelerimiz için qr kod oluşturma çalışmalarımız devam etmektedir.
        En yakın zamanda güncellemelerimizi gerçekleştireceğiz.
    </p>
    <div class=""certificate-box"">
        <div class=""certificate-item1"">
            <span>
                Şirket Kuruluş Belgesi
            </span>
            <div>
                <img src=""/img/qr1.png"" />
            </div>");
            WriteLiteral(@"
        </div>
        <div class=""certificate-item2"">
            <span>
                Aracı Kurum Lisans Belgesi
            </span>
            <div>
                <img src=""/img/qr2.png"" />
            </div>
        </div>
        <div class=""certificate-item3"">
            <span>
                Başarı Belgesi
            </span>
            <div>
                <img src=""/img/qr3.png"" />
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
