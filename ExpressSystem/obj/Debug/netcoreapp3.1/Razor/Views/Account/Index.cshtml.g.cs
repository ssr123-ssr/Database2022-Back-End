#pragma checksum "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33e9c384afb356d73935ed01f3382191ff8fa2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\_ViewImports.cshtml"
using ExpressSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\_ViewImports.cshtml"
using ExpressSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\_ViewImports.cshtml"
using ExpressSystem.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e9c384afb356d73935ed01f3382191ff8fa2a", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe18acb0857a8d1abc32f8e9ae962298f5a804e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <input type=\"button\" onclick=\"show()\" value=\"点击测试\"/>\r\n    <label id=\"demo\">这里是</label>\r\n\r\n    <table>\r\n\r\n        <tr>\r\n            <th>账号</th>\r\n            <th>密码</th>\r\n            <th>角色</th>\r\n        </tr>\r\n\r\n\r\n\r\n");
#nullable restore
#line 22 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml"
         foreach (var user in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml"
               Write(user.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp</td>\r\n                <td>");
#nullable restore
#line 28 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml"
               Write(user.PASSWORD);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp</td>\r\n                <td>");
#nullable restore
#line 29 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml"
               Write(user.ROLE);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function show() {\r\n            /*在js中使用加单引号\'\'   好像不加也行*/\r\n            if(");
#nullable restore
#line 42 "E:\软件工程\大二下\数据库原理与应用\暑假课设\Application\ExpressSystem\Views\Account\Index.cshtml"
          Write(Model.First().ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" == \"2053699\")\r\n                document.getElementById(\"demo\").innerHTML = \"success\";\r\n            else\r\n                document.getElementById(\"demo\").innerHTML = \'failure\';\r\n        }\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
