#pragma checksum "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1abb0d03804d1d3d40bd7999a62585ddd6c1cee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewProduct), @"mvc.1.0.view", @"/Views/Home/ViewProduct.cshtml")]
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
#line 7 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
using MixueShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1abb0d03804d1d3d40bd7999a62585ddd6c1cee", @"/Views/Home/ViewProduct.cshtml")]
    #nullable restore
    public class Views_Home_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1abb0d03804d1d3d40bd7999a62585ddd6c1cee5216", async() => {
                WriteLiteral(@"
	<meta charset=""UTF-8"">
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
	<link rel=""stylesheet"" href=""/css/style.css"">
	<title>Mixue</title>
	<style>
		ion-icon {
			padding-right: 5px;
		}
	</style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1abb0d03804d1d3d40bd7999a62585ddd6c1cee6488", async() => {
                WriteLiteral("\r\n\t<div class=\"header\">\r\n\t\t<div class=\"inheader\">\r\n\t\t\t<div class=\"menu\">\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"active\">\r\n\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t<ion-icon name=\"storefront\"></ion-icon>\r\n\t\t\t\t\t\t\tShop\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n");
#nullable restore
#line 37 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     if (@ViewBag.Role == 1)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t<a href=\"/Admin/ListOrders\">\r\n\t\t\t\t\t\t\t\t<ion-icon name=\"settings\"></ion-icon>\r\n\t\t\t\t\t\t\t\tManage\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 45 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"

					}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<li>\r\n\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t<ion-icon name=\"person-circle\"></ion-icon>\r\n");
#nullable restore
#line 50 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                             if (@ViewBag.Name != null)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                           Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                             
							}
							else
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<p>Account</p>\r\n");
#nullable restore
#line 57 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n");
#nullable restore
#line 60 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     if (@ViewBag.Name != null)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<li>\r\n\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1abb0d03804d1d3d40bd7999a62585ddd6c1cee9114", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<ion-icon name=\"log-out-outline\"></ion-icon>\r\n\t\t\t\t\t\t\t\tLog out\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 69 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"content\">\r\n\t\t<div class=\"left\">\r\n\t\t\t<div class=\"cart\">\r\n\t\t\t\t<div class=\"cartContact\">\r\n\t\t\t\t\t<h4 style=\"margin:auto;\">Order Infor</h4>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"inforOrder\">\r\n");
#nullable restore
#line 81 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     if (@ViewBag.carts != null)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1abb0d03804d1d3d40bd7999a62585ddd6c1cee11447", async() => {
                    WriteLiteral(@"
							<table style=""color: white;"">
								<thead>
									<tr>
										<th style=""padding0 10px"">Product</th>
										<th style=""padding0 10px"">Price</th>
										<th style=""padding0 10px"">Quantity</th>
										<th style=""padding0 10px"">Total</th>
										<th style=""padding0 10px"">Remove</th>
									</tr>
								</thead>
								<tbody>
");
#nullable restore
#line 95 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                     foreach (var item in @ViewBag.carts)
									{

#line default
#line hidden
#nullable disable
                    WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"text-align: center;\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 99 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"text-align: center;\">");
#nullable restore
#line 101 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"text-align: center;\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 104 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"text-align: center;\">");
#nullable restore
#line 108 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                       Write(item.TotalMoney);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td style=\"text-align: center;\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1abb0d03804d1d3d40bd7999a62585ddd6c1cee14107", async() => {
                        WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tRemove\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                                                      WriteLiteral(item.Id);

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
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 117 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
									}

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"									
									<tr>
										<td style=""text-align: center;"">
										</td>
										<td style=""text-align: center;""></td>
										<td style=""text-align: center;"">
											<div>
											</div>

										</td>
										<td style=""text-align: center;""></td>
										<td style=""text-align: center;"">
											Amount:	");
