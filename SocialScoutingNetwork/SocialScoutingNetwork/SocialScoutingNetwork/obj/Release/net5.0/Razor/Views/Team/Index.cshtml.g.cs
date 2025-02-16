#pragma checksum "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2546c97ba5130da0a3f48d98360433ba0338a108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 1 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\_ViewImports.cshtml"
using SocialScoutingNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\_ViewImports.cshtml"
using SocialScoutingNetwork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2546c97ba5130da0a3f48d98360433ba0338a108", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f018920ef40d6f4c703f47d34ddff9d290e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLeftLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-xxl-3 col-md-6"">
        <div class=""card info-card sales-card"">

            <div class=""filter"">
                <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                    <li class=""dropdown-header text-start"">
                        <h6>Seçenekler</h6>
                    </li>
                    <li><a class=""dropdown-item"" href=""/Player/PlayerDetails//"">Detaylar</a></li>
                </ul>
            </div>

            <div class=""card-body"">
                <h5 class=""card-title"">Kuruluş : ");
#nullable restore
#line 23 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
                                            Write(item.TeamFoundationYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>| Futbolcu sayısı : ");
#nullable restore
#line 23 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
                                                                                               Write(item.TeamPlayerCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>

                <div class=""d-flex align-items-center"">
                    <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                        <i class=""ri-shield-fill""></i>
                    </div>
                    <div class=""ps-3"">
                        <h6>");
#nullable restore
#line 30 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
                       Write(item.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <span class=\"text-success small pt-1 fw-bold\">");
#nullable restore
#line 31 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
                                                                 Write(item.Country.CountryISO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"text-muted small pt-2 ps-1\">");
#nullable restore
#line 31 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
                                                                                                                                          Write(item.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Team\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
