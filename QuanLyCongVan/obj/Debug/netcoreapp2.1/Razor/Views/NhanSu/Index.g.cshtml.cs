#pragma checksum "E:\qlycongvan.git\trunk\QuanLyCongVan\Views\NhanSu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "693e2cd702bcffaba7e2069b7ec806b65304d537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanSu_Index), @"mvc.1.0.view", @"/Views/NhanSu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanSu/Index.cshtml", typeof(AspNetCore.Views_NhanSu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693e2cd702bcffaba7e2069b7ec806b65304d537", @"/Views/NhanSu/Index.cshtml")]
    public class Views_NhanSu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ScriptController/NhanSuScriptController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\qlycongvan.git\trunk\QuanLyCongVan\Views\NhanSu\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "408c1a65b7a5422e95762327f398f89b", async() => {
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
            BeginContext(151, 4352, true);
            WriteLiteral(@"
<div class=""main-container ace-save-state"" id=""main-container"" ng-controller=""NhanSuJS"">
    <div class=""main-content"">
        <div class=""main-content-inner"">
            <div class=""breadcrumbs ace-save-state"" id=""breadcrumbs"">
                <ul class=""breadcrumb"">
                    <li>
                        <i class=""ace-icon fa fa-home home-icon""></i>
                        <a href=""/Home/Index"">Trang chủ</a>
                    </li>
                    <li class=""active"">Thêm mới nhân sự</li>
                </ul><!-- /.breadcrumb -->
                <div class=""nav-search"" id=""nav-search"">
                    <form class=""form-search"">
                        <span class=""input-icon"">
                            <input type=""text"" ng-model=""SearchObject.MaNhanSu"" placeholder=""Search ..."" class=""nav-search-input"" id=""nav-search-input"" autocomplete=""off"" />
                            <a class=""btn btn-primary btn-xs"" ng-click=""sort()""><i class=""fa fa-search""></i></a>
         ");
            WriteLiteral(@"               </span>
                    </form>
                </div><!-- /.nav-search -->
            </div>
            <div class=""page-content text-right"" style=""padding-bottom:3em;"">
                <div class=""ace-settings-container row"" id=""ace-settings-container"">
                    <button class=""btn btn-sm btn-success"" ng-click=""show()"">Thêm mới <i class=""glyphicon glyphicon-plus""></i></button>
                    <button class=""btn btn-sm btn-primary "" ng-click=""export()"">Export Exel <i class=""glyphicon glyphicon-download-alt""></i></button>
                </div><!-- /.ace-settings-box -->
            </div><!-- /.ace-settings-container -->
            <iframe id=""downloadfile"" style=""display:none""></iframe>
            <div style=""margin-left:20px; margin-right:20px"">
                <div class=""page-header"">
                    <h1>
                        Danh sách nhân sự
                    </h1>
                </div><!-- /.page-header -->
                <div class=""row");
            WriteLiteral(@""">
                    <div class=""col-xs-12"">
                        <!-- PAGE CONTENT BEGINS -->
                        <table class=""table table-responsive table-bordered"" id=""grid-table"">
                            <tr>
                                <th>Mã </th>
                                <th>Tên</th>
                                <th>Giới tính</th>
                                <th>Ngày sinh</th>
                                <th>Địa chỉ nhà</th>
                                <th>Địa chỉ cơ quan</th>
                                <th>Điện thoại</th>
                                <th>Mã phòng</th>
                                <th>Thao tác</th>
                            </tr>
                            <tr ng-repeat=""sp in datagrid"">
                                <td>{{sp.maNhanSu}} </td>
                                <td>{{sp.ten}} </td>
                                <td>{{sp.gioiTinh}}</td>
                                <td>{{sp.ngaySinh| date:""dd/MM");
            WriteLiteral(@"/yyyy""}}</td>
                                <td>{{sp.diaChiNr}} </td>
                                <td>{{sp.diaChiCq}} </td>
                                <td>{{sp.dienThoai}} </td>
                                <td>{{sp.maPhong}} </td>
                                <td>
                                    <a class=""btn btn-primary btn-sm"" ng-click=""onEdit(sp.id)""><i class=""fa fa-edit""></i></a>
                                    <a class=""btn btn-danger btn-sm"" ng-click=""confirmdelete(sp.id)""> <i class=""fa fa-trash""></i></a>
                                </td>
                            </tr>
                        </table>
                        <div>

                            <ul uib-pagination total-items=""pageCount""
                                ng-model=""currentPage""
                                class=""pagination-sm""
                                ng-change=""pagechaned()""
                                items-per-page=""PageSize""></ul>
                        </");
            WriteLiteral(@"div>
                        <div id=""grid-pager""></div>
                        <!-- PAGE CONTENT ENDS -->
                    </div><!-- /.col -->
                </div><!-- /.row --></div>
            </div><!-- /.page-content -->
        </div>
");
            EndContext();
            BeginContext(4526, 6610, true);
            WriteLiteral(@"    <div class=""modal fade"" id=""confirm-status"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-sm dv-modal"" style=""width:60%"">
            <div class=""modal-content modal-xoa"">
                <div class=""tab-content tab-content_xoa"">
                    <div class=""modal-header no-padding widget-header-small"">
                        <button type=""button"" class=""close btn-close-modal"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Thêm mới nhân sự</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Mã nhân sự:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.maNhanSu"" />
                            </div>
                        </d");
            WriteLiteral(@"iv><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Tên:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.ten"" />
                            </div>
                        </div><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Giới tính:</label>
                            <div class=""col-sm-3"" style=""font-size:15px"">
                                <input type=""radio"" name=""gender"" value=""1"" ng-model=""model.gioiTinh""> Nam
                            </div>
                            <div class=""col-sm-3"" style=""font-size:15px"">
                                <input type=""radio"" name=""gender"" value=""0"" ng-model=""model.gioiTinh""> Nữ
                            </div>
                        </div><br>
             ");
            WriteLiteral(@"           <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Ngày sinh:</label>
                            <div class=""col-sm-9"" style=""padding-left:10px !important"">
                                <div class=""form-group"">
                                    <div class='input-group date' id='datetimepicker9'>
                                        <input type=""text"" class=""form-control"" ng-model=""model.ngaySinh"" />
                                        <span class=""input-group-addon"">
                                            <span class=""glyphicon glyphicon-calendar"">
                                            </span>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <script type=""text/javascript"">
                                $(function () {
                                    $('");
            WriteLiteral(@"#datetimepicker9').datetimepicker({
                                        viewMode: 'years'
                                    });
                                });
                            </script>
                        </div><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Địa chỉ nhà riêng:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.diaChiNr"" />
                            </div>
                        </div><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Địa chỉ cơ quan:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.diaChiCq"" />
                            </div>
                        </div><");
            WriteLiteral(@"br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Điện thoại:</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" class=""form-control"" ng-model=""model.dienThoai"" />
                            </div>
                        </div><br>
                        <div class=""row"">
                            <label class=""col-sm-3 control-label no-padding-right text-right"">Mã phòng:</label>
                            <div class=""col-sm-9"">
                                <select class=""form-control""  ng-model=""model.maPhong"">
                                    <option ng-repeat=""sp in listPB"" value=""{{sp.id}}"">{{sp.text}}</option>
                                </select>
                            </div>
                        </div><br>
                    </div>
                </div>
                <div class=""modal-footer no-border"">
       ");
            WriteLiteral(@"             <a class=""btn btn-success btn-xs btn-ok"" ng-click=""onCreate()""><i class=""fa fa-check-square-o""></i> Lưu</a>
                    <a class=""btn btn-xs btn-danger"" data-dismiss=""modal""><i class=""fa fa-times-circle""></i> Đóng</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""notifycal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-sm dv-modal"" style=""width:60%"">
            <div class=""modal-content modal-xoa"">
                <div class=""tab-content tab-content_xoa"">
                    <div class=""modal-header no-padding widget-header-small"">
                        <button type=""button"" class=""close btn-close-modal"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Xóa Thông Tin</h4>
                    </div>
                    <div>
                        <p>Bạn chắc chắn muốn xóa thông tin này?</p>
                   ");
            WriteLiteral(@" </div>
                    <div class=""modal-footer no-border"">
                        <a class=""btn btn-success btn-xs btn-ok"" ng-click=""onDelete(idremove)""><i class=""fa fa-check-square-o""></i> Đồng ý</a>
                        <a class=""btn btn-xs btn-danger"" data-dismiss=""modal""><i class=""fa fa-times-circle""></i> Không</a>
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
