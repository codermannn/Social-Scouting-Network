#pragma checksum "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d55f2f38dd161ee6f296159129fdba966fa5ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdatePlayer), @"mvc.1.0.view", @"/Views/Admin/UpdatePlayer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d55f2f38dd161ee6f296159129fdba966fa5ff", @"/Views/Admin/UpdatePlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f018920ef40d6f4c703f47d34ddff9d290e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdatePlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Player>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
  
    ViewData["Title"] = "UpdatePlayer";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"ibox \">\r\n            <div class=\"ibox-title\">\r\n                <h5>Futbolcu Güncelleme </h5>\r\n            </div>\r\n            <div class=\"ibox-content\">\r\n");
#nullable restore
#line 14 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                 using (Html.BeginForm("UpdatePlayer", "Admin", FormMethod.Post, new { @class = "", enctype = "multipart/form-data" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
               Write(Html.HiddenFor(x => x.PlayerID, new { @class = "form-control", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group  row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Adı</label>\r\n\r\n                        <div class=\"col-sm-3\">");
#nullable restore
#line 20 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerName, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Soyadı</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 26 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerSurname, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Yaş</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 32 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerAge, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Boy</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 38 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerHeight, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Kilo</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 44 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerWeight, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Pozisyon ISO</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 50 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerPositionISO, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Pozisyon</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 56 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerPosition, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Açıklama</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 62 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerDescription, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Kulüp</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 68 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerClub, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Doğum Tarihi</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 74 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerBirthDate, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Menajer</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 80 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerManager, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Değer</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 86 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerValue, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Numara</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 92 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.TextBoxFor(x => x.PlayerNumber, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Ülke</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 98 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.DropDownListFor(x => x.CountryID, (List<SelectListItem>)ViewBag.country, new { @class = "form-control m-b", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Takım</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 104 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.DropDownListFor(x => x.TeamID, (List<SelectListItem>)ViewBag.team, new { @class = "form-control m-b", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Lig</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 110 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.DropDownListFor(x => x.LeagueID, (List<SelectListItem>)ViewBag.league, new { @class = "form-control m-b", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Yetenek</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 116 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                                         Write(Html.DropDownListFor(x => x.SkillID, (List<SelectListItem>)ViewBag.skill, new { @class = "form-control m-b", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"hr-line-dashed\"></div>\r\n");
            WriteLiteral(@"                    <div class=""form-group row"">
                        <div class=""col-sm-4 col-sm-offset-2"">
                            <button class=""btn btn-primary btn-sm"" type=""submit"">Oyuncuyu Güncelle</button>
                        </div>
                    </div>
");
#nullable restore
#line 126 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdatePlayer.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Player> Html { get; private set; }
    }
}
#pragma warning restore 1591
