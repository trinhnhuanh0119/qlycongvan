#pragma checksum "E:\Github\QuanLyCongVan\qlycongvan\QuanLyCongVan\Views\NguoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c7885567280236958fa259abc2956c2d9f746c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NguoiDung_Index), @"mvc.1.0.view", @"/Views/NguoiDung/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NguoiDung/Index.cshtml", typeof(AspNetCore.Views_NguoiDung_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7885567280236958fa259abc2956c2d9f746c6", @"/Views/NguoiDung/Index.cshtml")]
    public class Views_NguoiDung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ScriptController/NguoiDungScriptController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Github\QuanLyCongVan\qlycongvan\QuanLyCongVan\Views\NguoiDung\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20565b608ca4721b1fd33456389d697", async() => {
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
            EndContext();
            BeginContext(154, 3327, true);
            WriteLiteral(@"
<div class=""main-container ace-save-state"" id=""main-container"" ng-controller=""NguoiDungJS"">

    <div class=""main-content"">
        <div class=""main-content-inner"">
            <div class=""breadcrumbs ace-save-state"" id=""breadcrumbs"">
                <ul class=""breadcrumb"">
                    <li>
                        <i class=""ace-icon fa fa-home home-icon""></i>
                        <a href=""/Home/Index"">Trang chủ</a>
                    </li>

                    <li>
                        <a href=""#"">Trang hiện tại</a>
                    </li>
                    <li class=""active"">Thêm mới người dùng</li>
                </ul><!-- /.breadcrumb -->

                <div class=""nav-search"" id=""nav-search"">
                    <form class=""form-search"">
                        <span class=""input-icon"">
                            <input type=""text"" placeholder=""Search ..."" class=""nav-search-input"" id=""nav-search-input"" autocomplete=""off"" />
                            <i clas");
            WriteLiteral(@"s=""ace-icon fa fa-search nav-search-icon""></i>
                        </span>
                    </form>
                </div><!-- /.nav-search -->
            </div>

            <div class=""page-content"">
                <div class=""ace-settings-container"" id=""ace-settings-container"">
                    <div class=""btn btn-app btn-xs btn-warning ace-settings-btn"" id=""ace-settings-btn"">
                        <i class=""ace-icon fa fa-cog bigger-130""></i>
                    </div>
                    <button class=""btn btn-sm btn-success"" ng-click=""show()"">Thêm mới</button>         
                    <!-- /.ace-settings-box -->
                </div><!-- /.ace-settings-container -->

                <div class=""page-header"">
                    <h1>
                        Danh sách người dùng
                    </h1>
                </div><!-- /.page-header -->

                <div class=""row"">
                    <div class=""col-xs-12"">
                        <!-- PAGE CONT");
            WriteLiteral(@"ENT BEGINS -->
                        <table class=""table table-responsive table-bordered"" id=""grid-table"">
                            <tr>
                                <th>Tên tài khoản</th>
                                <th>Mật khẩu</th>
                                <th>Kích hoạt</th>
                                <th>Mã nhân sự</th>
                                <th>Thao tác</th>
                            </tr>
                            <tr ng-repeat=""sp in datagrid"">
                                <td>{{sp.tenTaiKhoan}} </td>
                                <td>{{sp.matKhau}} </td>
                                <td>{{sp.kichHoat}} </td>
                                <td>{{sp.maNhanSu}} </td>
                                <td>
                                    <a class=""btn btn-primary btn-sm"" ng-click=""onEdit(sp.id)""><i class=""fa fa-edit""></i></a>
                                </td>
                            </tr>
                        </table>

       ");
            WriteLiteral("                 <div id=\"grid-pager\"></div>\r\n\r\n                        <!-- PAGE CONTENT ENDS -->\r\n                    </div><!-- /.col -->\r\n                </div><!-- /.row -->\r\n            </div><!-- /.page-content -->\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(3504, 2691, true);
            WriteLiteral(@"    <div class=""modal fade"" id=""confirm-status"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-sm dv-modal"" style=""width:60%"">
            <div class=""modal-content modal-xoa"">
                <div class=""tab-content tab-content_xoa"">
                    <div class=""modal-header no-padding widget-header-small"">
                        <button type=""button"" class=""close btn-close-modal"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Thêm mới người dùng</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Tên tài khoản:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.tenTaiKhoan"" />
                            </div>
                  ");
            WriteLiteral(@"      </div>
                        <div class=""row"">

                            <label class=""col-sm-3 control-label no-padding-right text-right"">mật khẩu:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.matKhau"" />
                            </div>
                        </div>

                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">kích hoạt:</label>
                            <div class=""col-sm-9"">
                                <input type=""checkbox"" class=""form-control"" ng-model=""model.kichHoat"" />
                                
                            </div>
                        </div>

                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Mã nhân sự:</label>
                            <div class=""col-sm-9"">
");
            WriteLiteral(@"                                <input type=""text"" class=""form-control"" ng-model=""model.maNhanSu"" />
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer no-border"">
                        <a class=""btn btn-success btn-xs btn-ok"" ng-click=""onCreate()""><i class=""fa fa-check-square-o""></i> Lưu</a>
                        <a class=""btn btn-xs btn-danger"" data-dismiss=""modal""><i class=""fa fa-times-circle""></i> Đóng</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div><!-- /.main-content -->
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
