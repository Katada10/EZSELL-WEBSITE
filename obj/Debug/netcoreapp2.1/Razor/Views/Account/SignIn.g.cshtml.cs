#pragma checksum "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a900b6adcc6312cdd6648fa7927a406e986425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignIn), @"mvc.1.0.view", @"/Views/Account/SignIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SignIn.cshtml", typeof(AspNetCore.Views_Account_SignIn))]
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
#line 1 "C:\Users\katad\Solution\MyApp\Views\_ViewImports.cshtml"
using MyApp;

#line default
#line hidden
#line 2 "C:\Users\katad\Solution\MyApp\Views\_ViewImports.cshtml"
using MyApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a900b6adcc6312cdd6648fa7927a406e986425", @"/Views/Account/SignIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11677bef14cb8a5c5f02f7f352b9baf0a6209476", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignInModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
  
    ViewData["Title"] = "Sign In";

#line default
#line hidden
            BeginContext(63, 42, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Sign In</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
 using (Html.BeginForm("SignIn", "Account", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(176, 23, false);
#line 10 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(203, 251, true);
            WriteLiteral("    <div class=\"container\" style=\"max-width:370px; border: 1px solid #dddddd; border-radius:10px; margin-top: 20px;\">\r\n\r\n        <div class=\"row text-center\" style=\"margin-top: 20px;\">\r\n            <div class=\"form-group col-sm-12 \">\r\n                ");
            EndContext();
            BeginContext(455, 30, false);
#line 16 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
            EndContext();
            BeginContext(485, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(504, 65, false);
#line 17 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.TextBoxFor(m => m.Username, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(569, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(588, 78, false);
#line 18 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.ValidationMessageFor(m => m.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(666, 143, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row text-center\">\r\n            <div class=\"form-group col-sm-12\">\r\n                ");
            EndContext();
            BeginContext(810, 30, false);
#line 24 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(840, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(859, 85, false);
#line 25 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(944, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(963, 78, false);
#line 26 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-inline\">\r\n                ");
            EndContext();
            BeginContext(1119, 61, false);
#line 29 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.CheckBoxFor(m => m.StaySigned, new { @class="checkbox"}));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1199, 53, false);
#line 30 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
           Write(Html.LabelFor(m => m.StaySigned, "Keep Me Logged In"));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 351, true);
            WriteLiteral(@"
            </div>
            <a href=""#"" class=""btn-link text-center"">Forgot Password?</a>
            <button style=""margin-top:30px;"" class=""btn btn-primary col-xs-8 col-xs-offset-2"" type=""submit"">Sign In</button>
        </div>
        <hr />
        <div class=""row text-center"">
            <h5>
                Don't Have An Account? ");
            EndContext();
            BeginContext(1603, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c203ff7ed26c4688a23c8b6d771fccff", async() => {
                BeginContext(1682, 14, true);
                WriteLiteral("Create One Now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1700, 49, true);
            WriteLiteral("\r\n            </h5>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 42 "C:\Users\katad\Solution\MyApp\Views\Account\SignIn.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignInModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
