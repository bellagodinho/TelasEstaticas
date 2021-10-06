#pragma checksum "D:\Users\bella\source\repos\ScreensWeDancin\Pages\SignUp\CreateProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d7886b0eca67ae507cbbfe97a7acc8e6517630"
// <auto-generated/>
#pragma warning disable 1591
namespace ScreensWeDancin.Pages.SignUp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using ScreensWeDancin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using ScreensWeDancin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\bella\source\repos\ScreensWeDancin\_Imports.razor"
using ScreensWeDancin.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createprofile")]
    public partial class CreateProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .page {\r\n        height: 100%;\r\n        width: 100%;\r\n    }\r\n\r\n    .box-text {\r\n        font: 400 12px/14.4px \"Lato\";\r\n        letter-spacing: -0.02em;\r\n        color: #413A42;\r\n        margin: 5px;\r\n    }\r\n\r\n    .box-titles {\r\n        font: 400 20px/23.46px \"Work Sans\";\r\n        letter-spacing: -0.02em;\r\n        color: #413A42;\r\n        display: flex;\r\n        align-items: center;\r\n        margin-bottom: 16px;\r\n    }\r\n\r\n    .grid-2 {\r\n        display: grid;\r\n        grid-template-columns: auto;\r\n        grid-template-rows: 364px 586px auto;\r\n        grid-gap: 24px;\r\n    }\r\n\r\n    .profile-grid {\r\n        display: grid;\r\n        grid-template-columns: 30% 65%;\r\n        grid-gap: 24px;\r\n        justify-content: center;\r\n        position: absolute;\r\n        top: 226px;\r\n        max-width: 1140px;\r\n        padding-bottom: 50px;\r\n        z-index: 3;\r\n    }\r\n\r\n    .publish-button {\r\n        position: absolute;\r\n        left: 77.7%;\r\n        top: 1014px;\r\n        width: 219px;\r\n        height: 58px;\r\n        display: flex;\r\n        flex-direction: row;\r\n        justify-content: center;\r\n        align-items: center;\r\n        color: #aba8ac;\r\n    }\r\n\r\n    .white-box {\r\n        height: fit-content;\r\n        padding: 24px;\r\n        background: #FFFFFF;\r\n        box-shadow: 0px 1px 5px rgba(66, 0, 74, 0.22), 0px 0.385185px 1.59259px rgba(66, 0, 74, 0.13363), 0px 0.0814815px 0.407407px rgba(66, 0, 74, 0.0863704);\r\n        border-radius: 20px;\r\n    }\r\n\r\n    #avatar-placeholder {\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        position: relative;\r\n        width: 96px;\r\n        height: 96px;\r\n        margin: 12px auto;\r\n        background: #F5F5F5;\r\n        border-radius: 20px;\r\n    }\r\n\r\n    .curriculumTextarea {\r\n        padding-top: 50px !important;\r\n    }\r\n        .curriculumTextarea:focus {\r\n            padding-top: 50px !important;\r\n        }\r\n\r\n    #upper-text {\r\n        position: relative;\r\n        top: 80px;\r\n        min-width: 1100px;\r\n        width: max-content;\r\n        z-index: 3;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<header>
    <img src=""/images/Lines/create-profile.svg"" alt=""Linhas orgânicas coloridas"" style=""position: absolute; top: 0; right: 0; z-index: 1;"">
    <img src=""/images/Brand/Logo.svg"" alt=""Logo We Dancin"" style=""position: relative; top: 20px; left: 10.2%;"">
</header>


");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "display: flex; flex-direction: column; align-items: center;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<div id=\"upper-text\">\r\n        <h2>@Name</h2>\r\n        <p>Preencha seu perfil público para atrair e se conectar aos alunos.</p>\r\n    </div>\r\n    ");
            __builder.OpenElement(6, "section");
            __builder.AddAttribute(7, "class", "profile-grid");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "white-box");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<div id=\"avatar-placeholder\">\r\n                <i class=\"bi-person-plus\" style=\"font-size: 70px; color: #ACACAC;\"></i>\r\n            </div>\r\n\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", "display: flex; flex-direction: column;");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "form");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.AddMarkupContent(18, @"<div class=""form-floating"">
                        <input type=""text"" class=""form-control on-surface active-placeholder"" id=""floatingText"" placeholder=""Nome artístico"">
                        <label for=""floatingText"">Nome de usuário</label>
                    </div>
                    ");
            __builder.AddMarkupContent(19, @"<div class=""form-floating"" style=""margin-top: 24px;"">
                        <input type=""text"" class=""form-control on-surface active-placeholder"" id=""floatingInput"" placeholder=""@usuário"">
                        <label for=""floatingInput"">@usuário</label>
                    </div>");
            __builder.AddMarkupContent(20, @"<div class=""form-floating"" style=""margin-top: 24px;"">
                        <input type=""text"" class=""form-control on-surface active-placeholder"" id=""floatingInput"" placeholder=""Instagram (opcional)"">
                        <label for=""floatingInput"">Instagram (opcional)</label>
                        <p class=""box-text"">O conteúdo disponível no feed do Instagram estará disponível no seu perfil de professor.</p>
                    </div>
                    ");
            __builder.AddMarkupContent(21, @"<div class=""form-floating"" style=""margin-top: 24px;"">
                        <input type=""text"" class=""form-control on-surface active-placeholder"" id=""floatingInput"" placeholder=""TikTok (opcional)"">
                        <label for=""floatingInput"">TikTok (opcional)</label>
                        <p class=""box-text"">O conteúdo disponível no feed do TikTok estará disponível no seu perfil de professor.</p>
                    </div>
                    ");
            __builder.AddMarkupContent(22, @"<div class=""form-floating"" style=""margin-top: 24px;"">
                        <input type=""text"" class=""form-control on-surface active-placeholder"" id=""floatingInput"" placeholder=""Cidade"">
                        <label for=""floatingInput"">Cidade</label>
                    </div>
                    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-floating");
            __builder.AddAttribute(25, "style", "margin-top: 24px;");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "class", "form-select on-surface active-placeholder");
            __builder.AddAttribute(29, "id", "floatingSelect");
            __builder.AddAttribute(30, "aria-label", "Floating label select example");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "style", "border-radius: 20px;");
            __builder.AddAttribute(34, "selected", true);
            __builder.AddContent(35, "Minas Gerais");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "RJ");
            __builder.AddContent(39, "Rio de Janeiro");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "SP");
            __builder.AddMarkupContent(43, "São Paulo");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "RO");
            __builder.AddContent(47, "Roraima");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.AddMarkupContent(50, "<label for=\"floatingSelect\">Estado</label>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n        ");
            __builder.AddMarkupContent(55, "<div class=\"grid-2\">\r\n            <div class=\"white-box\">\r\n                <div class=\"box-titles\">\r\n                    Sobre você\r\n                </div>\r\n                <div style=\"display: flex; flex-direction: column;\">\r\n                    <form>\r\n                        <div class=\"form-floating\">\r\n                            <textarea class=\"form-control\" placeholder=\"Conte um pouco sobre você e o que a dança representa.\" id=\"floatingTextarea2\" maxlength=\"120\" style=\"height: 164px\"></textarea>\r\n                            <label for=\"floatingTextarea2\">Conte um pouco sobre você e o que a dança representa.</label>\r\n                        </div>\r\n                        <div class=\"form-floating\" style=\"margin-top: 16px;\">\r\n                            <input class=\"form-control\" list=\"datalistOptions\" id=\"floatingExampleDataList\" placeholder=\"Encontre (a)s modalidade(s) de dança que você vai oferecer aos alunos.\">\r\n                            <datalist id=\"datalistOptions\">\r\n                                <option value=\"San Francisco\"></option>\r\n                                <option value=\"New York\"></option>\r\n                            </datalist>\r\n                            <label for=\"floatingExampleDataList\">Encontre (a)s modalidade(s) de dança que você vai oferecer aos alunos.</label>\r\n                        </div>\r\n                    </form>\r\n                </div>\r\n                <div class=\"box-text\">\r\n                    Caso não encontre alguma modalidade específica, entre em contato com o nosso suporte pelo e-mail: <a>suporte@wedancin.com.br</a>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"white-box\">\r\n                <div class=\"box-titles\">\r\n                    Sua carreira\r\n                </div>\r\n                <div style=\"display: flex; flex-direction: column;\">\r\n                    <form>\r\n                        <div class=\"form-floating\">\r\n                            <textarea class=\"form-control curriculumTextarea\" placeholder=\"Escreva seu currículo profissional, citando experiências, capacitações, cursos, eventos/workshops etc.\" id=\"floatingTextarea2\" maxlength=\"120\" style=\"height: 300px\"></textarea>\r\n                            <label for=\"floatingTextarea2\">Escreva seu currículo profissional, citando experiências, capacitações, cursos, eventos/workshops etc.</label>\r\n                        </div>\r\n                        <div class=\"form-floating\" style=\"margin-top: 24px;\">\r\n                            <textarea class=\"form-control\" placeholder=\"Informações adicionais.\" id=\"floatingTextarea2\" maxlength=\"120\" style=\"height: 183px\"></textarea>\r\n                            <label for=\"floatingTextarea2\">Informações adicionais.</label>\r\n                        </div>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n            <div style=\"display: flex; flex-direction: column; align-items: end;\"><button class=\"dark-red-button long-button\" style=\"width: 219px; margin-top: 20px;\">Cadastrar</button></div>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
