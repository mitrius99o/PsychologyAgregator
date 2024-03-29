#pragma checksum "C:\Users\Dmitry\Documents\ASP_NET_Core_MVC\PsyAgregator\PsyAgregator\Views\Home\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d9e668c087eef367e89354bdecce7a928fd463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
#line 1 "C:\Users\Dmitry\Documents\ASP_NET_Core_MVC\PsyAgregator\PsyAgregator\Views\_ViewImports.cshtml"
using PsyAgregator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dmitry\Documents\ASP_NET_Core_MVC\PsyAgregator\PsyAgregator\Views\_ViewImports.cshtml"
using PsyAgregator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d9e668c087eef367e89354bdecce7a928fd463", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ad4b283b700fa1c6b9f00e02e08ceae2810a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ph2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block; margin: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dmitry\Documents\ASP_NET_Core_MVC\PsyAgregator\PsyAgregator\Views\Home\AboutUs.cshtml"
  
    ViewData["Title"] = "AboutUs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""display-4"" style=""text-align:center;""><b>О нас</b></h1>

<p align=""justify"" style=""margin-left: 15%; margin-right:15%;"">
    Миссия проекта - помогать людям преодолевать всевозможные психологические проблемы 
    по мере финансовой возможности клиента.
    Основной целью данного проекта является создание агрегатора.

    Особенность проекта представляет собой то, что цена работы договорная между клиентом и терапевтом, 
    что позволит работать по финансовым возможностям клиента (однако не ниже 500 рублей в час, 
    что связано с необходимостью того, что бы у проекта были средства для развития, специалисты 
    получали деньги за свою работу, а также это важно для самого процесса терапии, так он приобретает
    особую ценность и для самого клиента). Также важно отметить, что в проекте будут задействованы 
    квалифицированные специалисты.
    Подбор будет происходить на основании алгоритмов сайта: перед началом работы и клиенты, и 
    терапевты будут проходить небольшое тестирова");
            WriteLiteral(@"ние. Это тестирование, разработанное командой 
    психологов проекта, позволит обеспечить качественный подбор специалистов. Для клиента в 
    тестировании важно узнать в каком функциональном состоянии он находится здесь и сейчас, 
    какие проблемы его беспокоят и какими личностными характеристиками он обладает и хотел бы, 
    чтобы обладал специалист. Для специалистов тестирование будет проходить на определение
    личностных качеств и сфер работы. Также будет вестись личное собеседование с каждым претендентом
    на работу в проекте.
    После прохождения тестирования, клиенту, исходя из его запроса и представлений о терапевте,
    алгоритм предложит ряд наиболее подходящих специалистов, клиент также называет сумму, которую 
    он может заплатить за сеанс. У каждого специалиста будет прописан ряд профессиональных 
    характеристик. Выбрав понравившегося, клиент нажимает “связаться”, в результате чего 
    терапевту поступает сигнал, что к нему пришел клиент. Далее терапевт работает с клиент");
            WriteLiteral("ом.\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3d9e668c087eef367e89354bdecce7a928fd4636249", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"d-grid gap-2\" style=\"margin:15%;\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 2225, "\"", 2260, 1);
#nullable restore
#line 35 "C:\Users\Dmitry\Documents\ASP_NET_Core_MVC\PsyAgregator\PsyAgregator\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 2232, Url.Action("Index", "Home"), 2232, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">На главную</a>\r\n</div>\r\n");
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
