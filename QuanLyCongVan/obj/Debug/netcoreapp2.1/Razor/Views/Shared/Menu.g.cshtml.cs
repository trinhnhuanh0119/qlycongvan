#pragma checksum "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39090c08e57b3e1bb4211c618c14243a596254dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Menu), @"mvc.1.0.view", @"/Views/Shared/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Menu.cshtml", typeof(AspNetCore.Views_Shared_Menu))]
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
#line 1 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
using QuanLyCongVan.Model.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
using QuanLyCongVan.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39090c08e57b3e1bb4211c618c14243a596254dc", @"/Views/Shared/Menu.cshtml")]
    public class Views_Shared_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
  
    HomeController controller = new HomeController();

    ViewBag.Menu = controller.GetMenu();

#line default
#line hidden
            BeginContext(177, 1199, true);
            WriteLiteral(@"
<div id=""sidebar"" class=""sidebar responsive ace-save-state"">
    <script type=""text/javascript"">
        try { ace.settings.loadState('sidebar') } catch (e) { }
    </script>
    <div class=""sidebar-shortcuts"" id=""sidebar-shortcuts"">
        <div class=""sidebar-shortcuts-large"" id=""sidebar-shortcuts-large"">
            <button class=""btn btn-success"">
                <i class=""ace-icon fa fa-signal""></i>
            </button>

            <button class=""btn btn-info"">
                <i class=""ace-icon fa fa-pencil""></i>
            </button>

            <button class=""btn btn-warning"">
                <i class=""ace-icon fa fa-users""></i>
            </button>

            <button class=""btn btn-danger"">
                <i class=""ace-icon fa fa-cogs""></i>
            </button>
        </div>

        <div class=""sidebar-shortcuts-mini"" id=""sidebar-shortcuts-mini"">
            <span class=""btn btn-success""></span>

            <span class=""btn btn-info""></span>

            <span");
            WriteLiteral(" class=\"btn btn-warning\"></span>\r\n\r\n            <span class=\"btn btn-danger\"></span>\r\n        </div>\r\n    </div><!-- /.sidebar-shortcuts -->\r\n\r\n    <ul class=\"nav nav-list\">\r\n");
            EndContext();
#line 46 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
         foreach (var item in ViewBag.Menu)
        {
            if (item.SubMenu.Count == 0)
            {

#line default
#line hidden
            BeginContext(1507, 44, true);
            WriteLiteral("                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1551, "\"", 1572, 1);
#line 51 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
WriteAttributeValue("", 1558, item.LinkView, 1558, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1573, 53, true);
            WriteLiteral(" class=\"dropdown-toggle\">\r\n                        <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1626, "\"", 1643, 1);
#line 52 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
WriteAttributeValue("", 1634, item.CSS, 1634, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1644, 55, true);
            WriteLiteral("></i>\r\n                        <span class=\"menu-text\">");
            EndContext();
            BeginContext(1700, 9, false);
#line 53 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1709, 101, true);
            WriteLiteral("</span>\r\n                    </a>\r\n                    <b class=\"arrow\"></b>\r\n                </li>\r\n");
            EndContext();
#line 57 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1858, 44, true);
            WriteLiteral("                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1923, 1);
#line 61 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
WriteAttributeValue("", 1909, item.LinkView, 1909, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1924, 27, true);
            WriteLiteral(" class=\"dropdown-toggle\">\r\n");
            EndContext();
            BeginContext(2004, 28, true);
            WriteLiteral("\r\n                        <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2032, "\"", 2049, 1);
#line 64 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
WriteAttributeValue("", 2040, item.CSS, 2040, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2050, 85, true);
            WriteLiteral("></i>\r\n                        <span class=\"menu-text\">\r\n                            ");
            EndContext();
            BeginContext(2136, 9, false);
#line 66 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2145, 219, true);
            WriteLiteral("\r\n                        </span>\r\n                        <b class=\"arrow fa fa-angle-down\"></b>\r\n                    </a>\r\n                    <b class=\"arrow\"></b>\r\n                    <ul class=\"submenu nav-show\">\r\n");
            EndContext();
#line 72 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
                         foreach (var sub in item.SubMenu)
                        {

#line default
#line hidden
            BeginContext(2451, 77, true);
            WriteLiteral("                            <li class=\"\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2528, "\"", 2548, 1);
#line 75 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
WriteAttributeValue("", 2535, sub.LinkView, 2535, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2549, 120, true);
            WriteLiteral(">\r\n                                    <i class=\"menu-icon fa fa-caret-right\"></i>\r\n                                    ");
            EndContext();
            BeginContext(2670, 8, false);
#line 77 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
                               Write(sub.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2678, 130, true);
            WriteLiteral("\r\n                                </a>\r\n                                <b class=\"arrow\"></b>\r\n                            </li>\r\n");
            EndContext();
#line 81 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
                        }

#line default
#line hidden
            BeginContext(2835, 50, true);
            WriteLiteral("                    </ul>\r\n                </li>\r\n");
            EndContext();
#line 84 "C:\Users\Admin\Videos\qlycongvan-master\QuanLyCongVan\Views\Shared\Menu.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2911, 316, true);
            WriteLiteral(@"    </ul><!-- /.nav-list -->

    <div class=""sidebar-toggle sidebar-collapse"" id=""sidebar-collapse"">
        <i id=""sidebar-toggle-icon"" class=""ace-icon fa fa-angle-double-left ace-save-state"" data-icon1=""ace-icon fa fa-angle-double-left"" data-icon2=""ace-icon fa fa-angle-double-right""></i>
    </div>
</div>
");
            EndContext();
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