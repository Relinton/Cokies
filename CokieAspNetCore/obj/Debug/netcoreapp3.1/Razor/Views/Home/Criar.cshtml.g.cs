#pragma checksum "D:\Relinton Sistemas\CokieAspNetCore\CokieAspNetCore\Views\Home\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecabb725bf01085fcec201e190512f3bba157b50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Criar), @"mvc.1.0.view", @"/Views/Home/Criar.cshtml")]
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
#line 1 "D:\Relinton Sistemas\CokieAspNetCore\CokieAspNetCore\Views\_ViewImports.cshtml"
using CokieAspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Relinton Sistemas\CokieAspNetCore\CokieAspNetCore\Views\_ViewImports.cshtml"
using CokieAspNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecabb725bf01085fcec201e190512f3bba157b50", @"/Views/Home/Criar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15acf191495e9813b46fffcc95e275f8ed8b839d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Relinton Sistemas\CokieAspNetCore\CokieAspNetCore\Views\Home\Criar.cshtml"
  
    ViewData["Title"] = "Criar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header card-header-text card-header-info"">
        <div class=""card-text"">
            <h4 class=""card-title"">Avaliação</h4>
        </div>
    </div>
    <div class=""card-body"" id=""painel-enquete"">
        <div class=""card-title"">
            <h4>Sua opinião é muito importante para nós, deixe aqui sua avaliação do Portal da Transparência</h4>
            <div class=""form-check form-check-radio form-check-inline"">
                <input type=""radio"" name=""opcao"" value=""1"" />Péssimo<br />
            </div>
            <div class=""form-check form-check-radio form-check-inline"">
                <input type=""radio"" name=""opcao"" value=""2"" />Ruim<br />
            </div>
            <div class=""form-check form-check-radio form-check-inline"">
                <input type=""radio"" name=""opcao"" value=""3"" />Indiferente<br />
            </div>
            <div class=""form-check form-check-radio form-check-inline"">
                <input type=""radio"" name=""opca");
            WriteLiteral(@"o"" value=""4"" />Bom<br />
            </div>
            <div class=""form-check form-check-radio form-check-inline"">
                <input type=""radio"" name=""opcao"" value=""5"" />Ótimo<br />
            </div>
        </div>

        <div class=""panel-footer"">
            <button class=""btn btn-success"" id=""btnEnviarEnquete"">Enviar</button>
        </div>
    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(function () {
            $(""#btnEnviarEnquete"").click(function () {
                var opc = $(""#painel-enquete input[type=radio]:checked"").val();
                $.ajax({
                    type: ""POST"",
                    url: ""Criar"",
                    data: { opcao: opc }
                }).done(function (msg) {
                    $(""#painel-enquete .card-title"").html(""<p>"" + msg + ""<p>"");
                    $(""#painel-enquete .panel-footer"").hide();
                    $(""#graficoPizza .div"").html();
                });
            });

        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
