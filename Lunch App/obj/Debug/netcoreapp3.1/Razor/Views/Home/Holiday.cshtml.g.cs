#pragma checksum "C:\Users\Mensah\Documents\Projects\Trials\mvc_trials\Lunch_App\Lunch App\Views\Home\Holiday.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d8329ed5e71d454914acb13173fc280480b460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Holiday), @"mvc.1.0.view", @"/Views/Home/Holiday.cshtml")]
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
#line 1 "C:\Users\Mensah\Documents\Projects\Trials\mvc_trials\Lunch_App\Lunch App\Views\_ViewImports.cshtml"
using Lunch_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mensah\Documents\Projects\Trials\mvc_trials\Lunch_App\Lunch App\Views\_ViewImports.cshtml"
using Lunch_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d8329ed5e71d454914acb13173fc280480b460", @"/Views/Home/Holiday.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3b22650ed9f7e641628ae0fb8bb040adc1feaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Holiday : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("appForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Holiday.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mensah\Documents\Projects\Trials\mvc_trials\Lunch_App\Lunch App\Views\Home\Holiday.cshtml"
  
    ViewData["Title"] = "FoodItem";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\r\n        th {\r\n            color: white !important\r\n        }\r\n    </style>\r\n");
            WriteLiteral(@"<div class=""app-main__outer"">
    <div class=""app-main__inner"">
        <div class=""row"">
            <div class=""col-md-12 col-xl-12"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-md-2"">
                                <h1 class=""card-title"" style=""margin-top: 5px"">Holiday</h1>
                            </div>
                            <div class=""col-md-2"">
                            </div>
                            <div class=""col-md-4"">
                                <div class=""search-wrapper"" style=""margin-bottom: 10px"">
                                    <div class=""input-holder"">
                                        <input type=""text"" class=""search-input"" placeholder=""Type holiday to search"">
                                        <button class=""search-icon""><span></span></button>
                                    </div>
               ");
            WriteLiteral(@"                     <button class=""close""></button>
                                </div>
                            </div>
                            <div class=""col-md-3""></div>
                            <div class=""col-md-1"" style=""margin-top: 5px"">
                                <button class=""btn btn-sm btn-outline-primary pull-right"" style=""margin-bottom: 15px;"" id=""holidayBtn"">Add Holiday</button>
                            </div>
                        </div>
                        <table id=""HolidayTable"" class=""mb-0 table table-striped table-hover"" width=""100%""></table>
");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Modals", async() => {
                WriteLiteral("\r\n    <div class=\"modal\" id=\"holidayModal\" tabindex=\"-1\">\r\n        <div class=\"modal-dialog modal-md\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\">Add Holiday</h5>\r\n");
                WriteLiteral("                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05d8329ed5e71d454914acb13173fc280480b4607186", async() => {
                    WriteLiteral(@"
                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-lg-5"">
                                <label for=""Date"" style=""margin-bottom: 0px; margin-top: 10px"" class=""form-label"">Date   <span class=""text-danger"">*</span></label>
                                <input type=""text"" placeholder=""Select Date"" style=""background-color: white"" class=""form-control required"" id=""date"">
                            </div>
                            <div class=""col-lg-7"">
                                <label for=""name"" style=""margin-bottom: 0px; margin-top: 10px"" class=""form-label"">Name   <span class=""text-danger"">*</span></label>
                                <input type=""text"" class=""form-control required"" id=""name"">
                            </div>
                        </div>
");
                    WriteLiteral(@"                        <div class=""modal-footer"">
                            <button type=""button"" id=""saveHoliday"" class=""btn btn-primary"" disabled>Save  <i class=""fa fa-save""></i></button>
                            <button type=""button"" class=""btn btn-danger"" id=""closeBtn"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05d8329ed5e71d454914acb13173fc280480b46010232", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
