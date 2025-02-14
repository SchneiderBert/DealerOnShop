#pragma checksum "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ead72ccde9f2b23b3e4723676c2032cb50b4ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Receipt), @"mvc.1.0.view", @"/Views/Home/Receipt.cshtml")]
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
#line 1 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\_ViewImports.cshtml"
using DealerOnShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\_ViewImports.cshtml"
using DealerOnShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ead72ccde9f2b23b3e4723676c2032cb50b4ec", @"/Views/Home/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78515bd0cac13ea27184f4c304f8c07298f051b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
  
    ViewData["Title"] = "Receipt";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <h1>Thank you for shopping at DealerOnShop</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
      double total = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
      double tax = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
      double subTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
     if (Enumerable.Count(ViewBag.cart) == 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>No items in cart</h3>\r\n        <a class=\"btn btn-primary \" href=\"/\">Home</a>\r\n");
#nullable restore
#line 19 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
    } else {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mt-4 \">\r\n\r\n        <h3>Here is your receipt</h3>\r\n");
#nullable restore
#line 24 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
         foreach (var prod in @ViewBag.cart)
        {
            total += prod.Quantity*prod.product.Price;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
             if (prod.Quantity > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 29 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
             Write(prod.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(": (");
#nullable restore
#line 29 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                                  Write(prod.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("@ $");
#nullable restore
#line 29 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                                                     Write(prod.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(") </span>  \r\n");
#nullable restore
#line 30 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 31 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                 Write(prod.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(": $");
#nullable restore
#line 31 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                                      Write(prod.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  \r\n");
#nullable restore
#line 32 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br>\r\n");
#nullable restore
#line 34 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 36 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"

        {tax = total*0.1;}
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                                      
        {tax = Math.Round(tax*20)/20;}
        {subTotal = Math.Round(total, 2);}
        {total+=tax;}
        {total = Math.Round(total, 2);}
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" >\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\">SubTotal: $");
#nullable restore
#line 46 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                                                  Write(subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Tax: $");
#nullable restore
#line 47 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                                             Write(tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Total: $");
#nullable restore
#line 48 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
                                               Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n        <a class=\"btn btn-primary mt-4\" href=\"/\">Home</a>\r\n");
#nullable restore
#line 52 "C:\Users\snite\Desktop\Coding\code_tests\DealerOnShop\Views\Home\Receipt.cshtml"
            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
