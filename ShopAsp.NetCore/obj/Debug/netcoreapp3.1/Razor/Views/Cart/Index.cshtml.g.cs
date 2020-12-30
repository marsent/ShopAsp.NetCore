#pragma checksum "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1a28bbfaadd0fa168ea5fb6deefe91033aee1c7"
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
#line 1 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\_ViewImports.cshtml"
using ShopAsp.NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\_ViewImports.cshtml"
using ShopAsp.NetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a28bbfaadd0fa168ea5fb6deefe91033aee1c7", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9098f54567468412c515e90dfb562b8684dcdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<section id=\"cart\" class=\"py-3\">\r\n    <div class=\"container-fluid w-75\">\r\n        <h5 class=\"font-baloo font-size-20\">Giỏ Hàng</h5>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 44 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
             foreach (var item in ViewData["CartItems"] as IEnumerable<ShopAsp.NetCore.Models.CartItem>)
            {
                RenderCartItem(item);
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
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
#line 58 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                     foreach (var item in ViewData["HotProducts"] as IEnumerable<ShopAsp.NetCore.Models.Product>)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"owl-item\">\r\n                            <div class=\"item py-2\">\r\n                                <div class=\"product font-rale\">\r\n                                    <a href=\"../chi-tiet-san-pham/\"><img");
            BeginWriteAttribute("src", " src=\"", 3616, "\"", 3666, 1);
#nullable restore
#line 63 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3622, Html.DisplayFor(modelItem => item.ImageUrl), 3622, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></a>\r\n                                    <div class=\"text-center\">\r\n                                        <h6 style=\"margin-top: 15px\">");
#nullable restore
#line 65 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
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
#line 74 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ</span>
                                        </div>
                                        <button type=""submit"" name=""top_sale_submit"" onclick=""addToCart($userId, $row[item_id], 1)"" class=""btn btn-warning font-size-12"">Thêm vào giỏ</button>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 81 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
           
    public void RenderCartItem(CartItem item)
    {

#line default
#line hidden
#nullable disable
        WriteLiteral("        <div class=\"row border-top py-3 mt-3\">\r\n            <div class=\"col-xl-2 col-md-3\">\r\n                <a");
        BeginWriteAttribute("href", " href=\"", 224, "\"", 286, 2);
        WriteAttributeValue("", 231, "/Product/", 231, 9, true);
#nullable restore
#line 10 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 240, Html.DisplayFor(modelItem => item.Product.Id), 240, 46, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral("><img");
        BeginWriteAttribute("src", " src=\"", 292, "\"", 350, 1);
#nullable restore
#line 10 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 298, Html.DisplayFor(modelItem => item.Product.ImageUrl), 298, 52, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(" style=\"height: 120px;\" alt=\"cart1\" class=\"img-fluid\"></a>\r\n            </div>\r\n            <div class=\"col-xl-8 col-md-9\">\r\n                <h5 class=\"font-baloo font-size-20\">");
#nullable restore
#line 13 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Product.Name));

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
        BeginWriteAttribute("onclick", " onclick=\"", 1237, "\"", 1363, 6);
        WriteAttributeValue("", 1247, "addToCartReload((", 1247, 17, true);
#nullable restore
#line 25 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1264, Html.DisplayFor(modelItem => item.Cart.UserId), 1264, 47, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 1311, ",", 1311, 1, true);
#nullable restore
#line 25 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 1312, Html.DisplayFor(modelItem => item.Product.Id), 1313, 46, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 1359, ",", 1359, 1, true);
        WriteAttributeValue(" ", 1360, "1)", 1361, 3, true);
        EndWriteAttribute();
        WriteLiteral(" data-id=\"pro1\"><i class=\"fas fa-angle-up\"></i></button>\r\n                        <input style=\"min-width: 30px\" type=\"text\" data-id=\"pro1\" class=\"qty_input border px-2 w-100 bg-light\" disabled");
        BeginWriteAttribute("value", " value=\"", 1557, "\"", 1614, 1);
#nullable restore
#line 26 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1565, Html.DisplayFor(modelItem => item.Cart.Quantity), 1565, 49, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(" placeholder=\"1\">\r\n                        <button data-id=\"pro1\"");
        BeginWriteAttribute("onclick", " onclick=\"", 1680, "\"", 1807, 6);
        WriteAttributeValue("", 1690, "addToCartReload((", 1690, 17, true);
#nullable restore
#line 27 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1707, Html.DisplayFor(modelItem => item.Cart.UserId), 1707, 47, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 1754, ",", 1754, 1, true);
#nullable restore
#line 27 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 1755, Html.DisplayFor(modelItem => item.Product.Id), 1756, 46, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 1802, ",", 1802, 1, true);
        WriteAttributeValue(" ", 1803, "-1)", 1804, 4, true);
        EndWriteAttribute();
        WriteLiteral(" class=\"qty-down border bg-light\"><i class=\"fas fa-angle-down\"></i></button>\r\n                    </div>\r\n                    <button");
        BeginWriteAttribute("onclick", " onclick=\"", 1941, "\"", 2081, 6);
        WriteAttributeValue("", 1951, "addToCartReload((", 1951, 17, true);
#nullable restore
#line 29 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1968, Html.DisplayFor(modelItem => item.Cart.UserId), 1968, 47, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 2015, ",", 2015, 1, true);
#nullable restore
#line 29 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
WriteAttributeValue(" ", 2016, Html.DisplayFor(modelItem => item.Product.Id), 2017, 46, false);

#line default
#line hidden
#nullable disable
        WriteAttributeValue("", 2063, ",", 2063, 1, true);
        WriteAttributeValue(" ", 2064, "-$row[quantity])", 2065, 17, true);
        EndWriteAttribute();
        WriteLiteral(@" class=""btn font-baloo text-danger px-3 ml-3"">Xóa</button>
                </div>
            </div>
            <div class=""col-xl-2 col-md text-right"">
                <div class=""font-size-20 text-danger font-baloo"">
                    <span class=""product_price"">");
#nullable restore
#line 34 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Product.Price));

#line default
#line hidden
#nullable disable
        WriteLiteral(" đ</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "C:\wamp64\www\Framework\ShopAsp.NetCore\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
