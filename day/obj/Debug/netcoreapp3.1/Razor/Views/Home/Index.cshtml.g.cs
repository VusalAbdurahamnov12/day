#pragma checksum "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163371c8b7be9fa6a84e3d77e3f6c78ed3c43447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\day\day\day\Views\_ViewImports.cshtml"
using day;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\day\day\day\Views\_ViewImports.cshtml"
using day.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163371c8b7be9fa6a84e3d77e3f6c78ed3c43447", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450fbd4dbafcfb8804aa5b3edc832ba0dfdeab9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("forms/contact.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"   <header class=""hed"">
        <div class=""container hed "">
            <nav class=""navbar navbar-expand-lg text-white"">
                <a class=""navbar-brand  "" href=""#"">Navbar</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                  <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarNav"">
                    <ul class=""navbar-nav ms-auto text-white "">
                        <li class=""nav-item active text-white "">
                            <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">About</a>
                        </li>
                        <li class=""nav-item"">
                          ");
            WriteLiteral(@"  <a class=""nav-link "" href=""#"">Services</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""#"">Portfolio</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""#"">Pricing</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""#"">Team</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                              Dropdown link
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                     ");
            WriteLiteral(@"           <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" href=""#"">Contact</a>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
        <div class=""hero w-100 h-100 pt-5 pb-5"">
            <div class=""container hero"">
                <h1>
                    WELCOME TO DAY
                </h1>
                <p>We are team of talented designers making websites with Bootstrap
                </p>
                <button type=""button "" class=""btn btn-outline-danger mytbn "">Danger</button>
            </div>

        </div>

    </header>
    <section class=""about-us"">
        <div class=""container"">
            <div class="" mb-3"">
                <div class=""ro");
            WriteLiteral("w g-0\">\r\n                    <div class=\"col-md-8 col-sm-12\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 3185, "\"", 3193, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p>Voluptatem dignissimos provident quasi corporis voluptates sit assumenda.
                            </p>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

                            </p>
                            <i>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                            </i>
                            <ul>
                                <li> Ullamco laboris nisi ut aliquip ex ea commodo consequat.
                                </li>
                                <li> Duis aute irure dolor in reprehenderit in voluptate velit. Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate trideta storacalaperda mastiro dolore eu fugiat nulla
                                    pariatur.
      ");
            WriteLiteral(@"                          </li>
                                <li> Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate trideta storacalaperda mastiro dolore eu fugiat nulla pariatur.
                                </li>
                            </ul>
                            <p>Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui
                                officia deserunt mollit anim id est laborum

                            </p>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 about-image"">
                        <img src=""/assets/images/about (1).jpg"" class=""img-fluid rounded-start"" alt=""..."">
                    </div>
                </div>
            </div>
            <div class=""crds"">");
            WriteLiteral(@"
                <div class=""row"">
                    <div class=""about-card col-md-4 col-sm-6"">
                        <div>
                            <h3>01</h3>
                            <p>Lorem Ipsum</p>
                            <p>Ulamco laboris nisi ut aliquip ex ea commodo consequat. Et consectetur ducimus vero placeat
                            </p>
                        </div>
                    </div>
                    <div class=""about-card col-md-4 col-sm-6"">
                        <div>
                            <h3>01</h3>
                            <p>Lorem Ipsum</p>
                            <p>Ulamco laboris nisi ut aliquip ex ea commodo consequat. Et consectetur ducimus vero placeat
                            </p>
                        </div>
                    </div>
                    <div class=""about-card col-md-4 col-sm-6"">
                        <div>
                            <h3>01</h3>
                            <p>Lorem Ipsum</p>");
            WriteLiteral(@"
                            <p>Ulamco laboris nisi ut aliquip ex ea commodo consequat. Et consectetur ducimus vero placeat
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>
    <div class=""distributord"">
        <div class=""container"">
            <div class="" flex-wrap d-flex justify-content-center gap-4 distributordss align-item-center pt-5 pb-5"">
                <div class="" "">
                    <img");
            BeginWriteAttribute("class", " class=\"", 6802, "\"", 6810, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"https://bootstrapmade.com/demo/templates/Day/assets/img/clients/client-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 6894, "\"", 6900, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 6948, "\"", 6956, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("class", " class=\"", 6984, "\"", 6992, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"https://bootstrapmade.com/demo/templates/Day/assets/img/clients/client-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7076, "\"", 7082, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 7130, "\"", 7138, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("class", " class=\"", 7166, "\"", 7174, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"https://bootstrapmade.com/demo/templates/Day/assets/img/clients/client-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7258, "\"", 7264, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 7312, "\"", 7320, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("class", " class=\"", 7348, "\"", 7356, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"https://bootstrapmade.com/demo/templates/Day/assets/img/clients/client-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7440, "\"", 7446, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 7494, "\"", 7502, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("class", " class=\"", 7530, "\"", 7538, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"https://bootstrapmade.com/demo/templates/Day/assets/img/clients/client-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7622, "\"", 7628, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 7676, "\"", 7684, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("class", " class=\"", 7712, "\"", 7720, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"https://bootstrapmade.com/demo/templates/Day/assets/img/clients/client-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7804, "\"", 7810, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>

    </div>
    <section class=""services"">
        <div class=""container text-center"">
            <h1>
                SERVICES
            </h1>
            <p>
                Sit sint consectetur velit quisquam cupiditate impedit suscipit alias
            </p>
            <div class=""row"">
                <div class=""about-cards  col-md-4 col-sm-8"">
                    <div class=""imgs"">
                        <i class="" bi bi-alarm""></i>
                        <p>Lorem Ipsum</p>
                        <p class=""text-black-50"">Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi
                        </p>
                    </div>
                </div>
                <div class=""about-cards  col-md-4 col-sm-8"">
                    <div class=""imgs"">
                        <i class="" bi bi-alarm""></i>
                        <p>Lorem Ipsum</p>
                        <p class=""text-black-5");
            WriteLiteral(@"0"">Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi
                        </p>
                    </div>
                </div>
                <div class=""about-cards  col-md-4 col-sm-8"">
                    <div class=""imgs"">
                        <i class="" bi bi-alarm""></i>
                        <p>Lorem Ipsum</p>
                        <p class=""text-black-50"">Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""about-cards  col-md-4 col-sm-8"">
                    <div class=""imgs"">
                        <i class="" bi bi-alarm""></i>
                        <p>Lorem Ipsum</p>
                        <p class=""text-black-50"">Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi
                        </p>
                    </div>
                </d");
            WriteLiteral(@"iv>
                <div class=""about-cards  col-md-4 col-sm-8"">
                    <div class=""imgs"">
                        <i class="" bi bi-alarm""></i>
                        <p>Lorem Ipsum</p>
                        <p class=""text-black-50"">Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi
                        </p>
                    </div>
                </div>
                <div class=""about-cards  col-md-4 col-sm-8"">
                    <div class=""imgs"">
                        <i class="" bi bi-alarm""></i>
                        <p>Lorem Ipsum</p>
                        <p class=""text-black-50"">Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""tsds"" class=""tsds"">
        <div class=""container text-white p-5"">
            <div class=""text-center"">
                <h3>Call T");
            WriteLiteral(@"o Action</h3>
                <p> Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p> <button type=""button ""
                    class=""btn btn-outline-danger mytbn "">Danger</button>
            </div>
        </div>
    </section>
    <section class=""portfolio"">
        <div class=""container text-center"">
            <h2>PORTFOLIO</h1>
                <p>Sit sint consectetur velit quisquam cupiditate impedit suscipit alias
                </p>
                <div class=""col-lg-12 "">
                    <ul class=""d-flex justify-content-center gap-4"">
                        <li>All</li>
");
#nullable restore
#line 227 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <li>");
#nullable restore
#line 229 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
                          Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 230 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 235 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
                                             foreach (var item in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 \">\r\n                        <div class=\"containers\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "163371c8b7be9fa6a84e3d77e3f6c78ed3c4344721247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 12147, "~/assets/images/", 12147, 16, true);
#nullable restore
#line 239 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 12163, item.Image, 12163, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"middle\">\r\n                                <div class=\"textss\">\r\n                                    <h1>\r\n\r\n                                        ");
#nullable restore
#line 244 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 246 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 252 "C:\Users\Administrator\Desktop\day\day\day\Views\Home\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
    </section>
    <section class=""price"">
        <div class=""container text-center"">
            <div class=""tststs row  text-center"">
                <div class=""buy-dv col-lg-4 col-sm-12 text center "">
                    <h3>FREE</h3>
                    <h4><sup>$</sup>0<span> / month</span></h4>
                    <p>Aida dere
                    </p>
                    <p>
                        Nec feugiat nisl
                    </p>
                    <p>Nulla at volutpat dola
                    </p>
                    <del class=""text-black-50 d-block"">Pharetra massa
                    </del>
                    <del class=""text-black-50 d-block"">Pharetra massa
                    </del>
                    <a href=""#"" class=""btn btn-danger "" tabindex=""-1"" role=""button"" aria-disabled=""true"">Primary link</a>

                </div>
                <div class=""buy-dv2 col-lg-4 col-sm-12 text center "">
                    <h3>FREE</h3>
          ");
            WriteLiteral(@"          <h4><sup>$</sup>0<span> / month</span></h4>
                    <p>Aida dere
                    </p>
                    <p>
                        Nec feugiat nisl
                    </p>
                    <p>Nulla at volutpat dola
                    </p>
                    <del class=""text-black-50 d-block"">Pharetra massa
                    </del>
                    <del class=""text-black-50 d-block"">Pharetra massa
                    </del>
                    <a href=""#"" class=""btn btn-danger "" tabindex=""-1"" role=""button"" aria-disabled=""true"">Primary link</a>

                </div>
                <div class=""buy-dv col-lg-4 col-sm-12 text center "">
                    <h3>FREE</h3>
                    <h4><sup>$</sup>0<span> / month</span></h4>
                    <p>Aida dere
                    </p>
                    <p>
                        Nec feugiat nisl
                    </p>
                    <p>Nulla at volutpat dola
                    </p>
");
            WriteLiteral(@"                    <del class=""text-black-50 d-block"">Pharetra massa
                    </del>
                    <del class=""text-black-50 d-block"">Pharetra massa
                    </del>
                    <a href=""#"" class=""btn btn-danger "" tabindex=""-1"" role=""button"" aria-disabled=""true"">Primary link</a>

                </div>
            </div>

        </div>
    </section>
    <section class=""team"">
        <div class=""container text-center"">
            <h3>TEAM
            </h3>
            <p>Sit sint consectetur velit quisquam cupiditate impedit suscipit alias

            </p>
            <div class=""row"">
                <div class=""col-lg-4 col-sm-8"">
                    <img src=""/assets/images/team-1.jpg"" alt=""Avatar"" class=""avatar"">
                    <h3>Walter White
                    </h3>
                    <p class=""p1-2"">Chief Executive Officer
                    </p>
                    <p class=""text-black-50"">Magni qui quod omnis unde et eos fuga e");
            WriteLiteral(@"t exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut
                    </p>
                    <i class=""bi bi-instagram""></i>
                    <i class=""bi bi-twitter""></i>
                </div>
                <div class=""col-lg-4 col-sm-8"">
                    <img src=""/assets/images/team-1.jpg"" alt=""Avatar"" class=""avatar"">
                    <h3>Walter White
                    </h3>
                    <p class=""p1-2"">Chief Executive Officer
                    </p>
                    <p class=""text-black-50"">Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut
                    </p>
                    <i class=""bi bi-instagram""></i>
                    <i class=""bi bi-twitter""></i>
                </div>
                <div class=""col-lg-4 col-sm-8"">
                    <img src=""/assets/images/team-1.jpg"" alt=""Avatar"" class=""avatar"">
                    <h3>Walter White
                    </h3>
 ");
            WriteLiteral(@"                   <p class=""pb-2 pt-2"">Chief Executive Officer
                    </p>
                    <p class=""text-black-50"">Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut
                    </p>
                    <i class=""bi bi-instagram""></i>
                    <i class=""bi bi-twitter""></i>
                </div>
            </div>

        </div>
    </section>
    <section class=""contact"">
        <div class=""container text-center"">
            <h3>CONTACT
            </h3>
            <p>
                Sit sint consectetur velit quisquam cupiditate impedit suscipit alias
            </p>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <i class=""cstmicnsd bi bi-apple""></i>
                    <h3>Our Address
                    </h3>
                    <p class=""text-black-50"">
                        A108 Adam Street, New York, NY 535022
                    </p>");
            WriteLiteral(@"
                </div>
                <div class=""col-lg-2"">
                    <i class=""cstmicnsd bi bi-apple""></i>
                    <h3>Our Address
                    </h3>
                    <p class=""text-black-50"">
                        A108 Adam Street, New York, NY 535022
                    </p>
                </div>
                <div class=""col-lg-2"">
                    <i class=""cstmicnsd bi bi-apple""></i>
                    <h3>Our Address
                    </h3>
                    <p class=""text-black-50"">
                        A108 Adam Street, New York, NY 535022
                    </p>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">

                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3614.6452078903058!2d49.81593099503922!3d40.37467428426023!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307deb736b");
            WriteLiteral("4435%3A0x958d0f749acb3351!2zRml6aWthLVJpeWF6aXl5YXQgdsmZIMSwbmZvcm1hdGlrYSBUyZltYXnDvGxsw7wgTGlzZXk!5e0!3m2!1sen!2s!4v1655455301902!5m2!1sen!2s\"\r\n                        width=\"600\" height=\"450\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 19075, "\"", 19093, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"col-lg-6\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "163371c8b7be9fa6a84e3d77e3f6c78ed3c4344731140", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-6 form-group\"> <input type=\"text\" name=\"name\" class=\"form-control\" id=\"name\" placeholder=\"Your Name\"");
                BeginWriteAttribute("required", " required=\"", 19579, "\"", 19590, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                <div class=\"col-md-6 form-group mt-3 mt-md-0\"> <input type=\"email\" class=\"form-control\" name=\"email\" id=\"email\" placeholder=\"Your Email\"");
                BeginWriteAttribute("required", " required=\"", 19768, "\"", 19779, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                            </div>\r\n                            <div class=\"form-group mt-3\"> <input type=\"text\" class=\"form-control\" name=\"subject\" id=\"subject\" placeholder=\"Subject\"");
                BeginWriteAttribute("required", " required=\"", 19972, "\"", 19983, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                            <div class=\"form-group mt-3\"><textarea class=\"form-control\" name=\"message\" rows=\"5\" placeholder=\"Message\"");
                BeginWriteAttribute("required", " required=\"", 20126, "\"", 20137, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea></div>
                            <div class=""my-3"">
                                <div class=""loading"">Loading</div>
                                <div class=""error-message""></div>
                                <div class=""sent-message"">Your message has been sent. Thank you!</div>
                            </div>
                            <div class=""text-center""><button type=""submit"">Send Message</button></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
