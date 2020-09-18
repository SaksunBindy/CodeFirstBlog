#pragma checksum "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af619d6750db47198e4294cfa37caa3355df74b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_AddGame), @"mvc.1.0.view", @"/Views/Game/AddGame.cshtml")]
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
#line 7 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
using DataLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af619d6750db47198e4294cfa37caa3355df74b", @"/Views/Game/AddGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30be6e8d357e7570361a44c6f59cbfc77c09d358", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_AddGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PresentationLayer.Models.AddGameViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
  
    Layout = "_GameLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8af619d6750db47198e4294cfa37caa3355df74b4848", async() => {
                WriteLiteral("\r\n    <fieldset>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <label> Insert Game Name </label>\r\n                <br>\r\n                ");
#nullable restore
#line 16 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
           Write(Html.TextBoxFor(model => model.GameModel.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br>\r\n                <br>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <label> Insert City </label>\r\n                <br>\r\n                ");
#nullable restore
#line 23 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
           Write(Html.TextBoxFor(model => model.GameModel.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br>\r\n                <br>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n\r\n\r\n                <label> Select Spots </label>\r\n                <br>\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
                 foreach (Spot spot in Model.Spots)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1121, "\"", 1134, 1);
#nullable restore
#line 39 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1126, spot.Id, 1126, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1135, "\"", 1150, 1);
#nullable restore
#line 39 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1142, spot.Id, 1142, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1151, "\"", 1169, 1);
#nullable restore
#line 39 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1159, spot.Name, 1159, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1199, "\"", 1213, 1);
#nullable restore
#line 40 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1205, spot.Id, 1205, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
                                     Write(spot.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <br>\r\n");
#nullable restore
#line 42 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <br>\r\n                <br>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <label> Select Rewards </label>\r\n                <br>\r\n");
#nullable restore
#line 49 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
                 foreach (Reward reward in Model.Rewards)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1571, "\"", 1586, 1);
#nullable restore
#line 51 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1576, reward.Id, 1576, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1587, "\"", 1604, 1);
#nullable restore
#line 51 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1594, reward.Id, 1594, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1605, "\"", 1625, 1);
#nullable restore
#line 51 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1613, reward.Name, 1613, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1655, "\"", 1671, 1);
#nullable restore
#line 52 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
WriteAttributeValue("", 1661, reward.Id, 1661, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
                                       Write(reward.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <br>\r\n");
#nullable restore
#line 54 "C:\Users\Tiab\OneDrive - University of Bristol\Work\Bindy\CRUDGameInterface\PresentationLayer\Views\Game\AddGame.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"form-group\" style=\"padding-top:20px;padding-left:12px\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-success\" />\r\n        </div>\r\n    </fieldset>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PresentationLayer.Models.AddGameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591