#pragma checksum "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2078ccb1758f65540eb71fa6705e1edd3c9438a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Forms), @"mvc.1.0.view", @"/Views/Home/Forms.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Forms.cshtml", typeof(AspNetCore.Views_Home_Forms))]
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
#line 1 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\_ViewImports.cshtml"
using ReleaseReminder;

#line default
#line hidden
#line 2 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\_ViewImports.cshtml"
using ReleaseReminder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2078ccb1758f65540eb71fa6705e1edd3c9438a2", @"/Views/Home/Forms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5d2efacd5400a7c8869ba7fa2b9784598b79150", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Forms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReleaseReminder.Models.Reminder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Music", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "VideoGames", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Television", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Select a Type of Media...", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
  
    ViewData["Title"] = "Add New Reminders";

#line default
#line hidden
            BeginContext(101, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(106, 17, false);
#line 6 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(135, 19, false);
#line 7 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(154, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
            BeginContext(163, 3565, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e69eae1115648aa9e71fb2e249d3e30", async() => {
                BeginContext(225, 202, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"mediaType\">Media Type: </label>\r\n\t\t\t<select name=\"mediaType\" class=\"form-control\" onchange=\"mediaSelect(this)\">\r\n\t\t\t\t");
                EndContext();
                BeginContext(427, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7ecb1fc881145178056421d41fc6467", async() => {
                    BeginContext(447, 3, true);
                    WriteLiteral("All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(459, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(465, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ded9a15cdbc4b74b89e6e58eaa6b327", async() => {
                    BeginContext(488, 6, true);
                    WriteLiteral("Movies");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(503, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(509, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eac7aa964e14282804ca93220ad1294", async() => {
                    BeginContext(531, 5, true);
                    WriteLiteral("Music");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(545, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(551, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb66de05e374f01b33de3c87e79d5cc", async() => {
                    BeginContext(578, 11, true);
                    WriteLiteral("Video Games");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(598, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(604, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "967198e886dc4842a47ac3ab9fdb000a", async() => {
                    BeginContext(626, 5, true);
                    WriteLiteral("Books");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(640, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(646, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a11f91d9eb6747d6aa9f2a5375981d81", async() => {
                    BeginContext(673, 10, true);
                    WriteLiteral("Television");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(692, 460, true);
                WriteLiteral(@"


			</select>
        </div>

        <div class=""col-sm-6"">
            <div class=""form-group"">
                <label for=""title"">Title: </label>
                <input type=""text"" class=""form-control"" name=""appName"" required />
            </div>


            <div class=""form-group"">
                <label id=""creatorLabel"" for=""Genre1"">Genre1: </label>
                <select name=""creator"" class=""form-control"">
                    ");
                EndContext();
                BeginContext(1152, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76d7e9d282e4b9c9f4fc4d5dacf3ed7", async() => {
                    BeginContext(1194, 25, true);
                    WriteLiteral("Select a Type of Media...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1228, 236, true);
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n\r\n\t\t   <div class=\"form-group\">\r\n                <label id=\"creatorLabel\" for=\"Genre2\">Genre2: </label>\r\n                <select name=\"creator\" class=\"form-control\">\r\n                    ");
                EndContext();
                BeginContext(1464, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dcf50dc91044f5da46ed472f626c5c3", async() => {
                    BeginContext(1506, 25, true);
                    WriteLiteral("Select a Type of Media...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1540, 236, true);
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n\r\n\t\t\t  <div class=\"form-group\">\r\n                <label id=\"creatorLabel\" for=\"Genre3\">Genre3: </label>\r\n                <select name=\"creator\" class=\"form-control\">\r\n                    ");
                EndContext();
                BeginContext(1776, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35b192230a764069b76f09ca40709f9c", async() => {
                    BeginContext(1818, 25, true);
                    WriteLiteral("Select a Type of Media...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1852, 1165, true);
                WriteLiteral(@"
                </select>
            </div>

        </div>
        <div class=""col-sm-2 well"" id=""smallCol"" name=""smallCol"">
            <label for=""smallCol"">Genres: </label>
            <div class=""form-group"">
                <label id=""checkbox1ID"" for=""checkbox1"">checkbox1: </label>
                <input type=""checkbox"" name=""checkbox1"" />
            </div>

            <div class=""form-group"">
                <label id=""checkbox2ID"" for=""checkbox2"">checkbox2: </label>
                <input type=""checkbox"" name=""checkbox2"" />
            </div>

            <div class=""form-group"">
                <label id=""checkbox3ID"" for=""checkbox3"">checkbox3: </label>
                <input type=""checkbox"" name=""checkbox3"" />
            </div>

        </div>

    </div>

    <!--    <button type=""submit"" form=""appNew"" value=""Submit"">Submit</button> -->
    <div class=""table_edit"">
        <table id=""formTable"">
            <tr>
                <th>Selected</th>
                ");
                WriteLiteral("<th>Category</th>\r\n                <th>Title</th>\r\n                <th>Genre</th>\r\n                <th>Release Date</th>\r\n            </tr>\r\n");
                EndContext();
#line 86 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
              
                foreach (var app in Model)
                {


#line default
#line hidden
                BeginContext(3098, 114, true);
                WriteLiteral("                    <tr>\r\n                        <td><input type=\"checkbox\" /></td>\r\n                        <td>");
                EndContext();
                BeginContext(3213, 12, false);
#line 92 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
                       Write(app.Category);

#line default
#line hidden
                EndContext();
                BeginContext(3225, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(3261, 9, false);
#line 93 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
                       Write(app.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3270, 37, true);
                WriteLiteral("</td>\r\n                        <td>\r\n");
                EndContext();
#line 95 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
                                 foreach (var y in app.Genres)
                                {

#line default
#line hidden
                BeginContext(3406, 53, true);
                WriteLiteral("\t\t\t\t\t\t\t\t   <div>\r\n                                   ");
                EndContext();
                BeginContext(3460, 1, false);
#line 98 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
                              Write(y);

#line default
#line hidden
                EndContext();
                BeginContext(3461, 21, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t   </div>\r\n");
                EndContext();
#line 100 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
                                }

#line default
#line hidden
                BeginContext(3517, 61, true);
                WriteLiteral("                        </td>\r\n\r\n                        <td>");
                EndContext();
                BeginContext(3579, 38, false);
#line 103 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"
                       Write(app.ReleaseDate.ToString("MM-dd-yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(3617, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 105 "C:\Users\Warren Sinor\Desktop\ReleaseReminder\ReleaseReminder\Views\Home\Forms.cshtml"

                }
            

#line default
#line hidden
                BeginContext(3687, 34, true);
                WriteLiteral("\r\n        </table>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReleaseReminder.Models.Reminder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
