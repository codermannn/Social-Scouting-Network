#pragma checksum "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9ae8aa49431d17ecceb5f70e9f636f2188f9ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetMostValuablePlayer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GetMostValuablePlayer/Default.cshtml")]
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
#line 1 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9ae8aa49431d17ecceb5f70e9f636f2188f9ff", @"/Views/Shared/Components/GetMostValuablePlayer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f018920ef40d6f4c703f47d34ddff9d290e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetMostValuablePlayer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Player>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card info-card sales-card\">\r\n\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">En Değerli 3 Futbolcu </h5>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
                              Write(item.PlayerNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>| ");
#nullable restore
#line 12 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
                                                         Write(item.Team.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n");
            WriteLiteral(@"            <div class=""d-flex align-items-center"">
                <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                    <i class=""ri-account-circle-fill""></i>
                </div>
                <div class=""ps-3"">
                    <h6>");
#nullable restore
#line 19 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
                   Write(item.PlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
                                    Write(item.PlayerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <span class=\"text-success small pt-1 fw-bold\">");
#nullable restore
#line 20 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
                                                             Write(item.PlayerPositionISO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"text-muted small pt-2 ps-1\">");
#nullable restore
#line 20 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"
                                                                                                                                     Write(item.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Shared\Components\GetMostValuablePlayer\Default.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
