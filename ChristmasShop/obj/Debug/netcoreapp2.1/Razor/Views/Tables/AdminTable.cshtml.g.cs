#pragma checksum "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9956244901a0af13bec094683e11462ae4971a86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tables_AdminTable), @"mvc.1.0.view", @"/Views/Tables/AdminTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tables/AdminTable.cshtml", typeof(AspNetCore.Views_Tables_AdminTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9956244901a0af13bec094683e11462ae4971a86", @"/Views/Tables/AdminTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3465a19e15f5f4578791cec500c5f7447c869a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tables_AdminTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("admin-table-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9956244901a0af13bec094683e11462ae4971a865055", async() => {
                BeginContext(74, 235, true);
                WriteLiteral("\r\n\r\n    <div class=\"admin-table-subcontainer\">\r\n        <table class=\"admin-table\">\r\n            <tbody class=\"admin-table-body\">\r\n                <tr class=\"admin-table-title\"><th></th><th>Email</th><th>Status</th><th>Role</th></tr>\r\n");
                EndContext();
#line 7 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
                 foreach (var user in Model.GetUsers)
                {

#line default
#line hidden
                BeginContext(383, 153, true);
                WriteLiteral("                    <tr class=\"admin-table-users\">\r\n                        <td>\r\n                            <input type=\"checkbox\" name=\"selectedUsers\"");
                EndContext();
                BeginWriteAttribute("id", "\r\n                                   id=\"", 536, "\"", 585, 1);
#line 12 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
WriteAttributeValue("", 577, user.ID, 577, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 586, "\"", 602, 1);
#line 12 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
WriteAttributeValue("", 594, user.ID, 594, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(603, 128, true);
                WriteLiteral("\r\n                                   class=\"admin-table-check-box\">\r\n                        </td>\r\n                        <td>");
                EndContext();
                BeginContext(731, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9956244901a0af13bec094683e11462ae4971a867115", async() => {
                    BeginContext(807, 2, true);
                    WriteLiteral("  ");
                    EndContext();
                    BeginContext(810, 10, false);
#line 15 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
                                                                                                     Write(user.Email);

#line default
#line hidden
                    EndContext();
                    BeginContext(820, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 15 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
                                                                                  WriteLiteral(user.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(825, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 16 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
                           if (!user.Unblocked)
                            {

#line default
#line hidden
                BeginContext(912, 52, true);
                WriteLiteral("                                <td> Blocked </td>\r\n");
                EndContext();
#line 19 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
 }
                            else
                            {

#line default
#line hidden
                BeginContext(1033, 52, true);
                WriteLiteral("                                <td>Unblocked</td>\r\n");
                EndContext();
#line 23 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
} 

#line default
#line hidden
                BeginContext(1090, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 24 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
                           if (user.RoleId == 1)
                            {

#line default
#line hidden
                BeginContext(1171, 50, true);
                WriteLiteral("                                <td> Admin </td>\r\n");
                EndContext();
#line 27 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
 }
                            else
                            {

#line default
#line hidden
                BeginContext(1290, 47, true);
                WriteLiteral("                                <td>User</td>\r\n");
                EndContext();
#line 31 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
} 

#line default
#line hidden
                BeginContext(1342, 27, true);
                WriteLiteral("                    </tr>\r\n");
                EndContext();
#line 33 "C:\Users\MI\Desktop\BSUIR\3 kurs\00 COURSE PROJECT 00\GIT\shop\ChristmasShop\Views\Tables\AdminTable.cshtml"
                }

#line default
#line hidden
                BeginContext(1388, 851, true);
                WriteLiteral(@"            </tbody>
        </table>
    </div>

    <div class=""admin-table-buttons-container"">
        <div class=""admin-table-button-container"">
            <button class=""button admin-table-button"" name=""button"" value=""Block"" type=""submit"">Block</button>
        </div>
        <div class=""admin-table-button-container"">
            <button class=""button admin-table-button"" name=""button"" value=""Unblock"" type=""submit"">Unblock</button>
        </div>
        <div class=""admin-table-button-container"">
            <button class=""button admin-table-button"" name=""button"" value=""Delete"" type=""submit"">Delete</button>
        </div>
        <div class=""admin-table-button-container"">
            <button class=""button admin-table-button"" name=""button"" value=""Admin"" type=""submit"">Make an admin</button>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
