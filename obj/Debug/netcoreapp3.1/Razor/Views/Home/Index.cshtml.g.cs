#pragma checksum "D:\Ders\websitesi\app\Invites\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dba05a921963d0f69ce2485d61c7dba15850c6b1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dba05a921963d0f69ce2485d61c7dba15850c6b1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7a259bdcfe8a3ab85fd12fae1bbeaca619aa04", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RsvpForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""text-center"">
    <h3> Hoşgeldiniz !</h3>
    <h4>Yeni projemiz için çalışma arkadaşları arıyoruz ! Projemiz için çalışacak arkadaşlarımızda aradığımız özellikleri aşağıda belirttik.. Sizde bizimle çalışmak isterseniz lütfen formu doldurunuz</h4>
    
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dba05a921963d0f69ce2485d61c7dba15850c6b13965", async() => {
                WriteLiteral("Başvuru Formu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <style>
       p,h1,h2, h3, h4, ul, li, a
        {
           color:white;
            font-family: 'Century Gothic'
        }
       
    </style>





    <div class=""section"">

        <div class=""container"">

            <div class=""row"">
                <div class=""col-md-4 col-sm-4"">
                    <div class=""block-icon"">
                        <i class=""fa fa-rocket""></i>
                    </div>

                    <div class=""block-body"">
                        <h2 style=""font-family:'Century Gothic';"">Analitik düşünebilen ve çabuk karar verebilen</h2>
                        <div class=""line-subtitle""></div>
                        <p></p>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-4"">
                    <div class=""block-icon"">
                        <i class=""fa fa-users""></i>
                    </div>

                    <div class=""block-body"">
                        <h2 style=""font-family:'Century Gothic';"">Ekip çalı");
            WriteLiteral(@"şmasına uygun ve deneyimli</h2>
                        <div class=""line-subtitle""></div>
                        <p></p>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-4"">
                    <div class=""block-icon"">
                        <i class=""fa fa-cog""></i>
                    </div>

                    <div class=""block-body"">
                        <h2 style=""font-family:'Century Gothic';"">C# ve Asp.net dillerine hakim olan</h2>
                        <div class=""line-subtitle""></div>
                        <p></p>
                    </div>
                </div>
            </div><!-- /.row -->

        </div><!-- /.container -->

    </div><!-- /.section -->

    <div class=""section-colored home"">

        <div class=""container"">

            <div class=""row"">
                <div class=""col-md-9 col-sm-8"">
                    <h2>Bizimle İletişime Geçin</h2>
                </div>
                <div class=""col-md-3 col-sm-4"">
               ");
            WriteLiteral("     <a href=\"/Home/İletisim\" class=\"btn btn-danger btn-lg\">İletişim</a>\n                </div>\n            </div><!-- /.row -->\n\n        </div><!-- /.container -->\n\n    </div><!-- /.section-colored -->\n\n   <br />\n   <br /><br />\n</div>\n");
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
