#pragma checksum "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47c76a745a6c2e66867a8ec2610b812b22a58986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Collares), @"mvc.1.0.view", @"/Views/Products/Collares.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47c76a745a6c2e66867a8ec2610b812b22a58986", @"/Views/Products/Collares.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdd31a4af9f38b9a964556164967c5e135ebc6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Collares : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BijouWorld.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
  
	ViewData["Title"] = "Collares";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Collares</h1>\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 12 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 15 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 18 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 21 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 24 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 29 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
         foreach (var item in Model) if (item.Category == "3")
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 33 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 39 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<img class=\"proFoto\"");
            BeginWriteAttribute("src", " src=\"", 859, "\"", 908, 1);
#nullable restore
#line 42 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
WriteAttributeValue("", 865, Html.DisplayFor(modelItem => item.Picture), 865, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 45 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 48 "C:\Users\licja\Dropbox\Repos\Curso .Net\. Project\BijouWorld\BijouWorld\Views\Products\Collares.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>");
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
