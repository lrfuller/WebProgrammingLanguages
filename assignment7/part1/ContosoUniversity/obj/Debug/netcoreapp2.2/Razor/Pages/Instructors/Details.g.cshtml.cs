#pragma checksum "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47d972cdf0955fb94f13ca4bbe7b52e2a4d87dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoUniversity.Pages.Instructors.Pages_Instructors_Details), @"mvc.1.0.razor-page", @"/Pages/Instructors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Instructors/Details.cshtml", typeof(ContosoUniversity.Pages.Instructors.Pages_Instructors_Details), null)]
namespace ContosoUniversity.Pages.Instructors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47d972cdf0955fb94f13ca4bbe7b52e2a4d87dd", @"/Pages/Instructors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c0473ebe7d620ab1ae06d83bc5bc87bf314407", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Instructors_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(109, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Instructor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(241, 55, false);
#line 15 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Instructor.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(296, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(358, 51, false);
#line 18 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Instructor.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(409, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(470, 59, false);
#line 21 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Instructor.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(529, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(591, 55, false);
#line 24 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Instructor.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(646, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(707, 55, false);
#line 27 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Instructor.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(762, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(824, 51, false);
#line 30 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Instructor.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(875, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(922, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47d972cdf0955fb94f13ca4bbe7b52e2a4d87dd7498", async() => {
                BeginContext(979, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\bobal\Desktop\classes\Web Programming Languages\WebProgrammingLanguages\assignment7\ContosoUniversity\ContosoUniversity\Pages\Instructors\Details.cshtml"
                           WriteLiteral(Model.Instructor.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(987, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(995, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47d972cdf0955fb94f13ca4bbe7b52e2a4d87dd9907", async() => {
                BeginContext(1017, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1033, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Pages.Instructors.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Instructors.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Instructors.DetailsModel>)PageContext?.ViewData;
        public ContosoUniversity.Pages.Instructors.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591