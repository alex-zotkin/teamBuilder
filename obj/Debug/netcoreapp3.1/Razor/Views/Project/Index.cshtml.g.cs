#pragma checksum "C:\Users\PC Master\Desktop\Проект КОНСТРУКТОР КОМАНД\TeamBuilder\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1563b96f86dbffdfe5b2c2c1f942cde8c1ea343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "C:\Users\PC Master\Desktop\Проект КОНСТРУКТОР КОМАНД\TeamBuilder\Views\_ViewImports.cshtml"
using TeamBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC Master\Desktop\Проект КОНСТРУКТОР КОМАНД\TeamBuilder\Views\_ViewImports.cshtml"
using TeamBuilder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1563b96f86dbffdfe5b2c2c1f942cde8c1ea343", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15b89ea05c964198ec05415b907ee84874fb63c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/project.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/project.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1563b96f86dbffdfe5b2c2c1f942cde8c1ea3434159", async() => {
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
            WriteLiteral(@"

<br /><br /><br />
            <h2></h2>

<div id=""app"" v-cloak>
    <delete_alert v-if=""deleteAlert"" v-on:deletealert=""deletealert""></delete_alert>

    <add_admin v-if=""addAdminBox""
               :notadminsproject=""notadminsproject""
               :adminsproject=""adminsproject""
               v-on:addadmin=""addadmin""
               v-on:deleteadmin=""deleteadmin""></add_admin>

    <info v-if=""infoBool"" v-bind:infoposition=""infoposition"" v-bind:infodata=""infoData""></info>

    <div class=""project_actions_box"">
        <h3 v-if=""!editMode"">{{data.Project.Name}}</h3>
        <input id=""projectName"" v-else type=""text"" placeholder=""Название проектной деятельности"" :value=""data.Project.Name"">

        <div class=""admin_actions"" v-if=""data.IsUserAdmin"">
            <div class=""button button_red"" v-if=""!editMode"" v-on:click=""deleteAlert=true"">Удалить ПД</div>
            <div class=""button button_green"" v-if=""!editMode"" v-on:click=""StartEdit"">Редактировать</div>
            <div class=""butt");
            WriteLiteral(@"on button_grey"" v-else v-on:click=""EndEdit"">Сохранить</div>
        </div>
    </div>

    <div class=""user_list_box"">
        <h5>Администраторы</h5>
        <ul>
            <li v-on:mousemove=""ShowInfo($event, admin)"" v-for=""admin in data.ProjectAdmins""
                v-on:mouseleave=""infoBool = false"">
                <a :href=""admin.VkId"">
                    <img :src=""admin.Photo50"">
                    <p>{{admin.FirstName}} {{admin.LastName}}</p>
                </a>
            </li>
            <li class=""button button_green add_admin_button"" v-on:click=""addAdminBox = true"">
                Редактировать </br> администраторов
            </li>
        </ul>
        <h5>Пользователи, <br> вступившие в команды</h5>
        <ul>

            <li v-on:mousemove=""ShowInfo"" v-for=""user in data.UsersInTeams""
                v-on:mouseleave=""infoBool = false"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1992, "\"", 1999, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <img src=""https://sun1-47.userapi.com/impf/c854024/v854024599/8f279/w7IVcGx88UE.jpg?size=200x0&quality=90&crop=283,16,547,547&sign=0d5373c07f96976b45dc87a36d7eb61c&ava=1"">
                    <p>Александр Зоткин</p>
                </a>
            </li>

        </ul>
    </div>

    <div class=""project_list"" v-if=""data.IsUserAdmin"">
        <div class=""team team_disabled"" v-if=""!editMode"" v-for=""n in 5"">
            <h3 style=""cursor:default;"">Команда {{n}}</h3>
            <p v-if=""!editMode"">Пока ни один студент <br> не вступил в данную команду</p>
            <h2 v-if=""!editMode"">3 Х 2</h2>
        </div>

        <div class=""team team_disabled"" v-else>
            <input type=""text"" placeholder=""Название команды"" value=""Команда #n"" style=""text-align: center;"">

            <div class=""editSizeInput"">
                <div class=""label"">
                    <label>1 курс</label>
                    <input type=""number"" value=""3"">
                </div>
       ");
            WriteLiteral(@"         <h2>Х</h2>
                <div class=""label"">
                    <label>2 курс</label>
                    <input type=""number"" value=""2"">
                </div>
            </div>
        </div>




        <div class=""team add_team"" v-if=""editMode"">
            <h1>+</h1>
            <p>Добавить команды</p>
        </div>

    </div>

</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1563b96f86dbffdfe5b2c2c1f942cde8c1ea3438941", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
