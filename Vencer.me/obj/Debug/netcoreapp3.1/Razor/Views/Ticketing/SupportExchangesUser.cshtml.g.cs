#pragma checksum "E:\githup\Vencerme\Vencer.me\Views\Ticketing\SupportExchangesUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73ef8fae988ee2eee9a3f03aa51a0b53b97eeff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticketing_SupportExchangesUser), @"mvc.1.0.view", @"/Views/Ticketing/SupportExchangesUser.cshtml")]
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
#line 1 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Vencer.me;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Data.Dto.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Data.Dto.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Data.Dto.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Data.Dto.Payment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Data.Dto.Permition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Data.Dto.SupportExchanges;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\githup\Vencerme\Vencer.me\Views\_ViewImports.cshtml"
using Data.Dto.Vencoin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ef8fae988ee2eee9a3f03aa51a0b53b97eeff1", @"/Views/Ticketing/SupportExchangesUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa51d1f44a53d1f5e4b4d512a78a04d457a9a881", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticketing_SupportExchangesUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Kendo/kendo.aspnetmvc.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\githup\Vencerme\Vencer.me\Views\Ticketing\SupportExchangesUser.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row page-titles"">
    <div class=""col p-md-0"">
        <h4>مشاهده وضعیت درخواست </h4>
    </div>
</div>
<div class=""row"">
    <div class=""col-xl-12"">
    <div class=""card button-card"">
        <div class=""card-body"">
        <div id=""gridSupportExchangeUser"" class=""k-rtl""></div>
    </div>
    </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73ef8fae988ee2eee9a3f03aa51a0b53b97eeff14995", async() => {
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
<script>
    $('#gridSupportExchangeUser').kendoGrid({
        dataSource: {
            type: (function () {
                if (kendo.data.transports[""aspnetmvc-ajax""]) {
                    return ""aspnetmvc-ajax""
                } else {
                    throw new Error('The kendo.aspnetmvc.min.js script is not included.')
                }
            }),
            transport: {
                read: {
                    url: ""/api/ApiTicketing/GetSupportExchangesUser"",
                    headers: { 'Authorization': 'Bearer ' + getCookie('Bearer') }
                }
            },
            pageSize: 20,
            serverPage: true,
            schema: {
                data: ""data.data"",
                total: ""data.total""
            },
            serverFiltering: true,
            serverSorting: true,
            ""filter"": []
        },
        height: 550,
        groupable: true,
        sortable: true,
        pageable: {
            pageSizes: true,
            buttonCount: 5
        }");
            WriteLiteral(@",
        columns: [
            {
                field: ""Row"",
                title: "" ردیف"",
                width: 50
            }, {
                field: ""numberOfTicket"",
                title: "" شماره تیکت"",
                width: 100
            }, {
                field: ""amountOfExchange"",
                title: "" مبلغ"",
                width: 150
            }, {
                field: ""accountNumberOfBank"",
                title: ""شماره کارت"",
                width: 150
            }, {
                field: ""description"",
                title: ""توضیحات"",
                width: 150
            }, {
                template: ""#: templateFunction(data.registerDate ) #"",
                field: ""registerDate"",
                title: ""تاریخ واریز"",
                width: 150
            }, {
                template: ""#: templateFunctionState(data.state ) # "",
                field: ""state"",
                title: ""وضعیت"",
                width: 150
            }
        ],
        dataBinding: ");
            WriteLiteral(@"function (a) {
            var row = 0;
            a.items.forEach(function (value) {
                row++;
                value.Row = ((a.sender.dataSource.page() - 1) * a.sender.dataSource.pageSize()) + row
            })
        }
    });
    function templateFunction(value) {
        value.toString();
        var data = new Date(value).toLocaleDateString('fa-IR');
        var time = new Date(value).toLocaleTimeString('fa-IR');
        return time + ' ' + data
    }
    function templateFunctionState(value) {
        switch (parseInt(value)) {
        case 0:
            return ""درحال بررسی فایل"";
        case 1:
            return ""درحال انجام"";
        case 2:
            return ""رد شده توسط کاربر"";
        case 3:
            return ""رد شده توسط مدیر"";
        case 4:
            return ""تایید نهایی"";
        default:
            return ""نا مشخص"";
        }
    }

</script>
");
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
