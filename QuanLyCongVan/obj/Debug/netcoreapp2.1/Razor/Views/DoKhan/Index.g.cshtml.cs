#pragma checksum "C:\Users\Admin\Desktop\qlycongvan-master\QuanLyCongVan\Views\DoKhan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37659dc3a631d0bfadb73613afcaab87b48f6551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DoKhan_Index), @"mvc.1.0.view", @"/Views/DoKhan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DoKhan/Index.cshtml", typeof(AspNetCore.Views_DoKhan_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37659dc3a631d0bfadb73613afcaab87b48f6551", @"/Views/DoKhan/Index.cshtml")]
    public class Views_DoKhan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ScriptController/DoKhanScriptController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Admin\Desktop\qlycongvan-master\QuanLyCongVan\Views\DoKhan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(77, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(78, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0532d9dd8e4542f7b28ab45a46ade837", async() => {
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
            BeginContext(146, 2800, true);
            WriteLiteral(@"
<div class=""main-container ace-save-state"" id=""main-container"" ng-controller=""DoKhanJS"">

    <div class=""main-content"">
        <div class=""main-content-inner"">
            <div class=""breadcrumbs ace-save-state"" id=""breadcrumbs"">
                <ul class=""breadcrumb"">
                    <li>
                        <i class=""ace-icon fa fa-home home-icon""></i>
                        <a href=""/Home/Index"">Trang chủ</a>
                    </li>
                    <li class=""active"">Thêm mới độ khẩn</li>
                </ul><!-- /.breadcrumb -->

                <div class=""nav-search"" id=""nav-search"">
                    <form class=""form-search"">
                        <span class=""input-icon"">
                            <input type=""text"" placeholder=""Search ..."" class=""nav-search-input"" id=""nav-search-input"" autocomplete=""off"" />
                            <i class=""ace-icon fa fa-search nav-search-icon""></i>
                        </span>
                    </form>
                </div><!-- /");
            WriteLiteral(@".nav-search -->
            </div>

            <div class=""page-content"">
                <div class=""ace-settings-container"" id=""ace-settings-container"">
                    <button class=""btn btn-sm btn-success"" ng-click=""show()"">Thêm mới</button>
                    <!-- /.ace-settings-box -->
                </div><!-- /.ace-settings-container -->

                <div class=""page-header"">
                    <h1>
                        Danh sách độ khẩn
                    </h1>
                </div><!-- /.page-header -->

                <div class=""row"">
                    <div class=""col-xs-12"">
                        <!-- PAGE CONTENT BEGINS -->
                        <table class=""table table-responsive table-bordered"" id=""grid-table"">
                            <tr>
                                <th>Độ khẩn</th>
                                <th>Ghi chú</th>
                                <th>Thao tác</th>
                            </tr>
                            <tr ng-repeat=""sp i");
            WriteLiteral(@"n datagrid"">
                                <td>{{sp.tenDoKhan}}</td>
                                <td>{{sp.ghiChu}}</td>
                                <td>
                                    <a class=""btn btn-primary btn-sm"" ng-click=""onEdit(sp.id)""><i class=""fa fa-edit""></i></a>
                                    <a class=""btn btn-danger btn-sm""> <i class=""fa fa-trash""></i></a>
                                </td>
                            </tr>
                        </table>

                        <div id=""grid-pager""></div>

                        <!-- PAGE CONTENT ENDS -->
                    </div><!-- /.col -->
                </div><!-- /.row -->
            </div><!-- /.page-content -->
        </div>
    </div>


");
            EndContext();
            BeginContext(2968, 1845, true);
            WriteLiteral(@"    <div class=""modal fade"" id=""confirm-status"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-sm dv-modal"" style=""width:60%"">
            <div class=""modal-content modal-xoa"">
                <div class=""tab-content tab-content_xoa"">
                    <div class=""modal-header no-padding widget-header-small"">
                        <button type=""button"" class=""close btn-close-modal"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Thêm mới độ khẩn</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Độ khẩn:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.tenDoKhan"" />
                            </div>
                        </div>

           ");
            WriteLiteral(@"             <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Ghi chú:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.ghiChu"" />
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
