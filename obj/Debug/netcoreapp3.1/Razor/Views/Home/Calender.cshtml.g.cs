#pragma checksum "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e07d2b4a23dc41035cd9bbe4b0e10ef03085c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Calender), @"mvc.1.0.view", @"/Views/Home/Calender.cshtml")]
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
#line 1 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\_ViewImports.cshtml"
using webapp_rucspeciale;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\_ViewImports.cshtml"
using webapp_rucspeciale.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e07d2b4a23dc41035cd9bbe4b0e10ef03085c21", @"/Views/Home/Calender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e3c4eb7ce23eda2c606dab076b955a7c8f8581", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Calender : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webapp_rucspeciale.Models.ReservationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserHandler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml"
  
    ViewData["Title"] = "Calender";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body {
        color: #000;
        overflow-x: hidden;
        height: 100%;
        background-color: #C5CAE9 !important;
        background-repeat: no-repeat;
        padding: 0px !important
    }

    .container-fluid {
        padding-top: 120px !important;
        padding-bottom: 120px !important
    }

    .card {
        box-shadow: 0px 4px 8px 0px #7986CB
    }

    input {
        padding: 10px 20px !important;
        border: 1px solid #000 !important;
        border-radius: 10px;
        box-sizing: border-box;
        background-color: #616161 !important;
        color: #fff !important;
        font-size: 16px;
        letter-spacing: 1px;
        width: 180px
    }

        input:focus {
            -moz-box-shadow: none !important;
            -webkit-box-shadow: none !important;
            box-shadow: none !important;
            border: 1px solid #512DA8;
            outline-width: 0
        }

    ::placeholder {
        color: #fff;
    ");
            WriteLiteral(@"    opacity: 1
    }

    :-ms-input-placeholder {
        color: #fff
    }

    ::-ms-input-placeholder {
        color: #fff
    }

    button:focus {
        -moz-box-shadow: none !important;
        -webkit-box-shadow: none !important;
        box-shadow: none !important;
        outline-width: 0
    }

    .datepicker {
        background-color: #000 !important;
        color: #fff !important;
        border: none;
        padding: 10px !important
    }

    .datepicker-dropdown:after {
        border-bottom: 6px solid #000
    }

    thead tr:nth-child(3) th {
        color: #fff !important;
        font-weight: bold;
        padding-top: 20px;
        padding-bottom: 10px
    }

    .dow,
    .old-day,
    .day,
    .new-day {
        width: 40px !important;
        height: 40px !important;
        border-radius: 0px !important
    }

        .old-day:hover,
        .day:hover,
        .new-day:hover,
        .month:hover,
        .year:hover,
        ");
            WriteLiteral(@".decade:hover,
        .century:hover {
            border-radius: 6px !important;
            background-color: #eee;
            color: #000
        }

    .active {
        border-radius: 6px !important;
        background-image: linear-gradient(#90CAF9, #64B5F6) !important;
        color: #000 !important
    }

    .disabled {
        color: #616161 !important
    }

    .prev,
    .next,
    .datepicker-switch {
        border-radius: 0 !important;
        padding: 20px 10px !important;
        text-transform: uppercase;
        font-size: 20px;
        color: #fff !important;
        opacity: 0.8
    }

        .prev:hover,
        .next:hover,
        .datepicker-switch:hover {
            background-color: inherit !important;
            opacity: 1
        }

    .cell {
        border: 1px solid #BDBDBD;
        margin: 2px;
        cursor: pointer
    }

        .cell:hover {
            border: 1px solid #3D5AFE
        }

        .cell.select {
       ");
            WriteLiteral(@"     background-color: #3D5AFE;
            color: #fff
        }

    .fa-calendar {
        color: #fff;
        font-size: 30px;
        padding-top: 8px;
        padding-left: 5px;
        cursor: pointer
    }
</style>
<h1>View</h1>




<div class=""container-fluid px-0 px-sm-4 mx-auto"">
    <div class=""row justify-content-center mx-0"">
        <div class=""col-lg-10"">
            <div class=""card border-0"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e07d2b4a23dc41035cd9bbe4b0e10ef03085c219728", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e07d2b4a23dc41035cd9bbe4b0e10ef03085c2110006", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 165 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""card-header bg-dark"">
                        <div class=""mx-0 mb-0 row justify-content-sm-center justify-content-start px-1""> <input type=""text"" id=""dp1"" class=""datepicker"" placeholder=""Pick Date"" name=""date"" readonly><span class=""fa fa-calendar""></span> </div>
                    </div>
                    <div class=""card-body p-3 p-sm-5"">
                        <div class=""row text-center mx-0"">
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">9:00AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">9:30AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">9:45AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px");
                WriteLiteral(@"-2"">
                                <div class=""cell py-1"">10:00AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">10:30AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">10:45AM</div>
                            </div>
                        </div>
                        <div class=""row text-center mx-0"">
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">11:00AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">11:30AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">1");
                WriteLiteral(@"1:45AM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">12:00PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">12:30PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">12:45PM</div>
                            </div>
                        </div>
                        <div class=""row text-center mx-0"">
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">1:00PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">1:30PM</div>
                            </div>
              ");
                WriteLiteral(@"              <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">1:45PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">2:00PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">2:30PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">2:45PM</div>
                            </div>
                        </div>
                        <div class=""row text-center mx-0"">
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">3:00PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
             ");
                WriteLiteral(@"                   <div class=""cell py-1"">3:30PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">4:15PM</div>
                            </div>
                            <div class=""col-md-2 col-4 my-1 px-2"">
                                <div class=""cell py-1"">5:00PM</div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group text-center"">
                        <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n             \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <h4>ReservationViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 260 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml"
       Write(Html.DisplayNameFor(model => model.ChosenPlacement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 263 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml"
       Write(Html.DisplayFor(model => model.ChosenPlacement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 266 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml"
       Write(Html.DisplayNameFor(model => model.AmountOfGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 269 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml"
       Write(Html.DisplayFor(model => model.AmountOfGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 275 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Home\Calender.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e07d2b4a23dc41035cd9bbe4b0e10ef03085c2119904", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e07d2b4a23dc41035cd9bbe4b0e10ef03085c2121076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e07d2b4a23dc41035cd9bbe4b0e10ef03085c2122116", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        $('.datepicker').datepicker({
            format: 'dd-mm-yyyy',
            autoclose: true,
            startDate: '0d'
        });

        $('.cell').click(function () {
            $('.cell').removeClass('select');
            $(this).addClass('select');
        });

    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapp_rucspeciale.Models.ReservationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
