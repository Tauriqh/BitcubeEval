#pragma checksum "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36dc7e5a9cdcabf4b93bdce7aedb4903b0155732"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Profile), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Profile.cshtml")]
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
#line 1 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using BitcubeEvalUsingIdentity.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using BitcubeEvalUsingIdentity.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using BitcubeEvalUsingIdentity.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using BitcubeEvalUsingIdentity.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36dc7e5a9cdcabf4b93bdce7aedb4903b0155732", @"/Areas/Identity/Pages/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe61968b78099fe9da17601a8bcf8508ecc661b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0552ac6cc5af0bbc066d2f8621f8c2f289e180", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 10 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\Account\Profile.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""row"">
    <div class=""col-md-5"">
        <h4>User Details</h4>
        <hr />
        <div class=""row"">
            <div class=""col-md-4"">
                <label>Email Address: </label>
            </div>
            <div class=""col-md-6"">
                <label>");
#nullable restore
#line 21 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\Account\Profile.cshtml"
                  Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <label>First Name: </label>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <label>");
#nullable restore
#line 29 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\Account\Profile.cshtml"
                  Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n        </div><div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <label>Last Name: </label>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <label>");
#nullable restore
#line 36 "C:\Users\tauri\Documents\GitHub\BitcubeEval\BitcubeEvalUsingIdentity\Areas\Identity\Pages\Account\Profile.cshtml"
                  Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel>)PageContext?.ViewData;
        public ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591