#nullable restore
#line 130 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                  Write(ViewBag.Amount);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 136 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"

					}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				</div>
			</div>
			<div class=""acceptOrder"">
				<button class=""action"" onclick=""checkout()"">
					Checkout
				</button>
				<button class=""action"" onclick=""Cancel()"">
					Cancel
				</button>
			</div>
		</div>
		<div class=""right"">
			<div class=""products"">

				<div class=""rightTitle"">
					Product
				</div>
				<div style=""padding:10px"">
					");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1abb0d03804d1d3d40bd7999a62585ddd6c1cee19717", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 157 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                         if (@ViewBag.keySearch == null)
						{

#line default
#line hidden
#nullable disable
                    WriteLiteral("\t\t\t\t\t\t\t<p style=\"display: flex;\">\r\n\t\t\t\t\t\t\t\tTitle: <input style=\"width:90%\" type=\"text\" name=\"searchString\" />\r\n\t\t\t\t\t\t\t\t<input style=\"width:10%\" type=\"submit\" value=\"Search\" />\r\n\t\t\t\t\t\t\t</p>\r\n");
#nullable restore
#line 163 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
                    WriteLiteral("\t\t\t\t\t\t\t<p style=\"display: flex;\">\r\n\t\t\t\t\t\t\t\tTitle: <input style=\"width:90%\" type=\"text\" name=\"searchString\"");
                    BeginWriteAttribute("value", " value=\"", 4053, "\"", 4079, 1);
#nullable restore
#line 167 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 4061, ViewBag.keySearch, 4061, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<input style=\"width:10%\" type=\"submit\" value=\"Search\" />\r\n\t\t\t\t\t\t\t</p>\r\n");
#nullable restore
#line 170 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
						}

#line default
#line hidden
#nullable disable
                    WriteLiteral("\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"forProduct\">\r\n\r\n");
#nullable restore
#line 175 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     foreach (var p in @ViewBag.products)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<button class=\"product\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4312, "\"", 4345, 3);
                WriteAttributeValue("", 4322, "addCart(\'", 4322, 9, true);
#nullable restore
#line 177 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 4331, p.ProductId, 4331, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4343, "\')", 4343, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 178 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                       Write(p.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n");
#nullable restore
#line 180 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"

					}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"categories\">\r\n\t\t\t\t<div class=\"rightTitle\">\r\n\t\t\t\t\tCategory\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 188 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                 if (@ViewBag.selectedCate == 0 || @ViewBag.selectedCate == null)
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<button style=\"background-color: #afaf7d;\" class=\"cate\" onclick=\"changeCate(\'0\')\">All</button>\r\n");
#nullable restore
#line 191 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<button class=\"cate\" onclick=\"changeCate(\'0\')\">All</button>\r\n");
#nullable restore
#line 195 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 198 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                 foreach (var p in @ViewBag.cate)
				{
					if (@ViewBag.selectedCate == p.CateId)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<button style=\"background-color: #afaf7d;\" class=\"cate\"");
                BeginWriteAttribute("value", " value=\"", 4948, "\"", 4965, 1);
#nullable restore
#line 202 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 4956, p.CateId, 4956, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 4966, "\"", 4999, 3);
                WriteAttributeValue("", 4976, "changeCate(\'", 4976, 12, true);
#nullable restore
#line 202 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 4988, p.CateId, 4988, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4997, "\')", 4997, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 202 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                                                                               Write(p.CateName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 203 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<button class=\"cate\"");
                BeginWriteAttribute("value", " value=\"", 5076, "\"", 5093, 1);
#nullable restore
#line 206 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 5084, p.CateId, 5084, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 5094, "\"", 5127, 3);
                WriteAttributeValue("", 5104, "changeCate(\'", 5104, 12, true);
#nullable restore
#line 206 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 5116, p.CateId, 5116, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5125, "\')", 5125, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 206 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                                            Write(p.CateName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 207 "C:\Users\MSI\Desktop\PRN Project\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
					}

				}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
			</div>
		</div>
	</div>
	<script>
		function Cancel(){
		   const URL = `/Cart/Cancel`;
		   window.location=URL;
		}
		function changeCate(cateid){
		   const URL = `/Home/Filter/${cateid}`;
		   window.location=URL;
		}
		function checkout(){
			const URL=""/Cart/CheckoutCart"";
			window.location=URL;
		}
		function addCart(pro){
			const URL=`/Cart/AddToCart/${pro}`;
			window.location=URL;
		}
	</script>
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
