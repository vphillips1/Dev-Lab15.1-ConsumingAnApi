#pragma checksum "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9f70a3b2b5a2bb56df6cda8283eb1a3a512ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CardGame_Index), @"mvc.1.0.view", @"/Views/CardGame/Index.cshtml")]
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
#line 1 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\_ViewImports.cshtml"
using Lab15._1ConsumingAnApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\_ViewImports.cshtml"
using Lab15._1ConsumingAnApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9f70a3b2b5a2bb56df6cda8283eb1a3a512ec5", @"/Views/CardGame/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd3ff12253f3a0957d533857ac9a4411783f6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_CardGame_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CardSet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<h1>Results</h1>\r\n\r\nDeck Id: ");
#nullable restore
#line 13 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
    Write(Model.deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nRemaining: ");
#nullable restore
#line 15 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
      Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 18 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
 foreach (Card ca in Model.cards)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Suit: ");
#nullable restore
#line 20 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
          Write(ca.suit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Value: ");
#nullable restore
#line 21 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
           Write(ca.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 456, "\"", 471, 1);
#nullable restore
#line 22 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
WriteAttributeValue("", 462, ca.image, 462, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <br/>\r\n");
#nullable restore
#line 24 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 541, 2);
            WriteAttributeValue("", 503, "/CardGame/Index?deck_id=", 503, 24, true);
#nullable restore
#line 27 "C:\Users\vphillips\dev\Lab15.1ConsumingAnApi\Lab15.1ConsumingAnApi\Views\CardGame\Index.cshtml"
WriteAttributeValue("", 527, Model.deck_id, 527, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Draw 5 cards !</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CardSet> Html { get; private set; }
    }
}
#pragma warning restore 1591
