#pragma checksum "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Shared\_ParcialViewPictures.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34230a620f16acd95312382ec33b27b23581f776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ParcialViewPictures), @"mvc.1.0.view", @"/Views/Shared/_ParcialViewPictures.cshtml")]
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
#line 1 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\_ViewImports.cshtml"
using BijouWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\_ViewImports.cshtml"
using BijouWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34230a620f16acd95312382ec33b27b23581f776", @"/Views/Shared/_ParcialViewPictures.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdd31a4af9f38b9a964556164967c5e135ebc6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ParcialViewPictures : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BijouWorld.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Shared\_ParcialViewPictures.cshtml"
 foreach (var item in Model) if (item.Category == "1")
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<img class=\"proFoto\"");
            BeginWriteAttribute("src", " src=\"", 131, "\"", 180, 1);
#nullable restore
#line 5 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Shared\_ParcialViewPictures.cshtml"
WriteAttributeValue("", 137, Html.DisplayFor(modelItem => item.Picture), 137, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Producto\" />\r\n");
#nullable restore
#line 6 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Shared\_ParcialViewPictures.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p> ANILLOS TIENE EL CAMBIO </p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BijouWorld.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
