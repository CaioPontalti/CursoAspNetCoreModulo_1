#pragma checksum "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 1\Modulo 1_RazorPages\ProjPages\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da91c22e6564306c39261203a6d494ec58dce98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjPages.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(ProjPages.Pages.Pages_Contact), @"{id:int?}")]
namespace ProjPages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 1\Modulo 1_RazorPages\ProjPages\Pages\_ViewImports.cshtml"
using ProjPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da91c22e6564306c39261203a6d494ec58dce98", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5cce3c7925d13c0fabc28299d6b1b6a1f02b67", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 1\Modulo 1_RazorPages\ProjPages\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(84, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(89, 17, false);
#line 6 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 1\Modulo 1_RazorPages\ProjPages\Pages\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 13, true);
            WriteLiteral("</h2>\r\n\r\n<h3>");
            EndContext();
            BeginContext(120, 10, false);
#line 8 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 1\Modulo 1_RazorPages\ProjPages\Pages\Contact.cshtml"
Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(130, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
            BeginContext(140, 13, false);
#line 10 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 1\Modulo 1_RazorPages\ProjPages\Pages\Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(153, 366, true);
            WriteLiteral(@"


<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
