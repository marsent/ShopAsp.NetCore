#pragma checksum "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541b64b6f35ab9a4063841d604b59db0332005b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\_ViewImports.cshtml"
using ShopAsp.NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\_ViewImports.cshtml"
using ShopAsp.NetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541b64b6f35ab9a4063841d604b59db0332005b4", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9098f54567468412c515e90dfb562b8684dcdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopAsp.NetCore.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("transform: scale(1);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onmouseover", new global::Microsoft.AspNetCore.Html.HtmlString("this.style=\'transform:scale(0.95,0.95)\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onmouseout", new global::Microsoft.AspNetCore.Html.HtmlString("this.style=\'transform:scale(1,1)\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("product_submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/product-detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section id=\"product\" class=\" py-5\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\" col-lg-6\" id=\"SP_img\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "541b64b6f35ab9a4063841d604b59db0332005b46807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 387, Html.DisplayFor(model => model.Name), 387, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 431, "~/assets/products/", 431, 18, true);
#nullable restore
#line 11 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 449, Html.DisplayFor(model => model.ImageUrl), 449, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            <div class=\" col-lg-6 py-5\" id=\"SP_P\">\r\n                <h1 class=\"font-baloo\">");
#nullable restore
#line 13 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <small style=\"font-size:12px; font-style:italic\"> by ");
#nullable restore
#line 14 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                <hr class=""m-0"">
                <div class=""row"" style=""margin-top:20px"">
                    <div class=""col-6 col-lg-5 font-rale"" style=""font-size:16px;""> Giá gốc: </div>
                    <div class=""col-6 col-lg-7 font-rale"" style=""font-size:16px;""> <strike class=""price"">");
#nullable restore
#line 18 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
                                                                                                    Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strike> </div>\r\n                    <div class=\"col-6 col-lg-5 font-rale\" style=\"font-size:18px;margin-top:15px\">Giá khuyến mãi: </div>\r\n                    <div class=\"col-6 col-lg-7 font-rale\"><span class=\"price text-danger\" style=\"font-size:26px;\">");
#nullable restore
#line 20 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
                                                                                                             Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> <br><small class=""text-dark font-size-12"">&nbsp;&nbsp;Bao gồm VAT 10%</small></div>
                </div>
                <div id=""policy"">
                    <div class=""d-flex"">
                        <div class=""return text-center"" style=""margin-right: 3.5rem !important;"">
                            <div class=""font-size-20 my-2 color-second""><span class=""fas fa-retweet border p-3 rounded-pill""></span></div>
                            <span class=""font-rale font-size-14"" style=""color:blue"">10 ngày <br> đổi trả</span>
                        </div>
                        <div class=""return text-center "" style=""margin-right: 3.5rem !important;"">
                            <div class=""font-size-20 my-2 color-second""><span class=""fas fa-truck  border p-3 rounded-pill""></span></div>
                            <span class=""font-rale font-size-14"" style=""color:blue"">Giao hàng <br>tận nơi</span>
                        </div>
                        <div class=""return text-center"" style");
            WriteLiteral(@"=""margin-right: 3.5rem !important;"">
                            <div class=""font-size-20 my-2 color-second""><span class=""fas fa-check-double border p-3 rounded-pill""></span></div>
                            <span class=""font-rale font-size-14"" style=""color:blue"">Bảo hành <br>1 năm</span>
                        </div>
                    </div>
                </div>
                <hr>
                <div class=""col-12"" style=""margin:15px auto;""><button");
            BeginWriteAttribute("onclick", " onclick=\"", 2872, "\"", 2952, 6);
            WriteAttributeValue("", 2882, "addToCart(", 2882, 10, true);
#nullable restore
#line 39 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
WriteAttributeValue("", 2892, ViewData["UserId"], 2892, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2911, ",", 2911, 1, true);
#nullable restore
#line 39 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
WriteAttributeValue(" ", 2912, Html.DisplayFor(model => model.Id), 2913, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2948, ",", 2948, 1, true);
            WriteAttributeValue(" ", 2949, "1)", 2950, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning font-size-16 form-control\">Thêm vào giỏ hàng</button></div>\r\n                <div class=\"col-12\" style=\"margin:15px auto;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "541b64b6f35ab9a4063841d604b59db0332005b413754", async() => {
                WriteLiteral("Mua ngay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3112, "addToCart(", 3112, 10, true);
#nullable restore
#line 40 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 3122, ViewData["UserId"], 3122, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3141, ",", 3141, 1, true);
#nullable restore
#line 40 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
AddHtmlAttributeValue(" ", 3142, Html.DisplayFor(model => model.Id), 3143, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3178, ",", 3178, 1, true);
            AddHtmlAttributeValue(" ", 3179, "1)", 3180, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </div>
            </div>
            <div class=""col-12"" id=""SP_D"" style=""margin:2.5rem 0rem"">
                <h6 class=""font-baloo"" style=""text-shadow: black; font-size: 24px; font-style: initial ;"">Mô tả</h6>
                <hr>
                <p>");
#nullable restore
#line 45 "D:\Project\tymobile\tymobile\ShopAsp.NetCore\Views\Products\Details.cshtml"
              Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
</section>
<section id=""top-sale"">
    <div class=""container py-5"">
        <h4 class=""font-rubik font-size-20"">Khuyến Mãi Hot</h4>
        <hr>
        <div class=""owl-carousel owl-theme owl-loaded owl-drag"">
            <div class=""owl-stage-outer"">
                <div class=""owl-stage"" style=""transform: translate3d(-552px, 0px, 0px); transition: all 0s ease 0s; width: 2141px;"">

                </div>
            </div>
        </div>
    </div>
</section>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "541b64b6f35ab9a4063841d604b59db0332005b417339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    window.onload = function () {
        const queryString = window.location.search;
        const urlParams = new URLSearchParams(queryString);
        const id = urlParams.get('id');
        // alert(id);
        $.ajax({
            type: ""POST"",
            url: ""chitiet.php"",
            data: {
                id: id
            },
            success: function (response) {
                $('#product').html(response);
            }
        });

    }
    $(document).ready(function () {

        $(""#banner-area .owl-carousel"").owlCarousel({
            dots: true,
            items: 1
        });

        $("".owl-carousel"").owlCarousel({
            loop: false,
            dots: false,
            responsive: {
                0: {
                    items: 2,
                    nav: false
                },
                600: {
                    items: 3,
                    nav: true
                },
                1000: {
                   ");
            WriteLiteral(@" items: 5,
                    nav: true
                }
            }
        });

        $("".button-group"").on(""click"", ""button"", function () {
            var filterValue = $(this).attr('data-filter');
            $grid.isotope({ filter: filterValue });
        })
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopAsp.NetCore.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
