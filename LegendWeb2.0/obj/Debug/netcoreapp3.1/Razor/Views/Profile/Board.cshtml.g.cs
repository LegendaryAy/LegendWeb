#pragma checksum "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e113e54f3d9df6c98397508cf4fd45bebb589f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Board), @"mvc.1.0.view", @"/Views/Profile/Board.cshtml")]
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
#line 1 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\_ViewImports.cshtml"
using LegendWeb2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\_ViewImports.cshtml"
using LegendWeb2._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\_ViewImports.cshtml"
using LegendWeb2._0.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e113e54f3d9df6c98397508cf4fd45bebb589f6", @"/Views/Profile/Board.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc6a1a5a2f02a6ba2d529c0022b009ae253dfb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Board : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("fadeni ayobami"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
  
    ViewBag.Title = "Profile Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ======= About Section ======= -->

<section id=""about"" class=""about"">
    <div class=""container"" data-aos=""fade-up"">
        <div class=""section-title"">
            <h2>About</h2> 
            <div class=""underline""></div>
            <p class=""text-lg-center"">This is a brief summary about me. It contains basic information about myself, my skills and projects done</p>
        </div>

        <div class=""row"">
            <div class=""col-lg-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4e113e54f3d9df6c98397508cf4fd45bebb589f65558", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 560, "~/", 560, 2, true);
#nullable restore
#line 17 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
AddHtmlAttributeValue("", 562, Model.ProfileImageUrl, 562, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-8 pt-4 pt-lg-0 content\">\r\n                <h3>");
#nullable restore
#line 20 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
               Write(Model.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"font-italic\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
               Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                </p>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-6\">\r\n                        <ul>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>Birthday:</strong> ");
#nullable restore
#line 27 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                                Write(Model.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>Education:</strong> ");
#nullable restore
#line 28 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                                 Write(Model.Education);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>Phone:</strong> ");
#nullable restore
#line 29 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                             Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>City:</strong> ");
#nullable restore
#line 30 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                            Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <ul>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>Age:</strong> ");
#nullable restore
#line 35 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>Degree:</strong> ");
#nullable restore
#line 36 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                              Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>Gender:</strong> ");
#nullable restore
#line 37 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                              Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-angle-double-right\"></i>  <strong>Work Status:</strong> ");
#nullable restore
#line 38 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                                                   Write(Model.WorkStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>
</section><!-- End About Section -->
<!-- ======= Skills Section ======= -->
<section id=""skills"" class=""skills"">
    <div class=""section-title"">
        <h2>Skills</h2>
        <div class=""underline""></div>
        <p>Here are a couple of programming languages i've picked up over the years. It shows how well i have worked with the language and how good i am with it</p>
    </div>
    <div class=""prog-skills"">
        <div class=""row"">
");
#nullable restore
#line 56 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
             for (int i = 0; i < Model.Skills.Count/2; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <div class=\"skill\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e113e54f3d9df6c98397508cf4fd45bebb589f612511", async() => {
#nullable restore
#line 60 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                          Write(Model.Skills[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 60 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Skills[i].Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <progress");
            BeginWriteAttribute("value", " value=", 2915, "", 2947, 1);
#nullable restore
#line 61 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
WriteAttributeValue("", 2922, Model.Skills[i].Progress, 2922, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" max=\"100\"> ");
#nullable restore
#line 61 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                        Write(Model.Skills[i].Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral("% </progress>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"skill\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e113e54f3d9df6c98397508cf4fd45bebb589f615159", async() => {
#nullable restore
#line 66 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                            Write(Model.Skills[i+3].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 66 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Skills[i+3].Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <progress");
            BeginWriteAttribute("value", " value=", 3264, "", 3298, 1);
#nullable restore
#line 67 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
WriteAttributeValue("", 3271, Model.Skills[i+3].Progress, 3271, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" max=\"100\"> ");
#nullable restore
#line 67 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                                                          Write(Model.Skills[i+3].Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral("% </progress>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 70 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>   
    </div>

</section><!-- End Skills Section -->
<!-- ======= Work Section ======= -->
<section id=""projects"" class=""projects"">
    <div class=""section-title"">
        <h2>Projects</h2>
        <div class=""underline""></div>
        <p class=""text-lg-center"">Here are a couple of projects i worked on with their respective repository links.</p>
    </div>
    <div class=""works"">
");
#nullable restore
#line 83 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
         foreach (var project in Model.Projects)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 22rem;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4e113e54f3d9df6c98397508cf4fd45bebb589f618665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3982, "~/", 3982, 2, true);
#nullable restore
#line 86 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
AddHtmlAttributeValue("", 3984, project.ImageUrl, 3984, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 88 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                  Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 89 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
                                Write(project.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=", 4195, "", 4213, 1);
#nullable restore
#line 90 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
WriteAttributeValue("", 4201, project.Url, 4201, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">Show More..</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 93 "C:\Users\hp\Documents\Projects\LegendWeb2.0\LegendWeb2.0\Views\Profile\Board.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </div>\r\n    <div class=\"github\"><a href=\"https://github.com/LegendaryAy\" class=\"btn\">Click this link to my GitHub Page for More...</a></div>\r\n\r\n</section><!-- End Skills Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
