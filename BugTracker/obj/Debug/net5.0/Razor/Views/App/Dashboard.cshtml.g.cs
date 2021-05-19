#pragma checksum "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5115a1930fa7b3c37938a2cc79087f17b38c529a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Dashboard), @"mvc.1.0.view", @"/Views/App/Dashboard.cshtml")]
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
#line 1 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5115a1930fa7b3c37938a2cc79087f17b38c529a", @"/Views/App/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb963595ef037321403c61bc382e41e24ceab2c", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml"
  
    ViewBag.Title = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Projects:</h4>\r\n<p>Count: ");
#nullable restore
#line 6 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml"
     Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\r\n            <div class=\"border bg-light rounded p-2\">\r\n                <i class=\"fas fa-project-diagram fa-2x\"></i> Project ID: ");
#nullable restore
#line 12 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml"
                                                                    Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <ul>\r\n                    <li>Name: ");
#nullable restore
#line 14 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml"
                         Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Desc: ");
#nullable restore
#line 15 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml"
                         Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n                <button id=\"expandBtn\" class=\"btn btn-info\">Expand</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Waqas\source\repos\BugTracker\BugTracker\Views\App\Dashboard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591