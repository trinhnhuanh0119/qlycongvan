#pragma checksum "E:\Github\QuanLyCongVan\qlycongvan\QuanLyCongVan\Views\DoKhan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb4b205de30486576a68600244fdae6c155d41a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb4b205de30486576a68600244fdae6c155d41a", @"/Views/DoKhan/Index.cshtml")]
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
#line 1 "E:\Github\QuanLyCongVan\qlycongvan\QuanLyCongVan\Views\DoKhan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa91200614704e9088ffaeb92a3b144b", async() => {
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
            BeginContext(151, 7530, true);
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

                    <li>
                        <a href=""#"">Trang hiện tại</a>
                    </li>
                    <li class=""active"">Thêm mới độ khẩn</li>
                </ul><!-- /.breadcrumb -->

                <div class=""nav-search"" id=""nav-search"">
                    <form class=""form-search"">
                        <span class=""input-icon"">
                            <input type=""text"" placeholder=""Search ..."" class=""nav-search-input"" id=""nav-search-input"" autocomplete=""off"" />
                            <i class=""ace");
            WriteLiteral(@"-icon fa fa-search nav-search-icon""></i>
                        </span>
                    </form>
                </div><!-- /.nav-search -->
            </div>

            <div class=""page-content"">
                <div class=""ace-settings-container"" id=""ace-settings-container"">
                    <div class=""btn btn-app btn-xs btn-warning ace-settings-btn"" id=""ace-settings-btn"">
                        <i class=""ace-icon fa fa-cog bigger-130""></i>
                    </div>
                    <button class=""btn btn-sm btn-primary"" data-target=""#confirm-status"" data-toggle=""modal"">test</button>
                    <div class=""ace-settings-box clearfix"" id=""ace-settings-box"">
                        <div class=""pull-left width-50"">
                            <div class=""ace-settings-item"">
                                <div class=""pull-left"">
                                    <select id=""skin-colorpicker"" ng-model=""Option"" ng-change=""ShowValue()"" class=""hide"">
                     ");
            WriteLiteral(@"                   <option data-skin=""no-skin"" value=""#438EB9"">#438EB9</option>
                                        <option data-skin=""skin-1"" value=""#222A2D"">#222A2D</option>
                                        <option data-skin=""skin-2"" value=""#C6487E"">#C6487E</option>
                                        <option data-skin=""skin-3"" value=""#D0D0D0"">#D0D0D0</option>
                                    </select>
                                </div>
                                <span>&nbsp; Choose Skin</span>
                            </div>

                            <div class=""ace-settings-item"">
                                <input type=""checkbox"" class=""ace ace-checkbox-2 ace-save-state"" id=""ace-settings-navbar"" autocomplete=""off"" />
                                <label class=""lbl"" for=""ace-settings-navbar""> Fixed Navbar</label>
                            </div>

                            <div class=""ace-settings-item"">
                                <input type=""");
            WriteLiteral(@"checkbox"" class=""ace ace-checkbox-2 ace-save-state"" id=""ace-settings-sidebar"" autocomplete=""off"" />
                                <label class=""lbl"" for=""ace-settings-sidebar""> Fixed Sidebar</label>
                            </div>

                            <div class=""ace-settings-item"">
                                <input type=""checkbox"" class=""ace ace-checkbox-2 ace-save-state"" id=""ace-settings-breadcrumbs"" autocomplete=""off"" />
                                <label class=""lbl"" for=""ace-settings-breadcrumbs""> Fixed Breadcrumbs</label>
                            </div>

                            <div class=""ace-settings-item"">
                                <input type=""checkbox"" class=""ace ace-checkbox-2"" id=""ace-settings-rtl"" autocomplete=""off"" />
                                <label class=""lbl"" for=""ace-settings-rtl""> Right To Left (rtl)</label>
                            </div>

                            <div class=""ace-settings-item"">
                                <");
            WriteLiteral(@"input type=""checkbox"" class=""ace ace-checkbox-2 ace-save-state"" id=""ace-settings-add-container"" autocomplete=""off"" />
                                <label class=""lbl"" for=""ace-settings-add-container"">
                                    Inside
                                    <b>.container</b>
                                </label>
                            </div>
                        </div><!-- /.pull-left -->

                        <div class=""pull-left width-50"">
                            <div class=""ace-settings-item"">
                                <input type=""checkbox"" class=""ace ace-checkbox-2"" id=""ace-settings-hover"" autocomplete=""off"" />
                                <label class=""lbl"" for=""ace-settings-hover""> Submenu on Hover</label>
                            </div>

                            <div class=""ace-settings-item"">
                                <input type=""checkbox"" class=""ace ace-checkbox-2"" id=""ace-settings-compact"" autocomplete=""off"" />
       ");
            WriteLiteral(@"                         <label class=""lbl"" for=""ace-settings-compact""> Compact Sidebar</label>
                            </div>

                            <div class=""ace-settings-item"">
                                <input type=""checkbox"" class=""ace ace-checkbox-2"" id=""ace-settings-highlight"" autocomplete=""off"" />
                                <label class=""lbl"" for=""ace-settings-highlight""> Alt. Active Item</label>
                            </div>
                        </div><!-- /.pull-left -->
                    </div><!-- /.ace-settings-box -->
                </div><!-- /.ace-settings-container -->

                <div class=""page-header"">
                    <h1>
                        jqGrid
                        <small>
                            <i class=""ace-icon fa fa-angle-double-right""></i>
                            Dynamic tables and grids using jqGrid plugin
                        </small>
                    </h1>
                </div><!-- /.page-head");
            WriteLiteral(@"er -->

                <div class=""row"">
                    <div class=""col-xs-12"">
                        <!-- PAGE CONTENT BEGINS -->
                        <div class=""alert alert-info"">
                            <button class=""close"" data-dismiss=""alert"">
                                <i class=""ace-icon fa fa-times""></i>
                            </button>

                            <i class=""ace-icon fa fa-hand-o-right""></i>
                            Please note that demo server is not configured to save the changes, therefore you may see an error message.
                        </div>

                        <table class=""table table-responsive"" id=""grid-table"">
                            <tr>
                                <th>Độ khẩn</th>
                                <th>Ghi chú</th>
                            </tr>
                            <tr ng-repeat=""sp in datagrid"">
                                <td>{{sp.tenDoKhan}}</td>
                           ");
            WriteLiteral(@"     <td>{{sp.ghiChu}}</td>
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
            BeginContext(7704, 1412, true);
            WriteLiteral(@"    <div class=""modal fade"" id=""confirm-status"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-sm dv-modal"">
            <div class=""modal-content modal-xoa"">
                <div class=""tab-content tab-content_xoa"">
                    <div class=""modal-header no-padding widget-header-small"">
                        <button type=""button"" class=""close btn-close-modal"" data-dismiss=""modal"">&times;</button>
                        <p class=""title-ct uppercase no-margin""><i class=""ace-icon fa fa-exclamation-triangle red""></i>Thông báo</p>
                        <p>
                            {{texttoShow}}
                        </p>
                    </div>
                    <div class=""modal-body"">
                        <span>
                            Bạn có chắc chắn muốn: <strong class=""red""></strong>?
                        </span>
                    </div>
                    <div class=""modal-footer no-bor");
            WriteLiteral(@"der"">
                        <a class=""btn btn-danger btn-xs btn-ok"" ng-click=""test1()""><i class=""fa fa-check-square-o""></i> Có</a>
                        <a class=""btn btn-xs btn-info"" data-dismiss=""modal""><i class=""fa fa-times-circle""></i> Không</a>
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
