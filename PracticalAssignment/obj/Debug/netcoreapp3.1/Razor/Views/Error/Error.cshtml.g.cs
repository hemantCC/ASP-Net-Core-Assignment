#pragma checksum "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Error\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2de2656fb22476dbe7a433f053245afe2c01b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Error), @"mvc.1.0.view", @"/Views/Error/Error.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\_ViewImports.cshtml"
using PracticalAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\_ViewImports.cshtml"
using PracticalAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2de2656fb22476dbe7a433f053245afe2c01b5f", @"/Views/Error/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab13922bd79b1f383231b803c701fb3d21530eb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Error\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row mx-5\">\r\n        <div class=\"display-3\">An Error has Occured while processing your Request. We will Solve it in soon. </div>\r\n        <div class=\"alert alert-danger\">\r\n            <strong>Exception Path: </strong> ");
#nullable restore
#line 9 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Error\Error.cshtml"
                                         Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div><br />\r\n        <div class=\"alert alert-danger\">\r\n            <strong>Exception Message: </strong> ");
#nullable restore
#line 12 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Error\Error.cshtml"
                                            Write(ViewBag.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div><br />\r\n        <div class=\"alert alert-danger\">\r\n            <div>\r\n                <strong>Note: This Alert is only for Development Purpose.</strong>\r\n            </div>\r\n            <strong>Exception Stack Trace: </strong> ");
#nullable restore
#line 18 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Error\Error.cshtml"
                                                Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
