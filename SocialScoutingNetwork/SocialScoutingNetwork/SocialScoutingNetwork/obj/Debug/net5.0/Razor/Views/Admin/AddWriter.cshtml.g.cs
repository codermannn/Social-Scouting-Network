#pragma checksum "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a60dad84bd1786571d52e7f9443353055cac7d37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddWriter), @"mvc.1.0.view", @"/Views/Admin/AddWriter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60dad84bd1786571d52e7f9443353055cac7d37", @"/Views/Admin/AddWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f018920ef40d6f4c703f47d34ddff9d290e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddWriter.cshtml"
  
    ViewData["Title"] = "AddWriter";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"ibox \">\r\n            <div class=\"ibox-title\">\r\n                <h5>Yazar Ekleme </h5>\r\n            </div>\r\n            <div class=\"ibox-content\">\r\n");
#nullable restore
#line 14 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddWriter.cshtml"
                 using (Html.BeginForm("AddWriter", "Admin", FormMethod.Post, new { @class = "", enctype = "multipart/form-data" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Kullanıcı Adı</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterUserName"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Adı</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterName"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Soyadı</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterSurname"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div clas");
            WriteLiteral(@"s=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Resim</label>

                        <div class=""col-sm-3""><input type=""file"" name=""WriterImage"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Mail</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterMail"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Şifre</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterPassword"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                 ");
            WriteLiteral(@"       <label class=""col-sm-2 col-form-label"">Hakkında</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterAbout"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Ünvan</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterTitle"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Doğum Tarihi</label>

                        <div class=""col-sm-3""><input type=""datetime"" name=""WriterBirthDate"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""c");
            WriteLiteral(@"ol-sm-2 col-form-label"">Adres</label>

                        <div class=""col-sm-3""><input type=""text"" name=""WriterAddress"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Ülke</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 79 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddWriter.cshtml"
                                         Write(Html.DropDownListFor(x => x.CountryID, (List<SelectListItem>)ViewBag.country, new { @class = "form-control m-b", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group row"">
                        <div class=""col-sm-4 col-sm-offset-2"">
                            <button class=""btn btn-primary btn-sm"" type=""submit"">Yazar Ekle</button>
                        </div>
                    </div>
");
#nullable restore
#line 87 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddWriter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
