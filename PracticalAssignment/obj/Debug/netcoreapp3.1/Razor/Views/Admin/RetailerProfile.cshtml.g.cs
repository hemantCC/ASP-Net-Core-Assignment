#pragma checksum "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a266d3c9df90fc2d50eee2cccac7d6d6b2b7fa68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RetailerProfile), @"mvc.1.0.view", @"/Views/Admin/RetailerProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a266d3c9df90fc2d50eee2cccac7d6d6b2b7fa68", @"/Views/Admin/RetailerProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab13922bd79b1f383231b803c701fb3d21530eb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RetailerProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PracticalAssignment.Models.BusinessEntity.RetailerVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
  
    ViewData["Title"] = "RetailerProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center display-4 mb-2"">Retailers Profile</div>

<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>
                ID
            </th>
            <th>
                PersonalEmail
            </th>
            <th>
                BusinessEmail
            </th>
            <th>
                ContactNumber
            </th>
            <th>
                Address1
            </th>
            <th>
                Address2
            </th>
            <th>
                City
            </th>
            <th>
                State
            </th>
            <th>
                Zipcode
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 41 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
         foreach (var retailer in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.PersonalEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.BusinessEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
               Write(Html.DisplayFor(modelItem => retailer.Zipcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Admin\RetailerProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PracticalAssignment.Models.BusinessEntity.RetailerVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
