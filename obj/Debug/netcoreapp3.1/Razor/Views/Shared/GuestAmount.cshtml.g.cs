#pragma checksum "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\Shared\GuestAmount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665515575f9b6f5baa002481573e248037a45062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GuestAmount), @"mvc.1.0.view", @"/Views/Shared/GuestAmount.cshtml")]
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
#line 1 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\_ViewImports.cshtml"
using webapp_rucspeciale;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jesper\Documents\Projekter\webapp-rucspeciale\webapp-rucspeciale\Views\_ViewImports.cshtml"
using webapp_rucspeciale.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665515575f9b6f5baa002481573e248037a45062", @"/Views/Shared/GuestAmount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e3c4eb7ce23eda2c606dab076b955a7c8f8581", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_GuestAmount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webapp_rucspeciale.Models.ReservationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .qty .count {
        color: #000;
        display: inline-block;
        vertical-align: top;
        font-size: 25px;
        font-weight: 700;
        line-height: 30px;
        padding: 0 2px;
        min-width: 35px;
        text-align: center;
    }

    .qty .plus {
        cursor: pointer;
        display: inline-block;
        vertical-align: top;
        color: white;
        width: 30px;
        height: 30px;
        font: 30px/1 Arial,sans-serif;
        text-align: center;
        border-radius: 50%;
    }

    .qty .minus {
        cursor: pointer;
        display: inline-block;
        vertical-align: top;
        color: white;
        width: 30px;
        height: 30px;
        font: 30px/1 Arial,sans-serif;
        text-align: center;
        border-radius: 50%;
        background-clip: padding-box;
    }

    div {
        text-align: center;
    }

    .minus:hover {
        background-color: #717fe0 !important;
    }

    .plus:hov");
            WriteLiteral(@"er {
        background-color: #717fe0 !important;
    }
    /*Prevent text selection*/
    span {
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
    }

    #AmountOfGuestsInput {
        border: 0;
        width: 2%;
    }

        #AmountOfGuestsInput::-webkit-outer-spin-button,
        #AmountOfGuestsInput::-webkit-inner-spin-button {
            -webkit-appearance: none;
            margin: 0;
        }

        #AmountOfGuestsInput:disabled {
            background-color: white;
        }
         
</style>



    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <!------ Include the above in your HEAD tag ---------->

    <div class=""container"">
        <div class=""qty mt-5"">
 ");
            WriteLiteral(@"           <span class=""minus bg-dark"">-</span>
            <input id=""AmountOfGuestsInput"" type=""number"" class=""count"" name=""qty"" value=""1"">
            <span class=""plus bg-dark"">+</span>
        </div>
        <button id=""AmountOfGuestsButton"" type=""button"" class=""btn btn-primary"">Næste</button>
    </div>


<script>
    $(document).ready(function () {
        $('.count').prop('disabled', true);
        $(document).on('click', '.plus', function () {
            $('.count').val(parseInt($('.count').val()) + 1);
        });
        $(document).on('click', '.minus', function () {
            $('.count').val(parseInt($('.count').val()) - 1);
            if ($('.count').val() == 0) {
                $('.count').val(1);
            }
        });
    });


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapp_rucspeciale.Models.ReservationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591