#pragma checksum "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea6cf2ea019022f88a4eb6cf363d30ac4c98846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OverView), @"mvc.1.0.view", @"/Views/Admin/OverView.cshtml")]
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
#line 6 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
using MixueShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea6cf2ea019022f88a4eb6cf363d30ac4c98846", @"/Views/Admin/OverView.cshtml")]
    #nullable restore
    public class Views_Admin_OverView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ea6cf2ea019022f88a4eb6cf363d30ac4c988462972", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""/css/overview.css"" />

    <title>Mixue</title>
    <style>
        ion-icon {
            padding-right: 5px;
            margin: auto;
        }
    </style>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css""
          integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ea6cf2ea019022f88a4eb6cf363d30ac4c988464555", async() => {
                WriteLiteral(@"
    <div class=""header"">
        <div class=""inheader"">
            <div class=""menu"">
                <ul>
                    <li>
                        <a href=""/Home/ViewProduct"">
                            <ion-icon name=""storefront""></ion-icon>
                            Shop
                        </a>
                    </li>
                    <li>
                        <a href=""/Admin/OverView"">
                            <ion-icon name=""stats-chart""></ion-icon>
                            Statisctic
                        </a>
                    </li>
                    <li class=""active"">
                        <a href=""/Admin/ListOrders"">
                            <ion-icon name=""settings""></ion-icon>
                            Manage
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            Account
                        </a>
                    </li>

          ");
                WriteLiteral(@"      </ul>
            </div>
        </div>
    </div>
    <div class=""content"">
        <div class=""right"">
            <div class=""cart"">
                <div class=""cartContact"">
                    <div style=""margin: auto 0;display: flex;"">
                        <h4 style=""margin:auto;"">Overview</h4>
                    </div>
                    
                </div>
                <div style=""height: 90%;"">
                    <div class=""listProduct"" style=""display: flex;"">


                        <div style=""width: 30%;border-right: 1px solid #d4b5b5;margin: 20px auto;"">
                            <h4 style=""text-align: center;"">Income</h4>
                            <h6 style=""text-align: left;"">Total Order: ");
#nullable restore
#line 76 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                                                  Write(ViewBag.totalOrder);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            <h6 style=\"text-align: left;\">Total money have earned: ");
#nullable restore
#line 77 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                                                              Write(ViewBag.totalEarned);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                        </div>
                        <div style=""width: 50%;margin:20px auto;"">
                            <h4 style=""text-align: center;""> Top 3 Products Buy Most</h4>
                            <br />
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th style=""border-top: none;"" scope=""col"">Top</th>
                                        <th style=""border-top: none;"" scope=""col"">Product Name</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 90 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                      
                                        int i = 1;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                     foreach (Product pro in @ViewBag.products)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <th style=\"border-top: none;\" scope=\"row\">#");
#nullable restore
#line 96 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                                                                  Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 97 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                              
                                                i++;
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>");
#nullable restore
#line 100 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                           Write(pro.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 102 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Admin\OverView.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>
    <script>
        function changeCate() {
            //kick hoat submit cho form tren
            document.getElementById(""listPro"").submit();
        }
        function changeDirectProduct() {
            var x = document.getElementById(""directPageProduct"").value;
            console.log(x);
            window.location = x;
        }
        function changeDirectOrder() {
            var x = document.getElementById(""directPageOrder"").value;
            console.log(x);
            window.location = x;
        }
    </script>
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/n");
                WriteLiteral(@"pm/popper.js@1.12.9/dist/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
    <script type=""module"" src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js""></script>
    <script nomodule src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
