#pragma checksum "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3bdbe290bee42ff3ab298a2fe67fe5a6297fd14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Edit), @"mvc.1.0.view", @"/Views/Game/Edit.cshtml")]
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
#line 1 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
using DataLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3bdbe290bee42ff3ab298a2fe67fe5a6297fd14", @"/Views/Game/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30be6e8d357e7570361a44c6f59cbfc77c09d358", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PresentationLayer.Models.EditGameViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
  
    Layout = "_GameLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3bdbe290bee42ff3ab298a2fe67fe5a6297fd144782", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <label> Insert Game Name </label>\r\n            <br>\r\n            ");
#nullable restore
#line 12 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.GameModel.Name, new { @Value = Model.GameModel.Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br>\r\n            <br>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            <label> Insert City </label>\r\n            <br>\r\n            ");
#nullable restore
#line 19 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.GameModel.City, new { @Value = Model.GameModel.City }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br>\r\n            <br>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <label> Select spots </label>\r\n            <br>\r\n");
#nullable restore
#line 28 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
             foreach (Spot spot in Model.Spots)
            {
                bool checkTicked = false;
                foreach (IntersectionGameSpot intersectionGameSpot in Model.IntersectionGameSpots)
                {
                    if (intersectionGameSpot.SpotId == spot.Id && intersectionGameSpot.GameId == Model.GameModel.Id)
                    {
                        checkTicked = true;
                    }
                }
                if (checkTicked)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1379, "\"", 1392, 1);
#nullable restore
#line 40 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 1384, spot.Id, 1384, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1393, "\"", 1408, 1);
#nullable restore
#line 40 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 1400, spot.Id, 1400, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1409, "\"", 1427, 1);
#nullable restore
#line 40 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 1417, spot.Name, 1417, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked>\r\n");
#nullable restore
#line 41 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1541, "\"", 1554, 1);
#nullable restore
#line 44 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 1546, spot.Id, 1546, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1555, "\"", 1570, 1);
#nullable restore
#line 44 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 1562, spot.Id, 1562, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1571, "\"", 1589, 1);
#nullable restore
#line 44 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 1579, spot.Name, 1579, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 45 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <label");
                BeginWriteAttribute("for", " for=\"", 1634, "\"", 1648, 1);
#nullable restore
#line 46 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 1640, spot.Id, 1640, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
                                 Write(spot.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                <br>\r\n");
#nullable restore
#line 48 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            <label> Select Rewards </label>\r\n            <br>\r\n");
#nullable restore
#line 54 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
             foreach (Reward reward in Model.Rewards)
            {
                bool checkTicked = false;
                foreach (IntersectionGameReward intersectionGameReward in Model.IntersectionGameRewards)
                {
                    if (intersectionGameReward.RewardId == reward.Id && intersectionGameReward.GameId == Model.GameModel.Id)
                    {
                        checkTicked = true;
                    }
                }
                if (checkTicked)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2389, "\"", 2404, 1);
#nullable restore
#line 66 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 2394, reward.Id, 2394, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2405, "\"", 2422, 1);
#nullable restore
#line 66 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 2412, reward.Id, 2412, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2423, "\"", 2443, 1);
#nullable restore
#line 66 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 2431, reward.Name, 2431, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked>\r\n");
#nullable restore
#line 67 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2557, "\"", 2572, 1);
#nullable restore
#line 70 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 2562, reward.Id, 2562, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2573, "\"", 2590, 1);
#nullable restore
#line 70 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 2580, reward.Id, 2580, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2591, "\"", 2611, 1);
#nullable restore
#line 70 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 2599, reward.Name, 2599, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 71 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <label");
                BeginWriteAttribute("for", " for=\"", 2656, "\"", 2672, 1);
#nullable restore
#line 72 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
WriteAttributeValue("", 2662, reward.Id, 2662, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
                                   Write(reward.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                <br>\r\n");
#nullable restore
#line 74 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"form-group\" style=\"padding-top:20px;padding-left:12px\">\r\n        <input type=\"submit\" value=\"Confirm\" class=\"btn btn-success\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PresentationLayer.Models.EditGameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591