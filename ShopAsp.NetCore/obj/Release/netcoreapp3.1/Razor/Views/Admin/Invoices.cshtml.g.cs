#pragma checksum "/home/anh/MyProject/ShopAsp.NetCore/ShopAsp.NetCore/Views/Admin/Invoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474d423c6c836ebaa6db45f43bb06617a9d7490d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Invoices), @"mvc.1.0.view", @"/Views/Admin/Invoices.cshtml")]
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
#line 1 "/home/anh/MyProject/ShopAsp.NetCore/ShopAsp.NetCore/Views/_ViewImports.cshtml"
using ShopAsp.NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/anh/MyProject/ShopAsp.NetCore/ShopAsp.NetCore/Views/_ViewImports.cshtml"
using ShopAsp.NetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"474d423c6c836ebaa6db45f43bb06617a9d7490d", @"/Views/Admin/Invoices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8227967664398b56f519109965b5a081d0b915bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Invoices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/anh/MyProject/ShopAsp.NetCore/ShopAsp.NetCore/Views/Admin/Invoices.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class="" row p-0 m-0"">

    <div class=""col-6"">
        <h2 class=""text-info"">Danh sách hóa đơn</h2>
    </div>

    <div class=""col-12 border p-3 container"">
        <table class=""table table-bordered"" id=""Invoices_load"" width=""100%"" style=""text-align:center"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Mã hóa đơn</th>
                    <th>Khách hàng</th>
                    <th>Điện thoại</th>
                    <th>Địa chỉ</th>
                    <th>Ngày lập</th>
                    <th>Vận chuyển</th>
                    <th>Tình trạng thanh toán</th>
                    <th>Tổng tiền</th>
                    <th>Action</th>
                </tr>
            </thead>
        </table>
    </div>


</div>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
