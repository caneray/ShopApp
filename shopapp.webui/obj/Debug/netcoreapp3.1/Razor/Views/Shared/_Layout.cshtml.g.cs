#pragma checksum "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e11227609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e11227609", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fbfbe6d65edb8462deb7247d34b3d2c339446211ece7e7b9b6b398850cdb6dd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/aylogo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("IMG-LOGO"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<!DOCTYPE html>\n<html lang=\"tr\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e112276096127", async() => {
                WriteLiteral("\n    <title>AY Store</title>\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    ");
#nullable restore
#line 9 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
Write(RenderSection("Css",false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <link rel=""icon"" type=""image/png"" href=""/temp/images/icons/favicon.png"" />

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/bootstrap/css/bootstrap.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/fonts/iconic/css/material-design-iconic-font.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/fonts/linearicons-v1.0.0/icon-font.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/animate/animate.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/css-hamburgers/hamburgers.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/animsition/css/animsition.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/select2/select2.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/daterangepicker/daterangepicker.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/te");
                WriteLiteral(@"mp/vendor/slick/slick.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/MagnificPopup/magnific-popup.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/vendor/perfect-scrollbar/perfect-scrollbar.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""/temp/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/temp/css/main.css"">

    <script nonce=""bc9aeea2-2883-4545-83c2-99ff49a7b614"">try { (function (w, d) { !function (j, k, l, m) { j[l] = j[l] || {}; j[l].executed = []; j.zaraz = { deferred: [], listeners: [] }; j.zaraz._v = ""5621""; j.zaraz.q = []; j.zaraz._f = function (n) { return async function () { var o = Array.prototype.slice.call(arguments); j.zaraz.q.push({ m: n, a: o }) } }; for (const p of [""track"", ""set"", ""debug""]) j.zaraz[p] = j.zaraz._f(p); j.zaraz.init = () => { var q = k.getElementsByTagName(m)[0], r = k.createElement(m), s = k.getElementsByTagName(""title"")[0]; s && (j[l].t = k.getElementsByTagName(""title"")[0].text); j[l].x = Math.random(); j[l].w = j");
                WriteLiteral(@".screen.width; j[l].h = j.screen.height; j[l].j = j.innerHeight; j[l].e = j.innerWidth; j[l].l = j.location.href; j[l].r = k.referrer; j[l].k = j.screen.colorDepth; j[l].n = k.characterSet; j[l].o = (new Date).getTimezoneOffset(); if (j.dataLayer) for (const w of Object.entries(Object.entries(dataLayer).reduce(((x, y) => ({ ...x[1], ...y[1] })), {}))) zaraz.set(w[0], w[1], { scope: ""page"" }); j[l].q = []; for (; j.zaraz.q.length;) { const z = j.zaraz.q.shift(); j[l].q.push(z) } r.defer = !0; for (const A of [localStorage, sessionStorage]) Object.keys(A || {}).filter((C => C.startsWith(""_zaraz_""))).forEach((B => { try { j[l][""z_"" + B.slice(7)] = JSON.parse(A.getItem(B)) } catch { j[l][""z_"" + B.slice(7)] = A.getItem(B) } })); r.referrerPolicy = ""origin""; r.src = ""../../cdn-cgi/zaraz/sd0d9.js?z="" + btoa(encodeURIComponent(JSON.stringify(j[l]))); q.parentNode.insertBefore(r, q) };[""complete"", ""interactive""].includes(k.readyState) ? zaraz.init() : j.addEventListener(""DOMContentLoaded"", zaraz.init) }(w, d, ""zarazDa");
                WriteLiteral("ta\", \"script\"); })(window, document) } catch (e) { throw fetch(\"/cdn-cgi/zaraz/t\"), e; };</script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e1122760910896", async() => {
                WriteLiteral(@"

    <header class=""header-v4"">

        <div class=""container-menu-desktop"">

            <div class=""top-bar"">
                <div class=""content-topbar flex-sb-m h-full container"">
                    <div class=""left-top-bar"">
                    </div>
                    <div class=""right-top-bar flex-w h-full"">

");
#nullable restore
#line 54 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"#\" class=\"flex-c-m trans-04 p-lr-25\">\n                                ");
#nullable restore
#line 58 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </a>\n");
                WriteLiteral("                            <a href=\"/account/logout\" class=\"flex-c-m trans-04 p-lr-25\">Çıkış Yap</a>\n");
#nullable restore
#line 63 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"

                        }
                        else
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/account/login\" class=\"flex-c-m trans-04 p-lr-25\">Giriş Yap</a>\n");
                WriteLiteral("                            <a href=\"/account/register\" class=\"flex-c-m trans-04 p-lr-25\">Kayıt Ol</a>\n");
#nullable restore
#line 71 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n            </div>\n            <div class=\"wrap-menu-desktop how-shadow1\">\n                <nav class=\"limiter-menu-desktop container\">\n\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e1122760913320", async() => {
                    WriteLiteral("\n");
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e1122760913669", async() => {
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
                    WriteLiteral("\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                    <div class=\"menu-desktop\">\n                        <ul class=\"main-menu\">\n                            <li>\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e1122760916069", async() => {
                    WriteLiteral("Anasayfa");
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
                WriteLiteral("\n                            </li>\n                            <li>\n                                <a href=\"/products\" class=\"nav-link\">Ürünler</a>\n                            </li>\n\n");
#nullable restore
#line 94 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <li>
                                    <a href=""/cart"" class=""nav-link"">Sepet</a>
                                </li>
                                <li>
                                    <a href=""/orders"" class=""nav-link"">Siparişler</a>
                                </li>
");
#nullable restore
#line 102 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"

                                if (User.IsInRole("admin"))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li>
                                        <a href=""/admin/products"" class=""nav-link"">Ürün İşlemleri</a>
                                    </li>
                                    <li>
                                        <a href=""/admin/categories"" class=""nav-link"">Kategori İşlemleri</a>
                                    </li>
                                    <li>
                                        <a href=""/admin/role/list"" class=""nav-link"">Roller</a>
                                    </li>
                                    <li>
                                        <a href=""/admin/user/list"" class=""nav-link"">Kullanıcılar</a>
                                    </li>
");
#nullable restore
#line 117 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </ul>
                    </div>




                    <div class=""wrap-icon-header flex-w flex-r-m"">
                        <div class=""icon-header-item cl2 hov-cl1 trans-04 p-l-22 p-r-11 js-show-modal-search"">
                            <i class=""zmdi zmdi-search""></i>
                        </div>
                        <div class=""icon-header-item cl2 hov-cl1 trans-04 p-l-22 p-r-11 js-show-cart"">
                            <i class=""zmdi zmdi-shopping-cart""></i>
                        </div>

                    </div>
                </nav>
            </div>
        </div>

        <div class=""wrap-header-mobile"" style=""width: 100%; background-color:black; height:40px; justify-content:flex-end"">
            <div class=""top-bar"">
                <div class=""content-topbar flex-sb-m h-full container"" style=""background-color: black;"">
                    <div class=""left-top-bar"">
                    </div>
                    <div class=""right-top-bar flex-w h-full"">

");
#nullable restore
#line 146 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"#\" class=\"flex-c-m trans-04 p-lr-25\">\n                                ");
#nullable restore
#line 150 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </a>\n");
                WriteLiteral("                            <a href=\"/account/logout\" class=\"flex-c-m trans-04 p-lr-25\">Çıkış Yap</a>\n");
#nullable restore
#line 155 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"

                        }
                        else
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/account/login\" class=\"flex-c-m trans-04 p-lr-25\">Giriş Yap</a>\n");
                WriteLiteral("                            <a href=\"/account/register\" class=\"flex-c-m trans-04 p-lr-25\">Kayıt Ol</a>\n");
#nullable restore
#line 163 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n        \n\n        <div class=\"wrap-header-mobile\">\n\n            <div class=\"logo-mobile\">\n                <a href=\"/Home/Index\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e129862efaf16eadc921efd304165c6e05053cf4736a8c0e259c76e1122760922223", async() => {
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
                WriteLiteral(@"</a>

            </div>

            <div class=""wrap-icon-header flex-w flex-r-m m-r-15"">
                <div class=""icon-header-item cl2 hov-cl1 trans-04 p-r-11 js-show-modal-search"">
                    <i class=""zmdi zmdi-search""></i>
                </div>
                <div class=""icon-header-item cl2 hov-cl1 trans-04 p-l-22 p-r-11 js-show-cart"">
                    <i class=""zmdi zmdi-shopping-cart""></i>
                </div>

            </div>

            <div class=""btn-show-menu-mobile hamburger hamburger--squeeze"">
                <span class=""hamburger-box"">
                    <span class=""hamburger-inner""></span>
                </span>
            </div>
        </div>

        <div class=""menu-mobile"">
            <ul class=""main-menu-m"">
                <li>
                    <a href=""/Home/Index"">Anasayfa</a>
                </li>
                <li>
                    <a href=""/products"">Ürünler</a>
                </li>
                <li>
                    <a href=""/cart"">Se");
                WriteLiteral("pet</a>\n                </li>\n            </ul>\n        </div>\n\n        <div class=\"modal-search-header flex-c-m trans-04 js-hide-modal-search\">\n            <div class=\"container-search-header\">\n                ");
#nullable restore
#line 212 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
           Write(await Component.InvokeAsync("Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                <button class=""flex-c-m btn-hide-modal-search trans-04 js-hide-modal-search"">
                    <img src=""/temp/images/icons/icon-close2.png"" alt=""CLOSE"">



                </button>
            </div>
        </div>
    </header>

    ");
#nullable restore
#line 224 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Cart", User));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n    ");
#nullable restore
#line 227 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


    <footer class=""bg3 p-t-75 p-b-32"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-sm-6 col-lg-3 p-b-50"">
                    <h4 class=""stext-301 cl0 p-b-30"">
                        Kategoriler
                    </h4>
                    <ul>
                        <li class=""p-b-10"">
                            <a href=""/products/telefon"" class=""stext-107 cl7 hov-cl1 trans-04"">
                                Telefon
                            </a>
                        </li>
                        <li class=""p-b-10"">
                            <a href=""/products/bilgisayar"" class=""stext-107 cl7 hov-cl1 trans-04"">
                                Bilgisayar
                            </a>
                        </li>
                        <li class=""p-b-10"">
                            <a href=""/products/tablet"" class=""stext-107 cl7 hov-cl1 trans-04"">
                                Tablet
                            </a");
                WriteLiteral(@">
                        </li>
                    </ul>
                </div>
                <div class=""col-sm-6 col-lg-3 p-b-50"">
                    <h4 class=""stext-301 cl0 p-b-30"">
                        İletişim
                    </h4>
                    <p class=""stext-107 cl7 size-201"">
                        Kemalpaşa, Esentepe Kampüsü, Üniversite Cd., 54050 Serdivan/Sakarya 444 1 728
                    </p>
                    <div class=""p-t-27"">
                        <a href=""https://www.facebook.com/sakaryauni/"" class=""fs-18 cl7 hov-cl1 trans-04 m-r-16"">
                            <i class=""fa fa-facebook""></i>
                        </a>
                        <a href=""https://www.instagram.com/sakaryauni/?hl=tr"" class=""fs-18 cl7 hov-cl1 trans-04 m-r-16"">
                            <i class=""fa fa-instagram""></i>
                        </a>
                        <a href=""https://tr.pinterest.com/habersau/"" class=""fs-18 cl7 hov-cl1 trans-04 m-r-16"">
                            ");
                WriteLiteral(@"<i class=""fa fa-pinterest-p""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""p-t-40"">
            <div class=""flex-c-m flex-w p-b-18"">
                <a href=""#"" class=""m-all-1"">
                    <img src=""/temp/images/icons/icon-pay-01.png"" alt=""ICON-PAY"">
                </a>
                <a href=""#"" class=""m-all-1"">
                    <img src=""/temp/images/icons/icon-pay-02.png"" alt=""ICON-PAY"">
                </a>
                <a href=""#"" class=""m-all-1"">
                    <img src=""/temp/images/icons/icon-pay-03.png"" alt=""ICON-PAY"">
                </a>
                <a href=""#"" class=""m-all-1"">
                    <img src=""/temp/images/icons/icon-pay-04.png"" alt=""ICON-PAY"">
                </a>
                <a href=""#"" class=""m-all-1"">
                    <img src=""/temp/images/icons/icon-pay-05.png"" alt=""ICON-PAY"">
                </a>
            </div>
            <p class=""stext-107 cl6 txt-");
                WriteLiteral(@"center"">

                Copyright &copy;<script>document.write(new Date().getFullYear());</script> Tüm Hakları Saklıdır

            </p>
        </div>
        </div>
    </footer>

    <div class=""btn-back-to-top"" id=""myBtn"">
        <span class=""symbol-btn-back-to-top"">
            <i class=""zmdi zmdi-chevron-up""></i>
        </span>
    </div>

");
                WriteLiteral(@"
    <script src=""/temp/vendor/jquery/jquery-3.2.1.min.js""></script>

    <script src=""/temp/vendor/animsition/js/animsition.min.js""></script>

    <script src=""/temp/vendor/bootstrap/js/popper.js""></script>
    <script src=""/temp/vendor/bootstrap/js/bootstrap.min.js""></script>

    <script src=""/temp/vendor/select2/select2.min.js""></script>
    <script>
        $("".js-select2"").each(function () {
            $(this).select2({
                minimumResultsForSearch: 20,
                dropdownParent: $(this).next('.dropDownSelect2')
            });
        })
    </script>

    <script src=""/temp/vendor/daterangepicker/moment.min.js""></script>
    <script src=""/temp/vendor/daterangepicker/daterangepicker.js""></script>

    <script src=""/temp/vendor/slick/slick.min.js""></script>
    <script src=""/temp/js/slick-custom.js""></script>

    <script src=""/temp/vendor/parallax100/parallax100.js""></script>
    <script>
        $('.parallax100').parallax100();
    </script>

    <script src=""/temp/vendor/MagnificPopu");
                WriteLiteral(@"p/jquery.magnific-popup.min.js""></script>
    <script>
        $('.gallery-lb').each(function () { // the containers for all your galleries
            $(this).magnificPopup({
                delegate: 'a', // the selector for gallery item
                type: 'image',
                gallery: {
                    enabled: true
                },
                mainClass: 'mfp-fade'
            });
        });
    </script>

    <script src=""/temp/vendor/isotope/isotope.pkgd.min.js""></script>

    <script src=""/temp/vendor/sweetalert/sweetalert.min.js""></script>
    <script>
        $('.js-addwish-b2, .js-addwish-detail').on('click', function (e) {
            e.preventDefault();
        });

        $('.js-addwish-b2').each(function () {
            var nameProduct = $(this).parent().parent().find('.js-name-b2').html();
            $(this).on('click', function () {
                swal(nameProduct, ""is added to wishlist !"", ""success"");

                $(this).addClass('js-addedwish-b2');
                ");
                WriteLiteral(@"$(this).off('click');
            });
        });

        $('.js-addwish-detail').each(function () {
            var nameProduct = $(this).parent().parent().parent().find('.js-name-detail').html();

            $(this).on('click', function () {
                swal(nameProduct, ""is added to wishlist !"", ""success"");

                $(this).addClass('js-addedwish-detail');
                $(this).off('click');
            });
        });

        /*---------------------------------------------*/

        $('.js-addcart-detail').each(function () {
            var nameProduct = $(this).parent().parent().parent().parent().find('.js-name-detail').html();
            $(this).on('click', function () {
                swal(nameProduct, ""is added to cart !"", ""success"");
            });
        });

    </script>

    <script src=""/temp/vendor/perfect-scrollbar/perfect-scrollbar.min.js""></script>
    <script>
        $('.js-pscroll').each(function () {
            $(this).css('position', 'relative');
            $(thi");
                WriteLiteral(@"s).css('overflow', 'hidden');
            var ps = new PerfectScrollbar(this, {
                wheelSpeed: 1,
                scrollingThreshold: 1000,
                wheelPropagation: false,
            });

            $(window).on('resize', function () {
                ps.update();
            })
        });
    </script>

    <script src=""/temp/js/main.js""></script>

    <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-23581568-13""></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'UA-23581568-13');
    </script>
    <script defer src=""https://static.cloudflareinsights.com/beacon.min.js/v55bfa2fee65d44688e90c00735ed189a1713218998793"" integrity=""sha512-FIKRFRxgD20moAo96hkZQy/5QojZDAbyx0mQ17jEGHCJc/vi0G2HXLtofwD7Q3NmivvP9at5EVgbRqOaOQb+Rg=="" data-cf-beacon='{""rayId"":""87ce090ac877363e"",""b"":1,""version"":""2024.4.1"",""token"":""cd0b4b3a733644fc843ef0b185f98241""}'");
                WriteLiteral(" crossorigin=\"anonymous\"></script>\n\n    ");
#nullable restore
#line 550 "C:\Users\caner\OneDrive\Masaüstü\shopapp\shopapp.webui\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
