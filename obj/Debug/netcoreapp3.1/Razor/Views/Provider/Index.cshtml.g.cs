#pragma checksum "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "766ecbcef7fc377a22116c0e8b420191a54ef867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Provider_Index), @"mvc.1.0.view", @"/Views/Provider/Index.cshtml")]
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
#line 1 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/_ViewImports.cshtml"
using globalsolution.fomezero;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/_ViewImports.cshtml"
using globalsolution.fomezero.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"766ecbcef7fc377a22116c0e8b420191a54ef867", @"/Views/Provider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607efa8a344757e8f2631061e94f6734623b19b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Provider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Provider>
    {
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
        private global::globalsolution.fomezero.TagHelpers.MessageTagHelper __globalsolution_fomezero_TagHelpers_MessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("message", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766ecbcef7fc377a22116c0e8b420191a54ef8673522", async() => {
            }
            );
            __globalsolution_fomezero_TagHelpers_MessageTagHelper = CreateTagHelper<global::globalsolution.fomezero.TagHelpers.MessageTagHelper>();
            __tagHelperExecutionContext.Add(__globalsolution_fomezero_TagHelpers_MessageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
   WriteLiteral(TempData["msg"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __globalsolution_fomezero_TagHelpers_MessageTagHelper.Text = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("text", __globalsolution_fomezero_TagHelpers_MessageTagHelper.Text, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""card mb-3"" style=""max-width: 30rem;"">
    <h4 class=""card-header"">Dados de Cadastro</h4>
    <div class=""card-body"">
        <div class=""form-group mt-4"">
            <p class=""user-label"">No. Documento</p>
            <p class=""user-txt-value"">");
#nullable restore
#line 14 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.Document);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"form-group mt-4\">\n            <p class=\"user-label\">Nome</p>\n            <p class=\"user-txt-value\">");
#nullable restore
#line 18 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"form-group mt-4\">\n            <p class=\"user-label\">E-mail</p>\n            <p class=\"user-txt-value\">");
#nullable restore
#line 22 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"form-group mt-4\">\n            <p class=\"user-label\">Telefone</p>\n            <p class=\"user-txt-value\">");
#nullable restore
#line 26 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"form-group mt-4\">\n            <p class=\"user-label\">Endereço</p>\n            <p class=\"user-txt-value\">");
#nullable restore
#line 30 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"form-group mt-4\">\n            <p class=\"user-label\">Cidade</p>\n            <p class=\"user-txt-value\">");
#nullable restore
#line 34 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"form-group mt-4\">\n            <p class=\"user-label\" h6>Estado</p>\n            <p class=\"user-txt-value\">");
#nullable restore
#line 38 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"form-group mt-4\">\n            <p class=\"user-label\">País</p>\n            <p class=\"user-txt-value\">");
#nullable restore
#line 42 "/Users/daniloboccomino/Desktop/FIAP85473/2TDSA/enterpriseApplication/ws.net/br.com.fiap.ead/globalsolution.fomezero/Views/Provider/Index.cshtml"
                                 Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Provider> Html { get; private set; }
    }
}
#pragma warning restore 1591
