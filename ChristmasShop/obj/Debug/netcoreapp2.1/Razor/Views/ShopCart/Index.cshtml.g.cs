#pragma checksum "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1998bedef1d1cfafa872b38a696e8d44404bd59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShopCart/Index.cshtml", typeof(AspNetCore.Views_ShopCart_Index))]
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
#line 1 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\_ViewImports.cshtml"
using ChristmasShop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\_ViewImports.cshtml"
using ChristmasShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1998bedef1d1cfafa872b38a696e8d44404bd59", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3465a19e15f5f4578791cec500c5f7447c869a", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
 foreach (var el in Model.shopCart.listShopItems)
{

#line default
#line hidden
            BeginContext(84, 110, true);
            WriteLiteral("    <div class=\"order-item-container\">\r\n        <div class=\"order-item\">\r\n            <img class=\"order-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 194, "\"", 212, 1);
#line 8 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
WriteAttributeValue("", 200, el.tree.img, 200, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 213, "\"", 232, 1);
#line 8 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
WriteAttributeValue("", 219, el.tree.name, 219, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(233, 185, true);
            WriteLiteral(" />\r\n            <div class=\"order-description-container\">\r\n                <div class=\"order-description\">\r\n                    <p>Производитель: <span class=\"order-description-value\">");
            EndContext();
            BeginContext(419, 12, false);
#line 11 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
                                                                       Write(el.tree.name);

#line default
#line hidden
            EndContext();
            BeginContext(431, 82, true);
            WriteLiteral("</span></p>\r\n                    <p>Модель: <span class=\"order-description-value\">");
            EndContext();
            BeginContext(514, 17, false);
#line 12 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
                                                                Write(el.tree.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(531, 141, true);
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"order-price\">\r\n                <p class=\"order-price-value\">");
            EndContext();
            BeginContext(673, 13, false);
#line 16 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
                                        Write(el.tree.price);

#line default
#line hidden
            EndContext();
            BeginContext(686, 66, true);
            WriteLiteral("</p>\r\n                <p>BYN</p>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(752, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1998bedef1d1cfafa872b38a696e8d44404bd598083", async() => {
                BeginContext(848, 128, true);
                WriteLiteral("\r\n                <span class=\"delete-item-line1\"></span>\r\n                <span class=\"delete-item-line2\"></span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
                                                                                   WriteLiteral(el.tree.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(980, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 25 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\ShopCart\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1013, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(1021, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1998bedef1d1cfafa872b38a696e8d44404bd5911198", async() => {
                BeginContext(1097, 14, true);
                WriteLiteral("Оформить заказ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
