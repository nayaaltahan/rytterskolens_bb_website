#pragma checksum "C:\Users\nayaa\OneDrive\Documents\rytterskolens_bb_website\Moms_website\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a951f1eb5329942bc985e17f7def8920a260896a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Moms_website.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(Moms_website.Pages.Pages_Contact), null)]
namespace Moms_website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\nayaa\OneDrive\Documents\rytterskolens_bb_website\Moms_website\Pages\_ViewImports.cshtml"
using Moms_website;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a951f1eb5329942bc985e17f7def8920a260896a", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"408665b09bf4509124f103c4f6c55421eca7ae65", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\nayaa\OneDrive\Documents\rytterskolens_bb_website\Moms_website\Pages\Contact.cshtml"
  
    ViewData["Title"] = Resources._Layout.Contact_us;

#line default
#line hidden
            BeginContext(90, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(95, 17, false);
#line 6 "C:\Users\nayaa\OneDrive\Documents\rytterskolens_bb_website\Moms_website\Pages\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(112, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(124, 13, false);
#line 7 "C:\Users\nayaa\OneDrive\Documents\rytterskolens_bb_website\Moms_website\Pages\Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(137, 1220, true);
            WriteLiteral(@"</h3>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-5"">
            <br><br>
            <h2>Contact us</h2>
            <p>We are looking forward to having you in Rytteskolen Bed &amp; Breakfast. You can use any of the following methods to book your stay.</p>
            <p>Vi ser frem til at have dig i b&amp;b, brug en af følgende metoder til at booke dit ophold</p>
            <div>
                <a href=""tel:004529292231"">+45 29 29 22 31</a>
            </div>
            <br>
            <div>
                <p><a href=""mailto:trinedyhrwiberg@gmail.com"">trinedyhrwiberg@gmail.com</a></p>
            </div>

            <a href=""https://www.airbnb.dk/rooms/20368166""><img class=""rounded"" alt=""airbnb"" src=""images/airbnb.jpg"" width=""30%""></a>
        </div>

        <div class=""col-md-7"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d36619.392285401074!2d12.444465!3d54.995683!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xf7dba2d4d");
            WriteLiteral("32e4935!2sRytterskolens+Bed+and+Kitchen!5e0!3m2!1sen!2sus!4v1538574391948\" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
