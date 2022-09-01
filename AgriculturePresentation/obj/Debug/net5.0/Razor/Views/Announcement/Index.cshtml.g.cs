#pragma checksum "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ccaabbb472d967672ecd2f42b7c2336d3dff866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Announcement_Index), @"mvc.1.0.view", @"/Views/Announcement/Index.cshtml")]
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
#line 1 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ccaabbb472d967672ecd2f42b7c2336d3dff866", @"/Views/Announcement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa27564c578f8bd032750b8d5a0983009bfabfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
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
#nullable restore
#line 3 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout_.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Duyurular Listesi</h1>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccaabbb472d967672ecd2f42b7c2336d3dff8663931", async() => {
                WriteLiteral("\r\n    <style>\r\n        th {\r\n            text-align: center;\r\n        }\r\n\r\n        td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n    <title></title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccaabbb472d967672ecd2f42b7c2336d3dff8665083", async() => {
                WriteLiteral(@"
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Başlık</th>
                <th>Açıklama</th>
                <th>Tarih</th>
                <th>Durum</th>
                <th>Durum değiştir</th>
                <th colspan=""2"">Araçlar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 37 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                   Write(item.AnnouncementID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                    Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                   Write(Html.Raw(item.Status == true ? "<span class='badge bg-success' >Aktif</span>" : "<span class='badge bg-danger' >Pasif</span>"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                     if (item.Status == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td><a class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 1376, "\"", 1437, 2);
                WriteAttributeValue("", 1383, "/Announcement/ChangeStatusToFalse/", 1383, 34, true);
#nullable restore
#line 47 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 1417, item.AnnouncementID, 1417, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Pasif Yap</a></td>\r\n");
#nullable restore
#line 48 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td><a class=\"btn btn-success\"");
                BeginWriteAttribute("href", " href=\"", 1585, "\"", 1645, 2);
                WriteAttributeValue("", 1592, "/Announcement/ChangeStatusToTrue/", 1592, 33, true);
#nullable restore
#line 51 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 1625, item.AnnouncementID, 1625, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Aktif Yap</a></td>\r\n");
#nullable restore
#line 52 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td><a id=\"DeleteBtn\" onclick=\"return confirm(\'Silme işlemini yapmak istediğinize emin misiniz\')\" class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 1830, "\"", 1890, 2);
                WriteAttributeValue("", 1837, "/Announcement/DeleteAnnouncement/", 1837, 33, true);
#nullable restore
#line 53 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 1870, item.AnnouncementID, 1870, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sil</a></td>\r\n                    <td><a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 1956, "\"", 2016, 2);
                WriteAttributeValue("", 1963, "/Announcement/UpdateAnnouncement/", 1963, 33, true);
#nullable restore
#line 54 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 1996, item.AnnouncementID, 1996, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Güncelle</a></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\emir_\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Announcement\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/Announcement/AddAnnouncement\" class=\"btn btn-info\">Yeni Duyuru Ekle</a>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
