#pragma checksum "C:\Users\guisu\Desktop\项目整合\mvc(1)\LogisticsVehicleManagementMVC\LogisticsVehicleManagementMVC\Views\DriverListController1\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ed7c2ac32146a56d911a74514981185483fcf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DriverListController1_Show), @"mvc.1.0.view", @"/Views/DriverListController1/Show.cshtml")]
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
#line 1 "C:\Users\guisu\Desktop\项目整合\mvc(1)\LogisticsVehicleManagementMVC\LogisticsVehicleManagementMVC\Views\_ViewImports.cshtml"
using LogisticsVehicleManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guisu\Desktop\项目整合\mvc(1)\LogisticsVehicleManagementMVC\LogisticsVehicleManagementMVC\Views\_ViewImports.cshtml"
using LogisticsVehicleManagementMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ed7c2ac32146a56d911a74514981185483fcf5", @"/Views/DriverListController1/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca24a4790be26bad80f60a8184b81c371821a2da", @"/Views/_ViewImports.cshtml")]
    public class Views_DriverListController1_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\guisu\Desktop\项目整合\mvc(1)\LogisticsVehicleManagementMVC\LogisticsVehicleManagementMVC\Views\DriverListController1\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Show</h1>\r\n<input type=\"button\" value=\"跳转添加\" onclick=\"location.href=\'/DriverListController1/Add\'\"/>\r\n<input type=\"text\" id=\"Dname\" />\r\n<input type=\"button\" value=\"查询\" onclick=\"Shwo()\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ed7c2ac32146a56d911a74514981185483fcf54202", async() => {
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
            WriteLiteral(@"
<table class=""table table-dark"">
    <thead>
        <tr>
            <td>驾驶员编号</td>
            <td>驾驶员姓名</td>
            <td>驾驶员电话</td>
            <td>车牌编号</td>
            <td>驾照编号</td>
            <td>性别</td>
            <td>出生年月</td>
            <td>准驾车型</td>
            <td>车辆载重</td>
            <td>状态</td>
            <td>操作</td>
        </tr>
    </thead>
    <tbody id=""tb"">
    </tbody>
</table>
<!-- 模态框 -->
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <!-- 模态框头部 -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">人员信息详细</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <!-- 模态框主体 -->
            <div class=""modal-body"">
                <table id=""table"">
                </table>
            </div>
            <!-- 模态框底部 -->
            <div class=""modal-footer"">
                <button");
            WriteLiteral(@" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">关闭</button>
            </div>
        </div>
    </div>
</div>
<script>
    $(function () {
        Shwo();
    })
    function Shwo() {
        var Dname = $(""#Dname"").val();
        $.ajax({
            url: 'http://localhost:8648/API/DriverList/GetShow',
            data: { Dname: Dname },
            dataType: 'JSON',
            type: 'get',
            success: function (data, DBit) {
                $(""#tb"").empty();
                $(data).each(function () {
                    if (this.DBit == true) {
                        var html = '<tr class=""table-primary"">';
                        html += '<td>' + this.DId + '</td>';
                        html += '<td>' + this.Dname + '</td>';
                        html += '<td>' + this.Dphone + '</td>';
                        html += '<td>' + this.Dlon + '</td>';
                        html += '<td>' + this.Dzno + '</td>';
                        html += '<td>' + t");
            WriteLiteral(@"his.Dsex + '</td>';
                        html += '<td>' + this.Dbirthday + '</td>';
                        html += '<td>' + this.Dtype + '</td>';
                        html += '<td>' + this.Dload + '</td>';
                        html += '<td>' + (this.DBit = false ? ""已删除"" : ""未删除"") + '</td>';
                        html += '<td><input type=""button"" value=""删除"" onclick=""Del(' + this.DId + ')""/><input type=""button"" value=""修改"" onclick=""Eid(' + this.DId + ')""/><button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"" onclick=""data(' + this.DId + ')"">详情</button></td>';
                        html += '</tr>';
                        $(""#tb"").append(html);
                    }
                })
            }
        })
    }
    //删除
    function Del(Did) {
        if (confirm(""确定删除吗"")) {
            $.ajax({
                url: 'http://localhost:8648/api/DriverList/DelDeriver',
                dataType: 'json',
                type: 'get',
              ");
            WriteLiteral(@"  data: { Did: Did },
                success: function (data) {
                    if (data > 0) {
                        alert(""删除成功"");
                        Shwo();
                    }
                    else {
                        alert(""删除失败"");
                        return;
                    }
                }
            })
        }
    }
    //修改
    function Eid(Did) {
        location.href = '/DriverListController1/Upt?Did=' + Did;
    }
    //模态框
    function data(id) {
        $.ajax({
            url: 'http://localhost:8648/API/DriverList/GetDetails',
            dataType: 'json',
            type: 'get',
            data: { id: id },
            success: function (data) {
                $(""#table"").empty();
                $(data).each(function () {
                    var html = '<tr>';
                    html += '<td>编号：' + this.DId + '</td>';;
                    html += '</tr>';
                    html += '<tr>';
                    html += '");
            WriteLiteral(@"<td>驾驶员姓名：' + this.Dname + '<td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>手机号：' + this.Dphone + '<td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>车牌编号：' + this.Dlon + '<td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>驾照编号：' + this.Dzno + '<td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>性别：' + this.Dsex + '<td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>出生年月：' + this.Dbirthday + '<td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>准驾车型：' + this.Dtype + '<td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>车辆载重：' + this.Dload + '<td>';
                ");
            WriteLiteral("    html += \'</tr>\';\r\n                    $(\"#table\").append(html);\r\n                })\r\n            }\r\n        })\r\n    }\r\n</script>");
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
