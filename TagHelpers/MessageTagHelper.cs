using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace globalsolution.fomezero.TagHelpers
{
    public class MessageTagHelper : TagHelper
    {
        public string Text { get; set; }
        public string Class { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                output.TagName = "div";
                output.Attributes.SetAttribute("class",
                    string.IsNullOrEmpty(Class) ? "alert alert-success" : Class);
                output.Content.SetContent(Text);
            }
        }
    }
}
