#pragma checksum "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8483767e188545c0fe46a74fb9b63be0e5ae4357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerWiseOrder), @"mvc.1.0.view", @"/Views/Customer/CustomerWiseOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8483767e188545c0fe46a74fb9b63be0e5ae4357", @"/Views/Customer/CustomerWiseOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab13922bd79b1f383231b803c701fb3d21530eb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerWiseOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PracticalAssignment.Models.BusinessEntity.OrderDetailVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
  
    ViewData["Title"] = "CustomerWiseOrder";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center display-4\">My Orders</h1>\r\n<table class=\"table table-striped table-bordered table-responsive-md table-responsive-sm table-responsive-xl \">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Product.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Product.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8483767e188545c0fe46a74fb9b63be0e5ae43578179", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
                   WriteLiteral("~/image/"+product.Product.Photo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 48 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.Product.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.Unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
               Write(Html.DisplayFor(modelItem => product.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 75 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center display-3\">\r\n        You have no order to see\r\n    </div>\r\n");
#nullable restore
#line 80 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
  
    if (TempData["OrderPlaced"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script>
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: 'Order Placed!',
                showConfirmButton: false,
                timer: 1500
            })
        </script>
");
#nullable restore
#line 93 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\CustomerWiseOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PracticalAssignment.Models.BusinessEntity.OrderDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
