#pragma checksum "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa09b08e99286f7035f39f223aafaca6b7f980c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Modal.cshtml", typeof(AspNetCore.Views_Shared__Modal))]
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
#line 1 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\_ViewImports.cshtml"
using Desafio_Framework;

#line default
#line hidden
#line 2 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\_ViewImports.cshtml"
using Desafio_Framework.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa09b08e99286f7035f39f223aafaca6b7f980c", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a38c4a4ca8e273c16f0e2ba314261e5af0bf1c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Desafio_Framework.Models.BootstrapModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 25, true);
            WriteLiteral("\r\n<div aria-hidden=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 73, "\"", 111, 1);
#line 3 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 91, Model.AreaLabeledId, 91, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(112, 28, true);
            WriteLiteral(" role=\"dialog\" tabindex=\"-1\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 140, "\"", 154, 1);
#line 3 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 145, Model.ID, 145, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(155, 30, true);
            WriteLiteral(" class=\"modal fade\">\r\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 185, "\"", 227, 2);
            WriteAttributeValue("", 193, "modal-dialog", 193, 12, true);
#line 4 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Shared\_Modal.cshtml"
WriteAttributeValue(" ", 205, Model.ModalSizeClass, 206, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(228, 90, true);
            WriteLiteral(">\r\n        <div class=\"modal-content\">          \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Desafio_Framework.Models.BootstrapModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
