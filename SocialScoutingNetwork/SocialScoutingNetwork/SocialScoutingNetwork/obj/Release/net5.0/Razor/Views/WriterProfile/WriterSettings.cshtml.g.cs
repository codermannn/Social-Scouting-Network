#pragma checksum "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f9c4c5e3e46a2948d9b28e148704eec6d2015a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WriterProfile_WriterSettings), @"mvc.1.0.view", @"/Views/WriterProfile/WriterSettings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f9c4c5e3e46a2948d9b28e148704eec6d2015a", @"/Views/WriterProfile/WriterSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f018920ef40d6f4c703f47d34ddff9d290e662", @"/Views/_ViewImports.cshtml")]
    public class Views_WriterProfile_WriterSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
  
    ViewData["Title"] = "WriterSettings";
    Layout = "~/Views/Shared/UserLeftLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"section profile\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xl-4\">\r\n\r\n            <div class=\"card\">\r\n                <div class=\"card-body profile-card pt-4 d-flex flex-column align-items-center\">\r\n\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 389, "\"", 424, 2);
            WriteAttributeValue("", 395, "/WriterImageFiles/", 395, 18, true);
#nullable restore
#line 14 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 413, ViewBag.pp, 413, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Profile\"");
            BeginWriteAttribute("class", " class=\"", 439, "\"", 447, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2>");
#nullable restore
#line 15 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                   Write(ViewBag.n);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                              Write(ViewBag.s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3>");
#nullable restore
#line 16 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                   Write(ViewBag.tt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
            </div>

        </div>

        <div class=""col-xl-8"">

            <div class=""card"">
                <div class=""card-body pt-3"">
                    <!-- Bordered Tabs -->
                    <ul class=""nav nav-tabs nav-tabs-bordered"">

                        <li class=""nav-item"">
                            <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#profile-overview"">Genel</button>
                        </li>

                        <li class=""nav-item"">
                            <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-edit"">Profili Düzenle</button>
                        </li>

                    </ul>
                    <div class=""tab-content pt-2"">

                        <div class=""tab-pane fade show active profile-overview"" id=""profile-overview"">
                            <h5 class=""card-title"">Hakkında</h5>
                            <p class=""small fst-italic"">");
#nullable restore
#line 42 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                   Write(ViewBag.ab);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                            <h5 class=""card-title"">Profil Detayları</h5>

                            <div class=""row"">
                                <label class=""col-md-4 col-lg-3 alert-heading"">Adı Soyadı</label>
                                <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 48 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                          Write(ViewBag.n);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                                     Write(ViewBag.s);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>

                            <div class=""row"">
                                <label class=""col-md-4 col-lg-3 alert-heading"">Kullanıcı Adı</label>
                                <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 53 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                          Write(ViewBag.un);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <label class=\"col-md-4 col-lg-3 alert-heading\">Ünvan</label>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 58 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                          Write(ViewBag.tt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <label class=\"col-md-4 col-lg-3 alert-heading\">Ülke</label>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 63 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                          Write(ViewBag.ct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <label class=\"col-md-4 col-lg-3 alert-heading\">Adres</label>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 68 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                          Write(ViewBag.ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>

                            <div class=""row"">
                                <label class=""col-md-4 col-lg-3 alert-heading"">Doğum Tarihi</label>
                                <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 73 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                          Write(ViewBag.dt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>

                            <div class=""row"">
                                <label class=""col-md-4 col-lg-3 alert-heading"">E-Mail adresi</label>
                                <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 78 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                          Write(ViewBag.ml);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                        <div class=\"tab-pane fade profile-edit pt-3\" id=\"profile-edit\">\r\n\r\n                            <!-- Profile Edit Form -->\r\n");
#nullable restore
#line 86 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                             using (Html.BeginForm("WriterSettings", "WriterProfile", FormMethod.Post, new { @class = "row g-3", enctype = "multipart/form-data" }))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                           Write(Html.HiddenFor(x => x.WriterID, new { @class = "form-control", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <label for=""profileImage"" class=""col-md-4 col-lg-3 col-form-label"">Profil Resmi</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 4320, "\"", 4355, 2);
            WriteAttributeValue("", 4326, "/WriterImageFiles/", 4326, 18, true);
#nullable restore
#line 92 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 4344, ViewBag.pp, 4344, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Profile\">\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Adı</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterName"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4778, "\"", 4796, 1);
#nullable restore
#line 99 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 4786, ViewBag.n, 4786, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Soyadı</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterSurname"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5209, "\"", 5227, 1);
#nullable restore
#line 105 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 5217, ViewBag.s, 5217, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Kullanıcı Adı</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterUserName"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5648, "\"", 5667, 1);
#nullable restore
#line 111 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 5656, ViewBag.un, 5656, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Hakkında</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <textarea name=""WriterAbout"" class=""form-control"" style=""height: 100px"">");
#nullable restore
#line 117 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                                                                                           Write(ViewBag.ab);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Ünvan</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterTitle"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 6526, "\"", 6545, 1);
#nullable restore
#line 124 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 6534, ViewBag.tt, 6534, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">E-mail</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterMail"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 6957, "\"", 6976, 1);
#nullable restore
#line 131 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 6965, ViewBag.ml, 6965, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <label for=""Country"" class=""col-md-4 col-lg-3 col-form-label"">Ülke</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        ");
#nullable restore
#line 138 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                                   Write(Html.DropDownListFor(x => x.CountryID, (List<SelectListItem>)ViewBag.country, new { @class = "form-select", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Adres</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterAddress"" type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 7893, "\"", 7912, 1);
#nullable restore
#line 145 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 7901, ViewBag.ad, 7901, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Doğum Tarihi</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterBirthDate"" type=""datetime"" class=""form-control"" value=""05.05.2022"">
                                    </div>
                                </div>
                                <div class=""row mb-3"">
                                    <label class=""col-md-4 col-lg-3 col-form-label"">Şifre</label>
                                    <div class=""col-md-8 col-lg-9"">
                                        <input name=""WriterPassword"" type=""password"" readonly=""readonly"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 8794, "\"", 8815, 1);
#nullable restore
#line 158 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
WriteAttributeValue("", 8802, ViewBag.pass, 8802, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral("                                <div class=\"text-center\">\r\n                                    <button type=\"submit\" class=\"btn btn-primary\">Değişiklikleri Kaydet</button>\r\n                                </div>\r\n");
#nullable restore
#line 166 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\WriterProfile\WriterSettings.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- End Profile Edit Form -->\r\n\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                    </div><!-- End Bordered Tabs -->\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
