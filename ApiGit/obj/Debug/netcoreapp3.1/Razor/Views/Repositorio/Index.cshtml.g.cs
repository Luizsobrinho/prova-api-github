#pragma checksum "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d94ab3269f362f69cc7a09ca3dfd6862015697e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repositorio_Index), @"mvc.1.0.view", @"/Views/Repositorio/Index.cshtml")]
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
#line 1 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\_ViewImports.cshtml"
using ApiGit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\_ViewImports.cshtml"
using ApiGit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94ab3269f362f69cc7a09ca3dfd6862015697e4", @"/Views/Repositorio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000f733b3a713ba876b850f109812d9627cb7d32", @"/Views/_ViewImports.cshtml")]
    public class Views_Repositorio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiGit.Models.Repositorio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
  
    ViewData["Title"] = "Repositorio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content-inner"">

    <div class=""card"">

        <div class=""card-body"">

            <div class=""col-sm-11"">
                <h4 class=""header-title"">Repositorios Detalhes</h4>
            </div>

            <table class=""table table-striped table-hover"">

                <thead>

                    <tr class=""success text-black-50"">
                        <th scope=""col"" style=""text-align:center"">
                            ");
#nullable restore
#line 23 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\" style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Linguagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\" style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 29 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\" style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 32 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\" style=\"text-align:center\">\r\n                            Favoritar\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td style=\"text-align:center\">\r\n                                ");
#nullable restore
#line 46 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"text-align:center\">\r\n                                ");
#nullable restore
#line 49 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"text-align:center\">\r\n                                ");
#nullable restore
#line 52 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Linguagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"text-align:center\">\r\n                                ");
#nullable restore
#line 55 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"text-align:center\">\r\n                                <a>");
#nullable restore
#line 58 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                              Write(Html.ActionLink(@String.Format("Favoritar"), "Favoritar", "Repositorio", new { url = item.Url }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\luizs\source\repos\ApiGit\ApiGit\Views\Repositorio\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiGit.Models.Repositorio>> Html { get; private set; }
    }
}
#pragma warning restore 1591