#pragma checksum "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2051b35f42a6615e51f4134fbf3bf39ace3fadce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devis_FormulaireDevis1), @"mvc.1.0.view", @"/Views/Devis/FormulaireDevis1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2051b35f42a6615e51f4134fbf3bf39ace3fadce", @"/Views/Devis/FormulaireDevis1.cshtml")]
    public class Views_Devis_FormulaireDevis1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModels.DevisViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/fleche_droite_verte_redim.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("suivant"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Page Suivante"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDeconnecte.cshtml";
    ViewBag.Title = "Formulaire Devis 1";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-left"">

    
        <div class=""container"">
            <div class=""col-10"">
                <h3 class=""section-title"">Demande de devis</h3>
                Merci de bien vouloir renseigner vos coordonnées pour toute demande de devis.
            </div><br />
            <form action=""/Devis/FormulaireDevis2"">
                <div class=""form-group row"">
                    <label for=""NomSociete"" class=""col-sm-2 col-form-label"">Nom de la Société</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 18 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.NomEntreprise,new { @class= "form-control", style= "margin-top: 10px", placeholder = "Nom de la Société" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""NumeroSiret"" class=""col-sm-2 col-form-label"">Numéro de Siret</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 26 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m=> m.MainEntreprise.Siret, new { @class = "form-control", style = "margin-top: 10px", placeholder = "N° Siret" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""AdresseDeLaSociete"" class=""col-sm-2 col-form-label"">Adresse de la Société</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 34 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.Adresse.AdresseLieu, new { @class = "form-control", style = "margin-top: 10px", placeholder = "Adresse de la société" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""CP"" class=""col-sm-2 col-form-label"">Code Postal</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 42 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.Adresse.CPLieu, new { @class = "form-control", style = "margin-top: 10px", placeholder = "Code Postal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group row\">\r\n                    <label for=\"Ville\" class=\"col-sm-2 col-form-label\">Ville</label>\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 50 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.Adresse.VilleLieu, new { @class = "form-control", style = "margin-top: 10px", placeholder = "Ville" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""NomInterlocuteur"" class=""col-sm-2 col-form-label"">Nom de l'Interlocuteur</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 58 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.UtilisateurEntreprise.NomUtilisateur, new { @class = "form-control", style = "margin-top: 10px", placeholder = "Nom de l'interlocuteur" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""PrenomInterlocuteur"" class=""col-sm-2 col-form-label"">Prénom de l'Interlocuteur</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 66 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.UtilisateurEntreprise.PrenomUtilisateur, new { @class = "form-control", style = "margin-top: 10px", placeholder = "Prénom de l'interlocuteur" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""Fonction"" class=""col-sm-2 col-form-label"">Fonction</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 74 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.UtilisateurEntreprise.FonctionUtilisateur, new { @class = "form-control", style = "margin-top: 10px", placeholder = "Fonction dans la société" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""Telephone"" class=""col-sm-2 col-form-label"">Téléphone</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 82 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.UtilisateurEntreprise.TelephoneUtilisateur, new { @class = "form-control", style = "margin-top: 10px", placeholder = "Téléphone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>

                <div class=""form-group row"">
                    <label for=""Email"" class=""col-sm-2 col-form-label"">E-mail</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 90 "C:\Users\pemel\source\repos\projet2\Mega_20210526_18h\WebApplication1\Views\Devis\FormulaireDevis1.cshtml"
                   Write(Html.TextBoxFor(m => m.MainEntreprise.UtilisateurEntreprise.Mail, new { @class = "form-control", style = "margin-top: 10px", placeholder = "E-mail" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n                <div align=\"right\" style=\"padding-top: 20px\">\r\n                    <button align=\"right\" class=\"button1\" type=\"submit\" id=\"image\" name=\"submit\" value=\"suivant\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2051b35f42a6615e51f4134fbf3bf39ace3fadce12111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n\r\n");
            WriteLiteral("                </div>              \r\n\r\n\r\n            </form>\r\n\r\n        </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModels.DevisViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
