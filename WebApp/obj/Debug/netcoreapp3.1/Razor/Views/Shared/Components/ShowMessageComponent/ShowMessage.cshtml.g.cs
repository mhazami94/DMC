#pragma checksum "G:\WorkSpace\DMC\WebApp\Views\Shared\Components\ShowMessageComponent\ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7c9cd33a4a4c5c0f074064afdf6f8a25f5535d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShowMessageComponent_ShowMessage), @"mvc.1.0.view", @"/Views/Shared/Components/ShowMessageComponent/ShowMessage.cshtml")]
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
#nullable restore
#line 4 "G:\WorkSpace\DMC\WebApp\Views\_ViewImports.cshtml"
using Azami.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7c9cd33a4a4c5c0f074064afdf6f8a25f5535d", @"/Views/Shared/Components/ShowMessageComponent/ShowMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f3ed0e6021b89a17849a10930e0472b87579903", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShowMessageComponent_ShowMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Helpers.ShowMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "G:\WorkSpace\DMC\WebApp\Views\Shared\Components\ShowMessageComponent\ShowMessage.cshtml"
 if (Model.Show)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"message-box\"");
            BeginWriteAttribute("class", " class=\"", 84, "\"", 148, 3);
            WriteAttributeValue("", 92, "message-box", 92, 11, true);
            WriteAttributeValue(" ", 103, "message-box-", 104, 13, true);
#nullable restore
#line 6 "G:\WorkSpace\DMC\WebApp\Views\Shared\Components\ShowMessageComponent\ShowMessage.cshtml"
WriteAttributeValue("", 116, Model.Type.ToString().ToLower(), 116, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <span class=\"message-box-close\" id=\"message-box-close\">\n            <i class=\"fas fa-times\"></i>\n        </span>\n        <p class=\"message-box-text\">\n            ");
#nullable restore
#line 11 "G:\WorkSpace\DMC\WebApp\Views\Shared\Components\ShowMessageComponent\ShowMessage.cshtml"
       Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
        <script>            
            function removeFadeOut(el, speed) {
                var seconds = speed / 1000;
                el.style.transition = ""opacity "" + seconds + ""s ease"";

                el.style.opacity = 0;
                setTimeout(function () {
                    el.parentNode.removeChild(el);
                }, speed);
            }

            setTimeout(function () {
                removeFadeOut(document.getElementById('message-box'), 3000);
            }, 8000)
            document.getElementById(""message-box-close"").addEventListener(""click"", function () {
                document.getElementById('message-box').remove();
            })
        </script>
    </section>
");
#nullable restore
#line 32 "G:\WorkSpace\DMC\WebApp\Views\Shared\Components\ShowMessageComponent\ShowMessage.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Helpers.ShowMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
