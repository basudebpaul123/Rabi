#pragma checksum "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4977e06b90d97ff860bb9526083124b9296ec74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\_ViewImports.cshtml"
using Lost_and_Found;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\_ViewImports.cshtml"
using Lost_and_Found.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4977e06b90d97ff860bb9526083124b9296ec74", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d594b62fa2743d1f06a9b3f9a7e7d5f8a0e87e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Lost_and_Found.Models.Lostitem>, List<Lost_and_Found.Models.Founditem>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Lost_Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Found_Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
  
    ViewData["Title"] = "Recent Posts";
    Layout = "~/Views/Shared/_Layout.cshtml"; // If you have a layout

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    /* Add this CSS to your stylesheet */
    table.table {
        width: 100%;
        border-collapse: collapse;
        margin-bottom: 20px;
        border: 1px solid #ccc;
        box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        margin-top: 20px;
        margin-bottom: 20px;
    }

        table.table th,
        table.table td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        table.table th {
            background-color: #f5f5f5;
            font-weight: bold;
        }

        table.table tbody tr:hover {
");
            WriteLiteral(@"            background-color: #545B62;
            color: #fff;
        }
  
        table.table img {
            max-width: 150px;
            height: auto;
            border: 1px solid #ddd;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }


    a {
        color: #007bff;
        text-decoration: none;
    }

        a:hover {
            text-decoration: underline;
        }

    p {
        margin: 10px 0;
    }

    /* Optional: Add padding and center content */
    .container {
        padding: 20px;
        text-align: center;
    }
    .description-cell {
        white-space: normal; /* Wrap long text */
        word-wrap: break-word; /* Break words that exceed cell width */
        max-width: 300px; /* Adjust the maximum width as needed */
    }
    .table-bordered-light th,
    .table-bordered-light td {
        border: 1px solid #f0f0f0; /* Light gray color */
    }

</style>

<button type=""button"" class=""btn btn-secondary btn-lg btn-block active"">Recent Posts</button>
<br />
<but");
            WriteLiteral("ton class=\"btn btn-outline-primary btn-lg active\">Lost Items</button>\n<br />\n");
#nullable restore
#line 79 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
 if (Model.Item1.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered-light"">
        <thead>
            <tr>
                <th>Item Name</th>
                <th>Category</th>
                <th>Description</th>
                <th>Lost Area</th>
                <th>Lost Date</th>
                <th>Image</th>
                <th>Action</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 95 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
             foreach (var item in Model.Item1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 98 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 99 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.ItemCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"description-cell\">");
#nullable restore
#line 100 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 101 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.LostArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 102 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2735, "\"", 2777, 1);
#nullable restore
#line 105 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
WriteAttributeValue("", 2741, Url.Content("~/img/" + @item.Image), 2741, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Lost Item Image\" width=\"200\" />\n\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4977e06b90d97ff860bb9526083124b9296ec749612", async() => {
                WriteLiteral("<i class=\"fas fa-eye\"></i> Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                                                                                          WriteLiteral(item.ItemId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 112 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 115 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-danger\">No Post available</p>\n");
#nullable restore
#line 119 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<button class=\"btn btn-outline-primary btn-lg active\">Found Items</button>\n<br />\n");
#nullable restore
#line 124 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
 if (Model.Item2.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered-light"">
        <thead>
            <tr>
                <th>Item Name</th>
                <th>Category</th>
                <th>Description</th>
                <th>Found Area</th>
                <th>Found Date</th>
                <th>Image</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 139 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
             foreach (var item in Model.Item2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 142 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 143 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.ItemCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"description-cell\">");
#nullable restore
#line 144 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 145 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.FoundArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 146 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4046, "\"", 4088, 1);
#nullable restore
#line 149 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
WriteAttributeValue("", 4052, Url.Content("~/img/" + @item.Image), 4052, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Lost Item Image\" width=\"200\" />\n\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4977e06b90d97ff860bb9526083124b9296ec7415507", async() => {
                WriteLiteral("<i class=\"fas fa-eye\"></i> Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
                                                                                           WriteLiteral(item.ItemId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 156 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 159 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-danger\">No Post available.</p>\n");
#nullable restore
#line 163 "C:\Users\Administrator\source\repos\Lost_and_Found\Views\Home\Post.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4977e06b90d97ff860bb9526083124b9296ec7418509", async() => {
                WriteLiteral("HOME");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Lost_and_Found.Models.Lostitem>, List<Lost_and_Found.Models.Founditem>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
