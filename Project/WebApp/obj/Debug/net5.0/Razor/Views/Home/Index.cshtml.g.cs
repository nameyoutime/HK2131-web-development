#pragma checksum "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7459b5bfc324b5288ecedbaebc90f1eeb7e210a"
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
#line 1 "C:\Users\ad\source\repos\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ad\source\repos\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7459b5bfc324b5288ecedbaebc90f1eeb7e210a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05cdf03120ef912da27fb9da8fdea59019dd5a81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addcart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"col-md-9\" style=\"text-align:center;\">\r\n    <h1>Welcome to the home page</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
      

        var temp = "Dien thoai Samsung moi nhat";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <ol class=\"breadcrumb\">\r\n            <li><a href=\"#\">Home</a></li>\r\n            <li class=\"active\">");
#nullable restore
#line 36 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                           Write(temp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
        </ol>
    </div>
    <!-- /.div -->
    <div class=""row"">
        <div class=""btn-group alg-right-pad"">
            <button type=""button"" class=""btn btn-default""><strong>1235 </strong>items</button>
            <div class=""btn-group"">
                <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"">
                    Sort Products &nbsp;
                    <span class=""caret""></span>
                </button>
                <ul class=""dropdown-menu"">
                    <li><a href=""#"">By Price Low</a></li>
                    <li class=""divider""></li>
                    <li><a href=""#"">By Price High</a></li>
                    <li class=""divider""></li>
                    <li><a href=""#"">By Popularity</a></li>
                    <li class=""divider""></li>
                    <li><a href=""#"">By Reviews</a></li>
                </ul>
            </div>
        </div>
    </div>
    <!-- /.row -->
    <div class=""row"">
        <!--");
            WriteLiteral(" /.col -->\r\n");
#nullable restore
#line 63 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {
            if (Model[i].CategoryId == 4)
            {
                temp = Model[i].Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 text-center col-sm-6 col-xs-6\">\r\n                    <div class=\"thumbnail product-box\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2347, "\"", 2384, 1);
#nullable restore
#line 70 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2353, Url.Content(Model[i].ImageUrl), 2353, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 2385, "", 2408, 1);
#nullable restore
#line 70 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2390, Model[i].ImageUrl, 2390, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"caption\">\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 72 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                       Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>Price : <strong>$");
#nullable restore
#line 73 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                           Write(Model[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </p>\r\n                            <p><a href=\"#\">Amount: ");
#nullable restore
#line 74 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                              Write(Model[i].Quality);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></p>\r\n                            <p>Description: ");
#nullable restore
#line 75 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                       Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <p>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7459b5bfc324b5288ecedbaebc90f1eeb7e210a9761", async() => {
                WriteLiteral("Add To Cart");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                                                                WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7459b5bfc324b5288ecedbaebc90f1eeb7e210a12340", async() => {
                WriteLiteral("See Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 83 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 92 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
       
        var temp2= "Dien thoai oppo";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <ol class=\"breadcrumb\">\r\n            <li><a href=\"#\">Home</a></li>\r\n            <li class=\"active\">");
#nullable restore
#line 97 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                           Write(temp2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" moi nhat</li>
        </ol>
    </div>
    <!-- /.div -->
    <div class=""row"">
        <div class=""btn-group alg-right-pad"">
            <button type=""button"" class=""btn btn-default""><strong>1235 </strong>items</button>
            <div class=""btn-group"">
                <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"">
                    Sort Products &nbsp;
                    <span class=""caret""></span>
                </button>
                <ul class=""dropdown-menu"">
                    <li><a href=""#"">By Price Low</a></li>
                    <li class=""divider""></li>
                    <li><a href=""#"">By Price High</a></li>
                    <li class=""divider""></li>
                    <li><a href=""#"">By Popularity</a></li>
                    <li class=""divider""></li>
                    <li><a href=""#"">By Reviews</a></li>
                </ul>
            </div>
        </div>
    </div>
    <!-- /.row -->
    <div class=""row"">
   ");
            WriteLiteral("     <!-- /.col -->\r\n");
#nullable restore
#line 124 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

                temp2 = Model[i].Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 text-center col-sm-6 col-xs-6\">\r\n                    <div class=\"thumbnail product-box\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4764, "\"", 4801, 1);
#nullable restore
#line 130 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4770, Url.Content(Model[i].ImageUrl), 4770, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 4802, "", 4825, 1);
#nullable restore
#line 130 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4807, Model[i].ImageUrl, 4807, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"caption\">\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 132 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                       Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>Price : <strong>$");
#nullable restore
#line 133 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                           Write(Model[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </p>\r\n                            <p><a href=\"#\">Amount: ");
#nullable restore
#line 134 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                              Write(Model[i].Quality);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></p>\r\n                            <p>Description: ");
#nullable restore
#line 135 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                       Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <p>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7459b5bfc324b5288ecedbaebc90f1eeb7e210a19360", async() => {
                WriteLiteral("Add To Cart");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                                                                WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7459b5bfc324b5288ecedbaebc90f1eeb7e210a21941", async() => {
                WriteLiteral("See Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 143 "C:\Users\ad\source\repos\WebApp\Views\Home\Index.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591