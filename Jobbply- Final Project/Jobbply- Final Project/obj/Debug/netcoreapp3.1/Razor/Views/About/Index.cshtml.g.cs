#pragma checksum "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c48b5c4de8072a9fa744d90477d4f74908f8ea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\_ViewImports.cshtml"
using Jobbply__Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\_ViewImports.cshtml"
using Jobbply__Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c48b5c4de8072a9fa744d90477d4f74908f8ea3", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b880dbdf7d60f0f3d935e800be6e7f59cae8367", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <!-- MAIN START -->
    <main>
        <!-- Small introductory part -->
        <section id=""about"">
        <div class=""container"">
          <div class=""row"">
            <div class=""col-lg-6 col-md-12 mb-6"">
              <div class=""text-block p-5"">
                <div class=""content"">
                  <span class=""subtitle"">");
#nullable restore
#line 16 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                                    Write(Model.about.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa-solid fa-angle-right\"></i></span>\r\n                  <span class=\"title\"> ");
#nullable restore
#line 17 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                                  Write(Model.about.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                  <h1>");
#nullable restore
#line 18 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                 Write(Model.about.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                 
                </div>
              </div>
            </div>
          </div>
         </div>
        </section>

        <!-- Information about your welcome section of the site -->
        <section id=""welcome"">
            <div class=""container"">
                <div class=""welcome-img"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 979, "\"", 1026, 2);
            WriteAttributeValue("", 985, "./assets/image/about/", 985, 21, true);
#nullable restore
#line 31 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
WriteAttributeValue("", 1006, Model.welcome.Image, 1006, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1027, "\"", 1033, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"welcome-title\">\r\n                    <h3>");
#nullable restore
#line 34 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                   Write(Model.welcome.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"welcome-text\">\r\n                    <p>");
#nullable restore
#line 37 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                  Write(Model.welcome.Desc1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 38 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                  Write(Model.welcome.Desc2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>

            </div>
        </section>

        <!-- Statistics section of the site -->
        <section id=""job-statistics"">
          <div class=""statistic"">
            <div class=""container"">
              <div class=""row row-cols-1 row-cols-md-4 g-3"">
");
#nullable restore
#line 49 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                 foreach (var item in Model.jobStatistics)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   <div class=""col reveal"">
                  <div class=""card"">
                    <div class=""card-icon"">
                      <i class=""fa-solid fa-user""></i>
                    </div>
                    <div class=""card-body"">
                      <h3 class=""counter"" data-target=""435000"">");
#nullable restore
#line 57 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <span >");
#nullable restore
#line 58 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                          Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                  </div>\r\n                </div>\n");
#nullable restore
#line 62 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
              </div>
            </div>
          </div>
        </section>

        <!-- Testimonial section of the site-->
        <section class=""slider_client"" id=""slider_client"">
          <div class=""slider"">
            <div class=""container"">
              <div class=""swipper-title reveal"">
                <span class=""subtitle"">Testimonial</span>
                <h2>Happy Clients</h2>
              </div>
              <div class=""swiper card_client"">
                <div class=""swiper-wrapper"">
");
#nullable restore
#line 79 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                     foreach (var item in Model.clientSliders)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"swiper-slide reveal\">\r\n                     \r\n                        <div class=\"img_box\" >\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2964, "\"", 3001, 2);
            WriteAttributeValue("", 2970, "./assets/image/home/", 2970, 20, true);
#nullable restore
#line 84 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
WriteAttributeValue("", 2990, item.Image, 2990, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3002, "\"", 3008, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                          <span class=""quote d-flex"">
                            <i class=""fa-solid fa-quote-left""></i>
                          </span>
                          </div>

                        <div class=""swipper-text"">
                           <p class=""mb-4"">");
#nullable restore
#line 91 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                                      Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"name\">");
#nullable restore
#line 92 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <span class=\"position\">");
#nullable restore
#line 93 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                                              Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\n");
#nullable restore
#line 96 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  \r\n              \r\n                </div>\r\n                <div class=\"swiper-pagination\"></div>\r\n            </div>\r\n            </div>\r\n          </div>\r\n        </section>\r\n\r\n        <!-- Subscribe section of the site-->\r\n         ");
#nullable restore
#line 107 "C:\Users\nargi\Desktop\Jobbply- Final Project\Jobbply- Final Project\Views\About\Index.cshtml"
    Write(await Component.InvokeAsync("Subscribe"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </main>\r\n  <!-- MAIN END -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
