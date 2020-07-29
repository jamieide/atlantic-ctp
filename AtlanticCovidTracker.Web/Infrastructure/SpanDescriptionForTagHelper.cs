using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AtlanticCovidTracker.Web.Infrastructure
{
    [HtmlTargetElement("span", Attributes = DescriptionForAttributeName)]
    public class SpanDescriptionForTagHelper : TagHelper
    {
        private const string DescriptionForAttributeName = "asp-description-for";

        [HtmlAttributeName(DescriptionForAttributeName)]
        public ModelExpression DescriptionFor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var metadata = DescriptionFor.Metadata;
            if (metadata.Description != null)
            {
                output.Content.SetContent(metadata.Description);
                output.TagMode = TagMode.StartTagAndEndTag;
            }
        }
    }
}
