#pragma checksum "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9999874bca1c102e8018a088a5ad36aa476d8b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddAdmin), @"mvc.1.0.view", @"/Views/Admin/AddAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9999874bca1c102e8018a088a5ad36aa476d8b3a", @"/Views/Admin/AddAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f018920ef40d6f4c703f47d34ddff9d290e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "B", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "C", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddAdmin.cshtml"
  
    ViewData["Title"] = "AddAdmin";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"ibox \">\r\n            <div class=\"ibox-title\">\r\n                <h5>Admin Ekleme </h5>\r\n            </div>\r\n            <div class=\"ibox-content\">\r\n");
#nullable restore
#line 14 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddAdmin.cshtml"
                 using (Html.BeginForm("AddAdmin", "Admin", FormMethod.Post, new { @class = "", enctype = "multipart/form-data" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Admin Kullanıcı Adı</label>

                        <div class=""col-sm-3""><input type=""text"" name=""AdminUserName"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Admin Şfiresi</label>

                        <div class=""col-sm-3""><input type=""password"" name=""AdminPassword"" class=""form-control""></div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Admin Rolü</label>

                        <div class=""col-sm-3"">
                            <select name=""AdminRole"" class=""form-control m-b"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9999874bca1c102e8018a088a5ad36aa476d8b3a6030", async() => {
                WriteLiteral("A");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9999874bca1c102e8018a088a5ad36aa476d8b3a7216", async() => {
                WriteLiteral("B");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9999874bca1c102e8018a088a5ad36aa476d8b3a8402", async() => {
                WriteLiteral("C");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-sm-4 col-sm-offset-2"">
                            <button class=""btn btn-primary btn-sm"" type=""submit"">Admin Ekle</button>
                        </div>
                    </div>
");
#nullable restore
#line 44 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\AddAdmin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
