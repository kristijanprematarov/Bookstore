#pragma checksum "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb1f832740e3a353f45048a31b6e2913ce402f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Delete), @"mvc.1.0.view", @"/Views/Book/Delete.cshtml")]
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
#line 1 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb1f832740e3a353f45048a31b6e2913ce402f6", @"/Views/Book/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9813f32cfffdf724c39d00915f05a87ed3c57440", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookstore.Entities.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3 class=\"text-center\">ARE YOU SURE YOU WANT TO DELETE THIS BOOK?</h3>\r\n\r\n    <hr>\r\n\r\n    <table class=\"table table-bordered table-hover table-responsive-sm\">\r\n        <tbody>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 11 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 12 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 16 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 21 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.AuthorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.AuthorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 26 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.YearOfIssue));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.YearOfIssue));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 31 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.NumberOfPages));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.NumberOfPages));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 36 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 41 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.PublisherID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.PublisherID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 46 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 51 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 56 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 61 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 62 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 66 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.BookCoverType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 67 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.BookCoverType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 71 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 72 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 76 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 77 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 81 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 82 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 86 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 87 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 91 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Dimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Dimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 96 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 101 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Copies));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 102 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Copies));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 106 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Shipping));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 107 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Shipping));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 111 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.PhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 112 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.PhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 116 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SoldItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 117 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SoldItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 121 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 122 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 126 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 127 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
               Write(Html.DisplayFor(model => model.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <div class=\"mt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb1f832740e3a353f45048a31b6e2913ce402f619483", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecb1f832740e3a353f45048a31b6e2913ce402f619754", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 133 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Book\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input class=\"btn-danger btn\" type=\"submit\" value=\"Delete\" />\r\n            <span>|</span>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb1f832740e3a353f45048a31b6e2913ce402f621575", async() => {
                    WriteLiteral("Back to list");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Entities.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
