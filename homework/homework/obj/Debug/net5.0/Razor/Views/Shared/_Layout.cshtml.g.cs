#pragma checksum "C:\Users\user\Desktop\Code\hw\asp.net\homework\homework\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ce06f2a1318bdec872e659483c35f0708e5471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Code\hw\asp.net\homework\homework\Views\_ViewImports.cshtml"
using homework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Code\hw\asp.net\homework\homework\Views\_ViewImports.cshtml"
using homework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Code\hw\asp.net\homework\homework\Views\_ViewImports.cshtml"
using homework.HomeViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ce06f2a1318bdec872e659483c35f0708e5471", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db553b113b021410c8b735152b2bb225e345585c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#navbar-nav-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("static-layout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<!--\n    Moon by GetTemplates.co\n    URL: https://gettemplates.co\n-->\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8ce06f2a1318bdec872e659483c35f0708e54714600", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Moon - Multipurpose Bootstrap 4 Template by GetTemplates.co</title>
    <meta name=""description"" content=""Core HTML Project"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- External CSS -->
    <link rel=""stylesheet"" href=""vendor/bootstrap/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""vendor/select2/select2.min.css"">
    <link rel=""stylesheet"" href=""vendor/owlcarousel/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""vendor/lightcase/lightcase.css"">

    <!-- Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Lato:300,400|Work+Sans:300,400,700"" rel=""stylesheet"">

    <!-- CSS -->
    <link rel=""stylesheet"" href=""css/style.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.linearicons.com/free/1.0.0/icon-font.min.css"">
    <link href=""https://file.myfontastic.com/7vRKgqrN3iFEnLHuqYhYuL/icons.css"" rel=""stylesheet"">

    <!-- Moder");
                WriteLiteral("nizr JS for IE8 support of HTML5 elements and media queries -->\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.js\"></script>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8ce06f2a1318bdec872e659483c35f0708e54716832", async() => {
                WriteLiteral(@"
    <div class=""boxed-page"">
        <nav id=""gtco-header-navbar"" class=""navbar navbar-expand-lg py-4"">
            <div class=""container"">
                <a class=""navbar-brand d-flex align-items-center"" href=""/"">
                    <span class=""lnr lnr-moon""></span>
                </a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbar-nav-header"" aria-controls=""navbar-nav-header"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""lnr lnr-menu""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbar-nav-header"">
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#home"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#who-we-are"">Profile</a>
                        </li>
              ");
                WriteLiteral(@"          <li class=""nav-item"">
                            <a class=""nav-link"" href=""#blog"">Blog</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#portfolio"">Portfolio</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#pricing"">Pricing</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""contact.html"">Contact</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        ");
#nullable restore
#line 68 "C:\Users\user\Desktop\Code\hw\asp.net\homework\homework\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <footer class=""mastfoot mb-3 bg-white py-4 border-top"">
            <div class=""inner container"">
                <div class=""row"">
                    <div class=""col-md-6 d-flex align-items-center justify-content-md-start justify-content-center"">
                        <p class=""mb-0"">&copy; 2019 Moon. All Right Reserved. Design by <a href=""https://gettemplates.co"" target=""_blank"">GetTemplates.co</a>.</p>
                    </div>

                    <div class=""col-md-6"">
                        <nav class=""nav nav-mastfoot justify-content-md-end justify-content-center"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""icon-facebook""></i>
                            </a>
                            <a class=""nav-link"" href=""#"">
                                <i class=""icon-twitter""></i>
                            </a>
                            <a class=""nav-link"" href=""#"">
                                <i class=""icon-instagram""></i>
    ");
                WriteLiteral(@"                        </a>
                            <a class=""nav-link"" href=""#"">
                                <i class=""icon-linkedin""></i>
                            </a>
                            <a class=""nav-link"" href=""#"">
                                <i class=""icon-youtube""></i>
                            </a>
                            <a class=""nav-link"" href=""#"">
                                <i class=""icon-pinterest""></i>
                            </a>
                        </nav>
                    </div>

                </div>
            </div>
        </footer>
    </div>

    </div>
    <!-- External JS -->
    <script type=""text/javascript"" src=""http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.js""></script>
    <script src=""vendor/bootstrap/popper.min.js""></script>
    <script src=""vendor/bootstrap/bootstrap.min.js""></script>
    <script src=""vendor/select2/select2.min.js ""></script>
    <script src=""vendor/owlcarousel/owl.carousel.min.js""></script>
    <script src");
                WriteLiteral(@"=""vendor/isotope/isotope.min.js""></script>
    <script src=""vendor/lightcase/lightcase.js""></script>
    <script src=""vendor/waypoints/waypoint.min.js""></script>
    <script src=""vendor/countTo/jquery.countTo.js""></script>

    <!-- Main JS -->
    <script src=""js/app.min.js ""></script>
    <script src=""//localhost:35729/livereload.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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