#pragma checksum "C:\Users\MI\source\repos\ChristmasShop\ChristmasShop\Views\Trees\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74422c6e5dfc6ea15ff461aa0bd1737c364b1d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trees_List), @"mvc.1.0.view", @"/Views/Trees/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Trees/List.cshtml", typeof(AspNetCore.Views_Trees_List))]
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
#line 1 "C:\Users\MI\source\repos\ChristmasShop\ChristmasShop\Views\_ViewImports.cshtml"
using ChristmasShop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\MI\source\repos\ChristmasShop\ChristmasShop\Views\_ViewImports.cshtml"
using ChristmasShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74422c6e5dfc6ea15ff461aa0bd1737c364b1d1d", @"/Views/Trees/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3465a19e15f5f4578791cec500c5f7447c869a", @"/Views/_ViewImports.cshtml")]
    public class Views_Trees_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\MI\source\repos\ChristmasShop\ChristmasShop\Views\Trees\List.cshtml"
  
    foreach (Tree tree in Model.allTrees)
    {
        

#line default
#line hidden
            BeginContext(63, 30, false);
#line 4 "C:\Users\MI\source\repos\ChristmasShop\ChristmasShop\Views\Trees\List.cshtml"
   Write(Html.Partial("AllTrees", tree));

#line default
#line hidden
            EndContext();
#line 4 "C:\Users\MI\source\repos\ChristmasShop\ChristmasShop\Views\Trees\List.cshtml"
                                       ;
    }

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591