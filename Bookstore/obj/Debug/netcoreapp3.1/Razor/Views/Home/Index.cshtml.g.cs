#pragma checksum "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68665ad9cb490be4363d223fa5a6145529db52c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68665ad9cb490be4363d223fa5a6145529db52c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9813f32cfffdf724c39d00915f05a87ed3c57440", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookstore.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:450px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Bookstore"; // so ova go pravime naslovot na tabot

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Search Section -->\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c68665ad9cb490be4363d223fa5a6145529db52c5428", async() => {
                WriteLiteral(@"
        <div class=""p-3 search-main"">
            <button class=""btn search-btn-icon"">
                <i class=""fa fa-search""></i>
            </button>
            <input type=""text"" class=""form-control search-box-style"" id=""searchbook"" />
            <button class=""btn btn-success search-btn"" id=""searchBtn"">Search</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<!-- Banner Section -->
<div class=""container-fluid bookstore-background px-0"">
    <h1 class=""display-4 banner-text-style1 animate__animated animate__fadeIn animate__slower"">Welcome to our online bookstore!</h1>
    <h4 class=""display-4 banner-text-style2 animate__animated animate__fadeIn animate__slower animate__delay-1s"">Find your next adventure!</h4>
    <div class=""col-12 col-md-7 quotes-section"">
        <blockquote class=""quote-text-quote"" id=""quote""></blockquote>
        <p class=""quote-text-author"" id=""quote_author""></p>
        <p class=""quote-text-tags"" id=""quote_tags""></p>
    </div>
</div>


<!-- All Books Section -->
<div class=""container-fluid"">
    <h2>All Books</h2>
    <h6><em>List of all books</em></h6>
    <div class=""row pb-5"">
");
#nullable restore
#line 38 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
         foreach (var book in Model.AllBooksList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-6 col-lg-4 col-xl-3 mt-5\">\r\n                <div class=\"card h-100 mx-auto\" style=\"max-width: 350px;\">\r\n                    <div class=\"image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c68665ad9cb490be4363d223fa5a6145529db52c8510", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1639, "~/photos/", 1639, 9, true);
#nullable restore
#line 43 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1648, book.PhotoURL, 1648, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""card-body"">
                        <div class=""text-center d-flex flex-column justify-content-center"" style=""height:120px"">
                            <h5 class=""card-title w-100""><a class=""text-dark""");
            BeginWriteAttribute("href", " href=\"", 1995, "\"", 2024, 2);
            WriteAttributeValue("", 2002, "/Book/Details/", 2002, 14, true);
#nullable restore
#line 47 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2016, book.Id, 2016, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                                                                                                       Write(Html.DisplayFor(modelItem => book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                            <h6");
            BeginWriteAttribute("class", " class=\"", 2109, "\"", 2117, 0);
            EndWriteAttribute();
            WriteLiteral("><em>by <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 2146, "\"", 2183, 2);
            WriteAttributeValue("", 2153, "/Author/Details/", 2153, 16, true);
#nullable restore
#line 48 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2169, book.AuthorID, 2169, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                                                                                                      Write(Html.DisplayFor(modelItem => book.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></em></h6>\r\n                        </div>\r\n                        <hr />\r\n                        <p class=\"card-text\">Category: ");
#nullable restore
#line 51 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => book.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Genre: ");
#nullable restore
#line 52 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => book.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Book Rating: ");
#nullable restore
#line 53 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => book.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/5.0</p>
                        <button class=""btn btn-secondary btn-block""><i class=""fas fa-plus-circle""></i> Add to Wishlist</button>
                        <button class=""btn btn-success btn-block""><i class=""fas fa-cart-plus""></i> Add to Cart</button>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 59 "C:\Users\Kristijan\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c68665ad9cb490be4363d223fa5a6145529db52c14137", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
