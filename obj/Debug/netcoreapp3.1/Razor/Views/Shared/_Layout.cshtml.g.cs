#pragma checksum "D:\Ders\websitesi\app\Invites\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ea6f016768adfebde12bff08af730c5d49f6e3"
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
#line 1 "D:\Ders\websitesi\app\Invites\Views\_ViewImports.cshtml"
using PartyInvites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ders\websitesi\app\Invites\Views\_ViewImports.cshtml"
using PartyInvites.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ea6f016768adfebde12bff08af730c5d49f6e3", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7a259bdcfe8a3ab85fd12fae1bbeaca619aa04", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"tr\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ea6f016768adfebde12bff08af730c5d49f6e34586", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 171, "\"", 181, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 207, "\"", 217, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta http-equiv=""content-type"" content=""text/html;charset=UTF-8"" />

    <title>Düzce Üniversitesi</title>


    

    <link rel=""stylesheet"" href=""/css/bootstrap.css"" />
    <link rel=""stylesheet"" href=""/css/style.css"" />
    <link rel=""stylesheet"" href=""/css/font-awesome.min.css"" />

    <script type=""text/javascript"" src=""js/jquery-1.10.2.js""></script>
    <script type=""text/javascript"" src=""js/bootstrap.js""></script>
    <script type=""text/javascript"" src=""js/plugins.js""></script>
    <!--[if lte IE 7]>
    <script type=""text/javascript"" src=""js/boxsizing/jquery.boxsizing.js""></script>
    <![endif]-->


    <script type=""text/javascript"" src=""js/banzhow.js""></script>
");
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
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ea6f016768adfebde12bff08af730c5d49f6e36757", async() => {
                WriteLiteral(@"
    <style>
  
        p, h1, h2, h3, h4, a {
            color: white;
            font-family: 'Century Gothic'
        }
       

        body {
            background-color:#0D2F4B;
        }

    </style>
    <header>
        <nav class=""navbar navbar-fixed-top navbar-inverse"" role=""navigation"">
            <div class=""container"">
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-ex1-collapse"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>

                    <a class=""navbar-brand"" href=""/home/index"">Düzce Üniversitesi</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class=""collapse navbar-collap");
                WriteLiteral(@"se navbar-ex1-collapse"">
                    <ul class=""nav navbar-nav navbar-right"">
                        <li><a href=""/home/index"">Anasayfa</a></li>
                        <li><a href=""/home/proje"">Projeler</a></li>


                        <li><a href=""/Home/İletisim"">İletişim</a></li>
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"">Öğrenciler<i class=""fa fa-angle-down""></i></a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""/Home/meb"">Muhammed Esad Bacacı</a></li>
                                <li><a href=""/Home/sek"">Şahin Emircan Keleş</a></li>
                                <li><a href=""/Home/mc"">Mehmet Ceydelioğlu</a></li>

                            </ul>
                        </li>






                    </ul>
                </div><!-- /.navbar-collapse -->
            </div><!-- /.container -->
        </nav>
    </header>
    ");
                WriteLiteral("<div class=\"container\">\n        <main role=\"main\" class=\"pb-3\">\n            ");
#nullable restore
#line 90 "D:\Ders\websitesi\app\Invites\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <footer>
        <div class=""container"">

            <div class=""row"">
                <div class=""col-lg-3 col-md-3"">
                    <a class=""footer-brand"" href=""/home/index"">Düzce Üniversitesi</a>
                    <p>Düzce Üniversitesi Web Programlama  Ahmet Albayrak</p>
                    <ul class=""list-inline list-unstyled social-networks"">
                        <li>
                            <a href=""#"">
                                <div class=""icon-social icon-social-facebook normal"">
                                    <i class=""fa fa-facebook""></i>
                                </div>
                                <div class=""icon-social hover"">
                                    <i class=""fa fa-facebook""></i>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a href=""#"">
                                <div class=""icon-social icon-socia");
                WriteLiteral(@"l-twitter normal"">
                                    <i class=""fa fa-twitter""></i>
                                </div>
                                <div class=""icon-social hover"">
                                    <i class=""fa fa-twitter""></i>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a href=""#"">
                                <div class=""icon-social icon-social-google-plus normal"">
                                    <i class=""fa fa-google-plus""></i>
                                </div>
                                <div class=""icon-social hover"">
                                    <i class=""fa fa-google-plus""></i>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a href=""#"">
                                <div class=""icon-social icon-social-youtube normal"">
       ");
                WriteLiteral(@"                             <i class=""fa fa-youtube-play""></i>
                                </div>
                                <div class=""icon-social hover"">
                                    <i class=""fa fa-youtube-play""></i>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a href=""#"">
                                <div class=""icon-social icon-social-linkedin normal"">
                                    <i class=""fa fa-linkedin""></i>
                                </div>
                                <div class=""icon-social hover"">
                                    <i class=""fa fa-linkedin""></i>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a href=""#"">
                                <div class=""icon-social icon-social-pinterest normal"">
                              ");
                WriteLiteral(@"      <i class=""fa fa-pinterest""></i>
                                </div>
                                <div class=""icon-social hover"">
                                    <i class=""fa fa-pinterest""></i>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-3 col-md-3"">
                    <h3>İletişim</h3>
                    <address>
                        <i class=""fa fa-map-marker""></i> Düzce<br>
                        <i class=""fa fa-phone""></i>+90-000-000-0000<br>
                        <i class=""fa fa-envelope""></i> duzce.edu.tr
                    </address>
                </div>

                <div class=""col-lg-3 col-md-3"">
                    <h3>Son Tweetler</h3>
                    <ul class=""latest-tweets"">
                        <li>
                            <i class=""fa fa-twitter""></i> Atılan tweetler yakında
                        </li>

       ");
                WriteLiteral(@"             </ul>
                </div>

                <div class=""col-lg-3 col-md-3"">
                    <h3>E-posta gönder</h3>
                    <p>Bize Ulaşın</p>
                    <div class=""input-group"">
                        <input type=""text"" placeholder=""Email"" class=""form-control"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-primary"" type=""button"">Gönder!</button>
                        </span>
                    </div><!-- /input-group -->
                </div>
            </div><!-- /.row -->

        </div><!-- /.container -->
    </footer>

    <div class=""footer-after"">
        <div class=""container"">
            <div class=""row"">
                <p class=""col-md-10"">©2021 Tüm Hakları Saklıdır.</p>

            </div><!-- /.row -->
        </div>
    </div>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ea6f016768adfebde12bff08af730c5d49f6e314691", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ea6f016768adfebde12bff08af730c5d49f6e315789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ea6f016768adfebde12bff08af730c5d49f6e316887", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 213 "D:\Ders\websitesi\app\Invites\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
#nullable restore
#line 214 "D:\Ders\websitesi\app\Invites\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
