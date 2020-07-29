using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AtlanticCovidTracker.Web.Infrastructure
{
    [HtmlTargetElement("span", Attributes = ForAttributeName)]
    public class SpanForTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression DescriptionFor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var metadata = DescriptionFor.Metadata;
            // TODO NullDisplayContent, DisplayFormatString...
            var content = metadata.DisplayName ?? metadata.Name;
            output.Content.SetContent(content);
            if (!string.IsNullOrEmpty(metadata.Description))
            {
                output.Attributes.Add("title", metadata.Description);
            }
            output.TagMode = TagMode.StartTagAndEndTag;

        }
    }
}
