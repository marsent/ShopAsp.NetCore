#pragma checksum "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c7fcb761e58031f492d1e8e39fab757c329467e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\_ViewImports.cshtml"
using ShopAsp.NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\_ViewImports.cshtml"
using ShopAsp.NetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7fcb761e58031f492d1e8e39fab757c329467e", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9098f54567468412c515e90dfb562b8684dcdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 120px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("cart1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"cart\" class=\"py-3\">\r\n    <div class=\"container-fluid w-75\">\r\n        <h5 class=\"font-baloo font-size-20\">Giỏ Hàng</h5>\r\n        <div class=\"row\">\r\n            <div class=\"col-xl-9 \">\r\n");
#nullable restore
#line 10 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                 foreach (var item in ViewData["CartItems"] as IEnumerable<ShopAsp.NetCore.Models.CartItem>)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row border-top py-3 mt-3\">\r\n                        <div class=\"col-xl-2 col-md-3\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7fcb761e58031f492d1e8e39fab757c329467e5769", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c7fcb761e58031f492d1e8e39fab757c329467e5985", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 609, "~/assets/products/", 609, 18, true);
#nullable restore
#line 14 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 627, item.Product.ImageUrl, 627, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                                                                WriteLiteral(item.Product.Id);

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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-xl-8 col-md-9\">\r\n                            <h5 class=\"font-baloo font-size-20\">");
#nullable restore
#line 17 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                            <div class=""d-flex"">
                                <div class=""rating text-warning font-size-12"">
                                    <span><i class=""fas fa-star""></i></span>
                                    <span><i class=""fas fa-star""></i></span>
                                    <span><i class=""fas fa-star""></i></span>
                                    <span><i class=""fas fa-star""></i></span>
                                    <span><i class=""far fa-star""></i></span>
                                </div>
                            </div>
                            <div class=""qty d-flex pt-2"">
                                <div class=""d-flex font-rale w-25"">
                                    <button class=""qty-up border bg-light""");
            BeginWriteAttribute("onclick", " onclick=\"", 1686, "\"", 1775, 6);
            WriteAttributeValue("", 1696, "addToCart(", 1696, 10, true);
#nullable restore
#line 29 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1706, item.Cart.UserId, 1706, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1723, ",", 1723, 1, true);
#nullable restore
#line 29 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 1724, Html.DisplayFor(modelItem => item.Product.Id), 1725, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1771, ",", 1771, 1, true);
            WriteAttributeValue(" ", 1772, "1)", 1773, 3, true);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"pro1\"><i class=\"fas fa-angle-up\"></i></button>\r\n                                    <input style=\"min-width: 30px\" type=\"text\" data-id=\"pro1\" class=\"qty_input border px-2 w-100 bg-light\" disabled");
            BeginWriteAttribute("value", " value=\"", 1981, "\"", 2038, 1);
#nullable restore
#line 30 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1989, Html.DisplayFor(modelItem => item.Cart.Quantity), 1989, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"1\">\r\n                                    <button data-id=\"pro1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2116, "\"", 2236, 6);
            WriteAttributeValue("", 2126, "addToCart(", 2126, 10, true);
#nullable restore
#line 31 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2136, Html.DisplayFor(modelItem => item.Cart.UserId), 2136, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2183, ",", 2183, 1, true);
#nullable restore
#line 31 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 2184, Html.DisplayFor(modelItem => item.Product.Id), 2185, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2231, ",", 2231, 1, true);
            WriteAttributeValue(" ", 2232, "-1)", 2233, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"qty-down border bg-light\"><i class=\"fas fa-angle-down\"></i></button>\r\n                                </div>\r\n                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2394, "\"", 2527, 6);
            WriteAttributeValue("", 2404, "addToCart(", 2404, 10, true);
#nullable restore
#line 33 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2414, Html.DisplayFor(modelItem => item.Cart.UserId), 2414, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2461, ",", 2461, 1, true);
#nullable restore
#line 33 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 2462, Html.DisplayFor(modelItem => item.Product.Id), 2463, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2509, ",", 2509, 1, true);
            WriteAttributeValue(" ", 2510, "-$row[quantity])", 2511, 17, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn font-baloo text-danger px-3 ml-3"">Xóa</button>
                            </div>
                        </div>
                        <div class=""col-xl-2 col-md text-right"">
                            <div class=""font-size-20 text-danger font-baloo"">
                                <span class=""product_price price"">");
#nullable restore
#line 38 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-xl-3\">\r\n                <div class=\"sub-total border text-center mt-2\">\r\n                    <h6 class=\"border-bottom font-size-12 font-rale text-success py-3\"><i class=\"fas fa-check\"></i>");
#nullable restore
#line 46 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                                                                                              Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <div class=\"py-4\">\r\n                        <h5 class=\"font-baloo font-size-20\">Tổng đơn hàng (");
#nullable restore
#line 48 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                                                      Write(ViewData["Quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sản phẩm):&nbsp; <span class=\"text-danger\"><span class=\"text-danger price\" id=\"deal-price\">");
#nullable restore
#line 48 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                                                                                                                                                                       Write(ViewData["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </span> </h5>
                        <a href=""../thanh-toan"" role=""button"" type=""submit"" class=""btn btn-success text-white mt-3"">Tiến hành đặt hàng</a>
                    </div>
                </div>
            </div>
        </div>
</section>
<section id=""new-phone"">
    <div class=""container py-5"">
        <h4 class=""font-rubik font-size-20"">Sản Phẩm Mới</h4>
        <hr>
        <div class=""owl-carousel owl-theme owl-loaded owl-drag"">
            <div class=""owl-stage-outer"">
                <div class=""owl-stage"" style=""transform: translate3d(-552px, 0px, 0px); transition: all 0s ease 0s; width: 2141px;"">
");
#nullable restore
#line 62 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                     foreach (var item in ViewData["HotProducts"] as IEnumerable<ShopAsp.NetCore.Models.Product>)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"owl-item\">\r\n                            <div class=\"item py-2\">\r\n                                <div class=\"product font-rale\">\r\n                                    <a href=\"../chi-tiet-san-pham/\"><img");
            BeginWriteAttribute("src", " src=\"", 4568, "\"", 4618, 1);
#nullable restore
#line 67 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 4574, Html.DisplayFor(modelItem => item.ImageUrl), 4574, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n                                    <div class=\"text-center\">\r\n                                        <h6 style=\"margin-top: 15px\">");
#nullable restore
#line 69 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                        <div class=""rating text-warning font-size-12"">
                                            <span><i class=""fas fa-star""></i></span>
                                            <span><i class=""fas fa-star""></i></span>
                                            <span><i class=""fas fa-star""></i></span>
                                            <span><i class=""fas fa-star""></i></span>
                                            <span><i class=""far fa-star""></i></span>
                                        </div>
                                        <div class=""price py-2"">
                                            <span> ");
#nullable restore
#line 78 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <button type=\"submit\" name=\"top_sale_submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5688, "\"", 5771, 6);
            WriteAttributeValue("", 5698, "addToCart(", 5698, 10, true);
#nullable restore
#line 80 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5708, ViewData["UserId"], 5708, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5727, ",", 5727, 1, true);
#nullable restore
#line 80 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 5728, Html.DisplayFor(modelItem => item.Id), 5729, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5767, ",", 5767, 1, true);
            WriteAttributeValue(" ", 5768, "1)", 5769, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning font-size-12\">Thêm vào giỏ</button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 85 "C:\Users\Anh\Desktop\ShopAsp.NetCore\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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