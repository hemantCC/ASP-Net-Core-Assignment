#pragma checksum "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50acd005753b1281654df1eec90091b9a6598fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50acd005753b1281654df1eec90091b9a6598fed", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab13922bd79b1f383231b803c701fb3d21530eb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PracticalAssignment.Models.BusinessEntity.ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top c-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("180"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("268"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-4 col-5 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuySingleProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-4 col-5 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card:hover {
        -webkit-box-shadow: -1px 9px 40px -12px rgba(0,0,0,0.75);
        -moz-box-shadow: -1px 9px 40px -12px rgba(0,0,0,0.75);
        box-shadow: -1px 9px 40px -12px rgba(0,0,0,0.75);
    }
</style>
<h2 class=""text-center alert alert-light"">All Products</h2>
<hr />
<div class=""row"">
");
#nullable restore
#line 16 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
         using (Html.BeginForm("AddOrder", "Customer", FormMethod.Post))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
       Write(Html.HiddenFor(model => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 mt-3\">\r\n                <div class=\"card alert alert-dark\" style=\"width: 18rem;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "50acd005753b1281654df1eec90091b9a6598fed7846", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                WriteLiteral("~/image/"+item.Photo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <div>\r\n                            <h4 class=\"card-title text-center\">");
#nullable restore
#line 28 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                        <hr />\r\n                        <div>\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1191, "\"", 1199, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <span><strong>Price: </strong>");
#nullable restore
#line 33 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                         Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>&#8377;</span></span>\r\n                            </div>\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1378, "\"", 1386, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <strong>Category: </strong> ");
#nullable restore
#line 36 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                       Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1534, "\"", 1542, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <strong>Units: </strong> ");
#nullable restore
#line 39 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                    Write(item.Unit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <strong>Quantity: </strong>
                            <div class=""btn-group mt-2"">
                                <button href=""#"" class=""btn btn-secondary sub""><i class=""fa fa-minus"" ></i></button>
                                <input id=""InputQuantity"" type=""text"" name=""Quantity"" value=""1"" class=""form-control btn quantity"" />
                                <button href=""#"" class=""btn btn-secondary add"" ><i class=""fa fa-plus""></i></button>

                            </div>
                        </div>
                        <div class=""row d-flex justify-content-between"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50acd005753b1281654df1eec90091b9a6598fed13188", async() => {
                WriteLiteral(" Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
AddHtmlAttributeValue("", 2333, item.ProductId, 2333, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                                                                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50acd005753b1281654df1eec90091b9a6598fed16155", async() => {
                WriteLiteral("\r\n                            <i class=\"fa fa-cart-plus mr-2\" style=\"font-size:23px;\"></i>Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
AddHtmlAttributeValue("", 2516, item.ProductId, 2516, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2531, "+", 2531, 1, true);
#nullable restore
#line 51 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
AddHtmlAttributeValue("", 2532, item.ProductId, 2532, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                                                                                                                    WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 56 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                              
                                if (@item.Status == "Out of Stock")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""text-danger border border-danger col-md-12 mt-2"" style=""background-color:lightcoral;"">Out of Stock</div>
                                    <script>
                                            document.getElementById(""");
#nullable restore
#line 61 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                                Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = true;\r\n                                            document.getElementById(\"");
#nullable restore
#line 62 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                                Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("+");
#nullable restore
#line 62 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                                                                Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").disabled = true;\r\n                                    </script>\r\n");
#nullable restore
#line 64 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 71 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
<script type=""text/javascript"">
    $('.add').click(function () {
        var target = $('.quantity', this.parentNode)[0];
        target.value = +target.value + 1;
        return false;
    });
    $('.sub').click(function () {
        var target = $('.quantity', this.parentNode)[0];
        if (target.value > 1) {
            target.value = +target.value - 1;
        }
        return false;
    });

</script>


");
            }
            );
#nullable restore
#line 96 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
  
    if (TempData["PlaceOrder"] != null)
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
#line 108 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
    }

    if (TempData["AlreadyExists"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script>
            Swal.fire({
                position: 'top-end',
                icon: 'error',
                title: 'Item Already Exists!',
                showConfirmButton: false,
                timer: 1500
            })
        </script>
");
#nullable restore
#line 121 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
    }
    if (TempData["LoginSuccess"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script>
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: 'Login Successful!',
                showConfirmButton: false,
                timer: 1500
            })
        </script>
");
#nullable restore
#line 133 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
    }
    if (TempData["AddToCart"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script>
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: 'Added To Cart!',
                showConfirmButton: false,
                timer: 1500
            })
        </script>
");
#nullable restore
#line 145 "C:\Users\DELL\Desktop\PracticalAssignment\PracticalAssignment\Views\Customer\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PracticalAssignment.Models.BusinessEntity.ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
