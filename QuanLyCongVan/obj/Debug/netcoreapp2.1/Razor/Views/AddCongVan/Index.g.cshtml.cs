#pragma checksum "E:\qlycongvan.git\trunk\QuanLyCongVan\Views\AddCongVan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e410dbfa70c923c26a6d5653be0fdf877a237699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddCongVan_Index), @"mvc.1.0.view", @"/Views/AddCongVan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AddCongVan/Index.cshtml", typeof(AspNetCore.Views_AddCongVan_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e410dbfa70c923c26a6d5653be0fdf877a237699", @"/Views/AddCongVan/Index.cshtml")]
    public class Views_AddCongVan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ScriptController/AddCongVanScriptController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\qlycongvan.git\trunk\QuanLyCongVan\Views\AddCongVan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(85, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478346364a2e4c8a98f46fe2a86f7b24", async() => {
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
            BeginContext(157, 7232, true);
            WriteLiteral(@"
<div class=""main-container ace-save-state"" id=""main-container"" ng-controller=""AddCongVanJS"">
    <div class=""main-content"">
        <div class=""main-content-inner"">
            <div class=""breadcrumbs ace-save-state"" id=""breadcrumbs"">
                <ul class=""breadcrumb"">
                    <li>
                        <i class=""ace-icon fa fa-home home-icon""></i>
                        <a href=""/Home/Index"">Trang chủ</a>
                    </li>
                    <li class=""active"">Thêm mới công văn</li>
                </ul><!-- /.breadcrumb -->
                <div class=""nav-search"" id=""nav-search"">
                    <form class=""form-search"">
                        <span class=""input-icon"">
                            <input type=""text"" placeholder=""Search ..."" class=""nav-search-input"" id=""nav-search-input"" autocomplete=""off"" />
                            <i class=""ace-icon fa fa-search nav-search-icon""></i>
                        </span>
                    </form>
      ");
            WriteLiteral(@"          </div><!-- /.nav-search -->
            </div>
            <div class=""page-content"">
                <div class=""ace-settings-container"" id=""ace-settings-container"">
                    <button class=""btn btn-sm btn-success"" ng-click=""show()"">Thêm mới</button>
                    <!-- /.ace-settings-box -->
                </div><!-- /.ace-settings-container -->
                <div class=""page-header"">
                    <h1>
                        Thêm mới công văn
                    </h1>
                </div><!-- /.page-header -->
                <div>
                    <div class=""row"">
                        <div>
                            <div class=""widget-box"">
                                <div class=""widget-header"">
                                    <h4 class=""smaller"">Danh sách công văn</h4>
                                </div>
                                <div class=""widget-body"">
                                    <div class=""widget-main"">
     ");
            WriteLiteral(@"                                   <table class=""table table-responsive table-bordered"" id=""grid-table"">
                                            <tr>
                                                <th>Số công văn</th>
                                                <th>Loại công văn</th>
                                                <th>Cơ quan ban hành</th>
                                                <th>Trích yếu</th>
                                                <th>Nơi lưu</th>
                                            </tr>
                                            <tr ng-repeat=""sp in datagrid""></tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div><!-- /.page-content -->
        </div>
    </div>

    <!--Modal hển thị-->
    <div class=""modal fade"" id=");
            WriteLiteral(@"""confirm-status"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-sm dv-modal"" style=""width:60%"">
            <div class=""modal-content modal-xoa"">
                <div class=""tab-content tab-content_xoa"">
                    <div class=""modal-header no-padding widget-header-small"">
                        <button type=""button"" class=""close btn-close-modal"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Thêm mới Công Văn</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Số Công Văn:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.soVb"" />
                            </div>
                        </div><br>
                        ");
            WriteLiteral(@"<div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Loại Công Văn:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.maLoaiVb"" />
                            </div>
                        </div><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Cơ Quan Ban Hành:</label>
                            <div class=""col-sm-3"" style=""font-size:15px"">
                                <input type=""text"" class=""form-control"" ng-model=""model.maCqbh"" />
                            </div>
                        </div><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Trích Yếu:</label>
                            <div class=""col-sm-9"">
                                <input ty");
            WriteLiteral(@"pe=""text"" class=""form-control"" ng-model=""model.trichYeu"" />
                            </div>
                        </div><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Nơi Lưu:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.noiNhan"" />
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

   <div class=""modal fade"" id=""notifycal"" tabindex=""-1"" role=""dialog"" a");
            WriteLiteral(@"ria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-sm dv-modal"" style=""width:60%"">
            <div class=""modal-content modal-xoa"">
                <div class=""tab-content tab-content_xoa"">
                    <div class=""modal-header no-padding widget-header-small"">
                        <button type=""button"" class=""close btn-close-modal"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Xóa Thông Tin</h4>
                    </div>
                    <div>
                        <p>Bạn chắc chắn muốn xóa thông tin này?</p>
                    </div>
                    <div class=""modal-footer no-border"">
                        <a class=""btn btn-success btn-xs btn-ok"" ng-click=""onDelete(idremove)""><i class=""fa fa-check-square-o""></i> Đồng ý</a>
                        <a class=""btn btn-xs btn-danger"" data-dismiss=""modal""><i class=""fa fa-times-circle""></i> Không</a>
                    </div>
                </div>");
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
