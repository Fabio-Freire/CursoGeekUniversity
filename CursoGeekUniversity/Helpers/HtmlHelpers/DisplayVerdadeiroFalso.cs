using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoGeekUniversity.Helpers.HtmlHelpers
{
    public static class DisplayVerdadeiroFalso
    {
        public static IHtmlContent DisplayTrueFalse (bool valeuBooleano)
        {
            var span = new TagBuilder("span");
            if (valeuBooleano)
            {
                span.AddCssClass("badge badge-success");
                span.InnerHtml.Append("Verdadeiro");
            }
            else
            {
                span.AddCssClass("badge badge-danger");
                span.InnerHtml.Append("Falso");
            }
            return span;
        }
    }
}
